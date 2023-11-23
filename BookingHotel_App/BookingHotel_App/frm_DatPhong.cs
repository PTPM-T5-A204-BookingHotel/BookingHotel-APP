using BLL_DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingHotel_App
{
    public partial class frm_DatPhong : DevExpress.XtraEditors.XtraForm
    {
        public frm_DatPhong()
        {
            InitializeComponent();
            lbl_MaHD.TextChanged += Lbl_MaHD_TextChanged;
        }

        private void Lbl_MaHD_TextChanged(object sender, EventArgs e)
        {
            tsBtn_DatDV.Enabled = true;
            tsBtn_SuaDV.Enabled = true;
            tsBtn_XoaDV.Enabled = true;
            tsBtn_DatVT.Enabled = true;
            tsBtn_SuaVT.Enabled = true;
            tsBtn_XoaVT.Enabled = true;
        }

        Basis ba = new Basis();
        ErrorProvider ep = new ErrorProvider();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        KhachHang_BLL_DAL khblldal = new KhachHang_BLL_DAL();
        VatTu_BLL_DAL vt_blldal = new VatTu_BLL_DAL();
        DichVu_BLL_DAL dv_blldal = new DichVu_BLL_DAL();
        HoaDon_BLL_DAL hdblldal = new HoaDon_BLL_DAL();
        HoaDon_DichVu_BLL_DAL hddvblldal = new HoaDon_DichVu_BLL_DAL();
        HoaDon_VatTu_BLL_DAL hdvtblldal = new HoaDon_VatTu_BLL_DAL();
        Phong_BLL_DAL phblldal = new Phong_BLL_DAL();
        LoaiPhong_BLL_DAL lphblldal = new LoaiPhong_BLL_DAL();
        public void LoadData(string tenph,string tentk)
        {
            dgv_DichVu.DataSource = dv_blldal.getDVs();
            vt_blldal.getVT_DatPhong(dgv_VatTu);
            hdblldal.getHD_DatPhong(dgv_DonDat, tenph);
            khblldal.getKH_DatPhong(dgv_KhachHang);
            lbl_Phong.Text = tenph;
            int maph = phblldal.getMaPh(tenph);
            lbl_TinhTrangPH.Text = phblldal.getPH(maph).TinhTrangPH;
            lbl_Tang.Text = phblldal.getPH(maph).Tang.ToString();
            int malp = phblldal.getPH(maph).MaLP;
            lbl_GiaPH.Text = lphblldal.getGialp(malp);
            lbl_LoaiPH.Text = lphblldal.getTenlp(malp);
            tssLbl_TenTK.Text = tentk;
            tssLbl_TongCong_HD.Text = dgv_DonDat.RowCount.ToString();
            

        }
        private void frm_DatPhong_Load(object sender, EventArgs e)
        {
            tsBtn_DatDV.Enabled = false;
            tsBtn_SuaDV.Enabled = false;
            tsBtn_XoaDV.Enabled = false;
            tsBtn_DatVT.Enabled = false;
            tsBtn_SuaVT.Enabled = false;
            tsBtn_XoaVT.Enabled = false;
            dt_NgayDat.Value  = DateTime.Now.Date;
        }

        private void tsBtn_TimKiemVT_Click(object sender, EventArgs e)
        {
            if (dgv_VatTu.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                string search = txt_TimKiemVT.Text;
                vt_blldal.search(search, dgv_VatTu);
            }

        }

        private void tsBtn_TimKiemDV_Click(object sender, EventArgs e)
        {
            if (dgv_DichVu.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                string search = txt_TimKiemDV.Text;
                dgv_DichVu.DataSource = dv_blldal.search(search);
            }
        }

        private void tsBtn_TimKiemKH_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                string search = txt_TimKiemCCCD.Text;
                khblldal.search(search, dgv_KhachHang);
            }
        }

        private void tsBtn_ThemKH_Click(object sender, EventArgs e)
        {
            frm_ThemKH frm = new frm_ThemKH();
            frm.ShowDialog();
        }

        private void tsBtn_SuaKH_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                int index = dgv_KhachHang.CurrentRow.Index;
                if (index < 0)
                {
                    this.Message("Chưa chọn khách hàng", MyMessageBox.enmType.Error);
                }
                else
                {
                    string cccd = dgv_KhachHang.Rows[index].Cells["CCCDKH"].Value.ToString();
                    frm_SuaKH frm = new frm_SuaKH();
                    frm.LoadData(khblldal.getMaKH(cccd));
                    frm.ShowDialog();
                }
            }
        }

        private void tsBtn_ResetVT_Click(object sender, EventArgs e)
        {
            vt_blldal.getVT_DatPhong(dgv_VatTu);
            txt_SoLuongVT.Text = "";
            txt_TimKiemVT.Text = "";
        }

        private void tsBtn_ResetDV_Click(object sender, EventArgs e)
        {
            dgv_DichVu.DataSource = dv_blldal.getDVs();
            txt_TimKiemDV.Text = "";
            txt_SoLuongDV.Text = "";

        }

        private void tsBtn_ResetKH_Click(object sender, EventArgs e)
        {
            khblldal.getKH_DatPhong(dgv_KhachHang);
            txt_TimKiemCCCD.Text = "";
        }

        private void dgv_VatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_VatTu.Rows[e.RowIndex];
                txt_SoLuongVT.Text = 1.ToString();
            }
        }

        private void dgv_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_DichVu.Rows[e.RowIndex];
                txt_SoLuongDV.Text = 1.ToString();
            }
            
        }

        private void tsBtn_DatVT_Click(object sender, EventArgs e)
        {
            int index = dgv_VatTu.CurrentRow.Index;
            if (index >= 0)
            {
                int sl = int.Parse(txt_SoLuongVT.Text.Trim());
                string mavt = dgv_VatTu.Rows[index].Cells["MaVT"].ToString();
            }
            else
            {
                this.Message("Chưa chọn vật tư", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_DatDV_Click(object sender, EventArgs e)
        {
            int index = dgv_VatTu.CurrentRow.Index;
            if (index >= 0)
            {
                int sl = int.Parse(txt_SoLuongDV.Text.Trim());
                string madv = dgv_DichVu.Rows[index].Cells["MaDV"].ToString();
            }
            else
            {
                this.Message("Chưa chọn dịch vụ", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_SuaVT_Click(object sender, EventArgs e)
        {
            int index = dgv_DatVT.CurrentRow.Index;
            if (index >= 0)
            {
                int sl = int.Parse(txt_SoLuongVT.Text.Trim());
                string mavt = dgv_DichVu.Rows[index].Cells["MaVT_1"].ToString();
            }
            else
            {
                this.Message("Chưa chọn vật tư đã đặt", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_SuaDV_Click(object sender, EventArgs e)
        {
            int index = dgv_DatDV.CurrentRow.Index;
            if (index >= 0)
            {
                int sl = int.Parse(txt_SoLuongDV.Text.Trim());
                string madv = dgv_DichVu.Rows[index].Cells["MaDV_1"].ToString();
            }
            else
            {
                this.Message("Chưa chọn dịch vụ đã đặt", MyMessageBox.enmType.Error);
            }
        }

        private void dgv_DatDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_DatVT.Rows[e.RowIndex];
                txt_SoLuongDV.Text = row.Cells["MaDV_1"].Value.ToString();
            }
        }

        private void dgv_DatVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_DatDV.Rows[e.RowIndex];
                txt_SoLuongVT.Text = row.Cells["MaVT_1"].Value.ToString();
            }
        }

        private void dgv_DonDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_DonDat.Rows[e.RowIndex];
                string mahd = row.Cells["MaHD"].Value.ToString();
                lbl_MaHD.Text = mahd;
                txt_SoLuongNguoi.Text = hdblldal.getHD(mahd).SoLuongNguoi.ToString();
                txt_SoNgayLuuTru.Text = hdblldal.getHD(mahd).SoNgayLuuTru.ToString();
                dt_NgayDat.Value = hdblldal.getHD(mahd).TGDatPhong.Value;
                lbl_TongTien.Text = hdblldal.getHD(mahd).TongTien.ToString();
            }
        }
        public bool isThongTinDP(string songayluutru,string soluongng)
        {
            if (soluongng.Equals(""))
            {
                ep.SetError(txt_SoLuongNguoi, "Số lượng người không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (int.Parse(soluongng)<1)
            {
                ep.SetError(txt_SoLuongNguoi, "Số lượng người > 0");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (int.Parse(soluongng) > 3)
            {
                ep.SetError(txt_SoLuongNguoi, "Số lượng người < 4");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (songayluutru.Equals(""))
            {
                ep.SetError(txt_SoNgayLuuTru, "Số ngày lưu trú không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (int.Parse(songayluutru) < 1)
            {
                ep.SetError(txt_SoNgayLuuTru, "Số ngày lưu trú > 0");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (int.Parse(songayluutru) >= 30)
            {
                ep.SetError(txt_SoNgayLuuTru, "Số ngày lưu trú nhỏ hơn 30 ngày");
                return false;
            }
            else
            {
                ep.Clear();
            }
            return true;
        }
        private void tsBtn_DatPH_Click(object sender, EventArgs e)
        {
           
            if (dgv_KhachHang.RowCount > 0)
            {
                string mahd = hdblldal.CreateMaHD();
                int index = dgv_KhachHang.CurrentRow.Index;
                string songayluutru = txt_SoNgayLuuTru.Text.Trim();
                string soluongng = txt_SoLuongNguoi.Text.Trim();
                DateTime ngaydat = dt_NgayDat.Value;
                if (index >= 0)
                {
                    string cccd = dgv_KhachHang.Rows[index].Cells["CCCDKH_1"].Value.ToString();
                    int makh = khblldal.getMaKH(cccd);
                    if (isThongTinDP(songayluutru, soluongng))
                    {
                        int maph = phblldal.getMaPh(lbl_Phong.Text);
                        int tongtien = hdblldal.CalTongTien(int.Parse(lbl_GiaPH.Text), int.Parse(songayluutru));
                        hdblldal.DatPhong(mahd, makh, maph, tssLbl_TenTK.Text, ngaydat, int.Parse(songayluutru), int.Parse(soluongng), tongtien);
                        hdblldal.getHD_DatPhong(dgv_DonDat, lbl_Phong.Text);
                        tssLbl_TongCong_HD.Text = dgv_DonDat.RowCount.ToString();
                        this.Message("Success", MyMessageBox.enmType.Success);
                    }

                }
                else
                {
                    this.Message("Chưa chọn khách hàng cần đặt", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa có khách hàng", MyMessageBox.enmType.Error);
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_KhachHang.Rows[e.RowIndex];
                string cccd = row.Cells["CCCDKH_1"].Value.ToString();
            }
        }
    }
}