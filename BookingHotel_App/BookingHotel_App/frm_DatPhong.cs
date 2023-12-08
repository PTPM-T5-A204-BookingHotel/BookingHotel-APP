using BLL_DAL;
using DevExpress.XtraEditors;
using Emgu.CV.Flann;
using Emgu.CV.Util;
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
            if (!lbl_MaHD.Text.Equals(""))
            {


                if (hdblldal.getHD(lbl_MaHD.Text).TGNhanPhong != null)
                {

                    tsBtn_SuaHD.Enabled = false;
                    tsBtn_NhanPH.Enabled = false;
                    tsBtn_TraPH.Enabled = true;
                }
                else
                {

                    tsBtn_SuaHD.Enabled = true;
                    if (lbl_TinhTrangPH.Text == "Đang thuê")
                    {
                        tsBtn_NhanPH.Enabled = false;
                    }
                    else
                    {
                        tsBtn_NhanPH.Enabled = true;
                    }
                    tsBtn_TraPH.Enabled = false;
                }
            }
            

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
        public void LoadData(string tenph, string tentk)
        {

            hdblldal.getHD_DatPhong(dgv_DonDat, tenph);
            tssLbl_TongCong_HD.Text = dgv_DonDat.RowCount.ToString();
            khblldal.getKH_DatPhong(dgv_KhachHang);
            lbl_Phong.Text = tenph;
            int maph = phblldal.getMaPh(tenph);
            lbl_TinhTrangPH.Text = phblldal.getPH(maph).TinhTrangPH;
            lbl_Tang.Text = phblldal.getPH(maph).Tang.ToString();
            int malp = phblldal.getPH(maph).MaLP;
            lbl_GiaPH.Text = lphblldal.getGialp(malp);
            lbl_LoaiPH.Text = lphblldal.getTenlp(malp);
            tssLbl_TenTK.Text = tentk;

            lbl_TongTien.Text = 0.ToString();
            tssLbl_TongTT_DV.Text = 0.ToString();
            tssLbl_TongTT_VT.Text = 0.ToString();
            ba.clearTextBoxs(this.Controls);
            lbl_MaHD.Text = "";
            dt_NgayDat.Value = DateTime.Now.Date;

        }
        private void frm_DatPhong_Load(object sender, EventArgs e)
        {
            
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
                    string cccd = dgv_KhachHang.Rows[index].Cells["CCCDKH_1"].Value.ToString();
                    frm_SuaKH frm = new frm_SuaKH();
                    frm.LoadData(khblldal.getMaKH(cccd));
                    frm.ShowDialog();
                }
            }
        }

        

        private void tsBtn_ResetKH_Click(object sender, EventArgs e)
        {
            khblldal.getKH_DatPhong(dgv_KhachHang);
            txt_TimKiemCCCD.Text = "";
        }

        
        
        public void LoadDataDatDV()
        {
            hddvblldal.getHDDVs(dgv_DatDV, lbl_MaHD.Text);
            if (dgv_DatDV.RowCount > 0)
            {
                tssLbl_TongTT_DV.Text = hddvblldal.TongThanhTien(lbl_MaHD.Text).ToString();
            }
            else
            {
                tssLbl_TongTT_DV.Text = 0.ToString();
            }
            int tongtien = hdblldal.CalTongTien(int.Parse(lbl_GiaPH.Text), int.Parse(hdblldal.getHD(lbl_MaHD.Text).SoNgayLuuTru.ToString()));
            lbl_TongTien.Text = (int.Parse(tssLbl_TongTT_DV.Text) + int.Parse(tssLbl_TongTT_VT.Text) + tongtien).ToString();
            hdblldal.update(lbl_MaHD.Text, int.Parse(lbl_TongTien.Text));

        }
        public void LoadDataDatVT()
        {
            hdvtblldal.getHDVTs(dgv_DatVT, lbl_MaHD.Text);
            if (dgv_DatVT.RowCount > 0)
            {
                tssLbl_TongTT_VT.Text = hdvtblldal.TongThanhTien(lbl_MaHD.Text).ToString();
            }
            else
            {
                tssLbl_TongTT_VT.Text = 0.ToString();
            }

            int tongtien = hdblldal.CalTongTien(int.Parse(lbl_GiaPH.Text), int.Parse(hdblldal.getHD(lbl_MaHD.Text).SoNgayLuuTru.ToString()));
            lbl_TongTien.Text = (int.Parse(tssLbl_TongTT_DV.Text) + int.Parse(tssLbl_TongTT_VT.Text) + tongtien).ToString();
            hdblldal.update(lbl_MaHD.Text, int.Parse(lbl_TongTien.Text));
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
                hddvblldal.getHDDVs(dgv_DatDV, lbl_MaHD.Text);
                if (dgv_DatDV.RowCount > 0)
                {
                    tssLbl_TongTT_DV.Text = hddvblldal.TongThanhTien(lbl_MaHD.Text).ToString();
                }
                else
                {
                    tssLbl_TongTT_DV.Text = 0.ToString();
                }
                hdvtblldal.getHDVTs(dgv_DatVT, lbl_MaHD.Text);
                if (dgv_DatVT.RowCount > 0)
                {
                    tssLbl_TongTT_VT.Text = hdvtblldal.TongThanhTien(lbl_MaHD.Text).ToString();
                }
                else
                {
                    tssLbl_TongTT_VT.Text = 0.ToString();
                }
                lbl_TongTien.Text = row.Cells["TongTien"].Value.ToString();
            }
        }
        public bool isThongTinDP(string songayluutru, string soluongng)
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
            if (int.Parse(soluongng) < 1)
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
                    if (hdblldal.KTTGDatPhong(ngaydat, phblldal.getMaPh(lbl_Phong.Text)))
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
                        this.Message("Ngày dự kiến nhận phòng đã có khách đặt", MyMessageBox.enmType.Error);
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

        

        

        private void tsBtn_SuaHD_Click(object sender, EventArgs e)
        {
            if (lbl_MaHD.Text != "")
            {
                string songayluutru = txt_SoNgayLuuTru.Text.Trim();
                string soluongng = txt_SoLuongNguoi.Text.Trim();
                DateTime ngaydat = dt_NgayDat.Value;
                if (hdblldal.KTTGDatPhong(ngaydat, phblldal.getMaPh(lbl_Phong.Text)))
                {
                    if (isThongTinDP(songayluutru, soluongng))
                    {
                        int tt = hdblldal.CalTongTien(int.Parse(lbl_GiaPH.Text), int.Parse(songayluutru));
                        lbl_TongTien.Text = (int.Parse(tssLbl_TongTT_DV.Text) + int.Parse(tssLbl_TongTT_VT.Text) + tt).ToString();
                        hdblldal.update(lbl_MaHD.Text, ngaydat, int.Parse(songayluutru), int.Parse(soluongng), int.Parse(lbl_TongTien.Text));
                        hdblldal.getHD_DatPhong(dgv_DonDat, lbl_Phong.Text);
                        tssLbl_TongCong_HD.Text = dgv_DonDat.RowCount.ToString();
                        this.Message("Success", MyMessageBox.enmType.Success);
                    }
                }
                else
                {
                    this.Message("Ngày dự kiến nhận phòng đã có khách đặt", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa chọn hóa đơn cần sửa", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_NhanPH_Click(object sender, EventArgs e)
        {
            if (lbl_MaHD.Text != "")
            {
                hdblldal.NhanPhong(lbl_MaHD.Text, DateTime.Now);
                int maph = phblldal.getMaPh(lbl_Phong.Text);
                string tt = "Đang thuê";
                phblldal.update(maph, tt);
                lbl_TinhTrangPH.Text = phblldal.getPH(maph).TinhTrangPH.ToString();
                tsBtn_NhanPH.Enabled = false;
                tsBtn_SuaHD.Enabled = false;
                tsBtn_TraPH.Enabled = true;
                hdblldal.getHD_DatPhong(dgv_DonDat, lbl_Phong.Text);
                tssLbl_TongCong_HD.Text = dgv_DonDat.RowCount.ToString();
            }
            else
            {
                this.Message("Chưa chọn hóa đơn cần nhận phòng", MyMessageBox.enmType.Error);
            }
        }
        public void Reset()
        {
            lbl_TongTien.Text = 0.ToString();
            tssLbl_TongTT_DV.Text = 0.ToString();
            tssLbl_TongTT_VT.Text = 0.ToString();
            ba.clearTextBoxs(this.Controls);
            lbl_MaHD.Text = "";
            dt_NgayDat.Value = DateTime.Now.Date;
            hdblldal.getHD_DatPhong(dgv_DonDat, lbl_Phong.Text);
            tssLbl_TongCong_HD.Text = dgv_DonDat.RowCount.ToString();
            tsBtn_NhanPH.Enabled = true;
            tsBtn_SuaHD.Enabled = true;
            tsBtn_TraPH.Enabled = false;
            dgv_DatVT.DataSource = null;
            dgv_DatDV.DataSource = null;
        }
        private void tsBtn_TraPH_Click(object sender, EventArgs e)
        {
            if (lbl_MaHD.Text != "")
            {
                hdblldal.TraPhong(lbl_MaHD.Text, DateTime.Now);
                int maph = phblldal.getMaPh(lbl_Phong.Text);
                string tt = "Trống";
                phblldal.update(maph, tt);
                lbl_TinhTrangPH.Text = phblldal.getPH(maph).TinhTrangPH.ToString();
                for (int i = 0; i < hdvtblldal.getHDVTs(lbl_MaHD.Text).Count; i++)
                {
                    string mavt = hdvtblldal.getHDVTs(lbl_MaHD.Text)[i].MaVT.ToString();
                    int slcu = int.Parse(vt_blldal.getVT(mavt).SoLuong.ToString());
                    int slmoi = int.Parse(hdvtblldal.getHDVT(lbl_MaHD.Text, mavt).SoLuongVT.ToString());
                    int tinhsl = vt_blldal.TinhSL(slmoi, slcu);
                    vt_blldal.update(mavt, tinhsl);
                }

                Reset();
            }
            else
            {
                this.Message("Chưa chọn hóa đơn cần trả phòng", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_HuyHD_Click(object sender, EventArgs e)
        {
            if (dgv_DonDat.RowCount > 0)
            {
                int index = dgv_DonDat.CurrentRow.Index;
                if (index >= 0)
                {
                    string mahd = dgv_DonDat.Rows[index].Cells["MaHD"].Value.ToString();
                    hdblldal.update(mahd, "Hủy");
                    lbl_TinhTrangPH.Text = "Trống";
                    int maph = phblldal.getMaPh(lbl_Phong.Text);
                    phblldal.update(maph, lbl_TinhTrangPH.Text);
                    Reset();
                }
                else
                {
                    this.Message("Chưa chọn hóa đơn cần hủy", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void btn_DatDV_VT_Click(object sender, EventArgs e)
        {
            if (lbl_MaHD.Text != "")
            {
                frm_DatDV_VT frm = new frm_DatDV_VT();
                string value;
                if (hdblldal.getHD(lbl_MaHD.Text).TGNhanPhong == null)
                    value = "";
                else
                    value = hdblldal.getHD(lbl_MaHD.Text).TGNhanPhong.Value.ToString();
                frm.LoadData(lbl_MaHD.Text, lbl_GiaPH.Text, value);
                frm.ShowDialog();
            }
            else
            {
                this.Message("Mã hóa đơn không để trống", MyMessageBox.enmType.Error);
            }
        }

        

        private void tsBtn_ResetHD_Click(object sender, EventArgs e)
        {
            hdblldal.getHD_DatPhong(dgv_DonDat, lbl_Phong.Text);
        }
    }
}