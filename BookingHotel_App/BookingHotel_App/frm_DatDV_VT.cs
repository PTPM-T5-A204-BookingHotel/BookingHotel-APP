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
    public partial class frm_DatDV_VT : DevExpress.XtraEditors.XtraForm
    {
        public frm_DatDV_VT()
        {
            InitializeComponent();
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
        
        public bool isThongTinDatVT(string sl, string mavt)
        {
            if (sl.Equals(""))
            {
                ep.SetError(txt_SoLuongVT, "Số lượng vật tư không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (int.Parse(sl) < 1)
            {
                ep.SetError(txt_SoLuongVT, "Số lượng vật tư không bằng 0");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (int.Parse(sl) > vt_blldal.getVT(mavt).SoLuong)
            {
                this.Message("Số lượng đặt vượt quá kho", MyMessageBox.enmType.Error);
                return false;
            }
            return true;
        }
        public bool isThongTinDatDV(string sl)
        {
            if (sl.Equals(""))
            {
                ep.SetError(txt_SoLuongDV, "Số lượng dịch vụ không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (int.Parse(sl) < 1)
            {
                ep.SetError(txt_SoLuongDV, "Số lượng dịch vụ không bằng 0");
                return false;
            }
            else
            {
                ep.Clear();
            }
            return true;
        }
        public void LoadDataDatDV()
        {
            hddvblldal.getHDDVs(dgv_DatDV, tssLbl_HoaDon.Text);
            if (dgv_DatDV.RowCount > 0)
            {
                tssLbl_TongTT_DV.Text = hddvblldal.TongThanhTien(tssLbl_HoaDon.Text).ToString();
            }
            else
            {
                tssLbl_TongTT_DV.Text = 0.ToString();
            }
            int tongtien = hdblldal.CalTongTien(int.Parse(tslbl_GiaPhong.Text), int.Parse(hdblldal.getHD(tssLbl_HoaDon.Text).SoNgayLuuTru.ToString()));
            tslbl_TongTien.Text = (int.Parse(tssLbl_TongTT_DV.Text) + int.Parse(tssLbl_TongTT_VT.Text) + tongtien).ToString();
            hdblldal.update(tssLbl_HoaDon.Text, int.Parse(tslbl_TongTien.Text));

        }
        public void LoadDataDatVT()
        {
            hdvtblldal.getHDVTs(dgv_DatVT, tssLbl_HoaDon.Text);
            if (dgv_DatVT.RowCount > 0)
            {
                tssLbl_TongTT_VT.Text = hdvtblldal.TongThanhTien(tssLbl_HoaDon.Text).ToString();
            }
            else
            {
                tssLbl_TongTT_VT.Text = 0.ToString();
            }

            int tongtien = hdblldal.CalTongTien(int.Parse(tslbl_GiaPhong.Text), int.Parse(hdblldal.getHD(tssLbl_HoaDon.Text).SoNgayLuuTru.ToString()));
            tslbl_TongTien.Text = (int.Parse(tssLbl_TongTT_DV.Text) + int.Parse(tssLbl_TongTT_VT.Text) + tongtien).ToString();
            hdblldal.update(tssLbl_HoaDon.Text, int.Parse(tslbl_TongTien.Text));
        }
        private void tsBtn_DatVT_Click(object sender, EventArgs e)
        {
            if (dgv_VatTu.RowCount > 0)
            {
                int index = dgv_VatTu.CurrentRow.Index;
                if (index >= 0)
                {
                    string sl = txt_SoLuongVT.Text.Trim();
                    string mavt = dgv_VatTu.Rows[index].Cells["MaVT"].Value.ToString();
                    int giavt = int.Parse(dgv_VatTu.Rows[index].Cells["DonGia_1"].Value.ToString());
                    if (isThongTinDatVT(sl, mavt))
                    {
                        if (hdvtblldal.isHDVT(tssLbl_HoaDon.Text, mavt) == 0)
                        {
                            int thanhtien = hdvtblldal.TinhThanhTien(giavt, int.Parse(sl));
                            hdvtblldal.insert(tssLbl_HoaDon.Text, mavt, int.Parse(sl), thanhtien);
                            LoadDataDatVT();
                        }
                        else
                        {
                            this.Message("Vật tư đã đặt", MyMessageBox.enmType.Error);
                        }
                    }


                }
                else
                {
                    this.Message("Chưa chọn vật tư", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_SuaVT_Click(object sender, EventArgs e)
        {
            if (dgv_DatVT.RowCount > 0 && dgv_VatTu.RowCount > 0)
            {
                int index = dgv_DatVT.CurrentRow.Index;
                if (index >= 0)
                {
                    string mavt = dgv_DatVT.Rows[index].Cells["MaVT_1"].Value.ToString();
                    string sl = txt_SoLuongVT.Text.Trim();
                    int giavt = int.Parse(dgv_DatVT.Rows[index].Cells["DonGia"].Value.ToString());
                    if (isThongTinDatVT(sl, mavt))
                    {
                        int thanhtien = hdvtblldal.TinhThanhTien(giavt, int.Parse(sl));
                        hdvtblldal.update(tssLbl_HoaDon.Text, mavt, int.Parse(sl), thanhtien);
                        LoadDataDatVT();
                    }

                }
                else
                {
                    this.Message("Chưa chọn vật tư đã đặt", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_XoaVT_Click(object sender, EventArgs e)
        {
            if (dgv_DatVT.RowCount > 0 && dgv_VatTu.RowCount > 0)
            {
                int index = dgv_DatVT.CurrentRow.Index;
                if (index >= 0)
                {
                    string mavt = dgv_DatVT.Rows[index].Cells["MaVT_1"].Value.ToString();
                    hdvtblldal.delete(tssLbl_HoaDon.Text, mavt);
                    LoadDataDatVT();


                }
                else
                {
                    this.Message("Chưa chọn vật tư đã đặt", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
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

        private void tsBtn_ResetVT_Click(object sender, EventArgs e)
        {
            vt_blldal.getVT_DatPhong(dgv_VatTu);
            txt_SoLuongVT.Text = "";
            txt_TimKiemVT.Text = "";
        }

        private void tsBtn_DatDV_Click(object sender, EventArgs e)
        {
            if (dgv_DichVu.RowCount > 0)
            {
                int index = dgv_DichVu.CurrentRow.Index;
                if (index >= 0)
                {

                    string sl = txt_SoLuongDV.Text.Trim();
                    string madv = dgv_DichVu.Rows[index].Cells["MaDV"].Value.ToString();

                    if (isThongTinDatDV(sl))
                    {
                        if (hddvblldal.isHDDV(tssLbl_HoaDon.Text, madv) == 0)
                        {
                            int giadv = int.Parse(dgv_DichVu.Rows[index].Cells["GiaDV_1"].Value.ToString());
                            int thanhtien = hddvblldal.TinhThanhTien(giadv, int.Parse(sl));
                            hddvblldal.insert(tssLbl_HoaDon.Text, madv, int.Parse(sl), thanhtien);
                            LoadDataDatDV();
                        }
                        else
                        {
                            this.Message("Dịch vụ đã đặt", MyMessageBox.enmType.Error);
                        }
                    }

                }
                else
                {
                    this.Message("Chưa chọn dịch vụ", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_SuaDV_Click(object sender, EventArgs e)
        {
            if (dgv_DatDV.RowCount > 0 && dgv_DichVu.RowCount > 0)
            {
                int index = dgv_DatDV.CurrentRow.Index;
                if (index >= 0)
                {
                    string sl = txt_SoLuongDV.Text.Trim();
                    string madv = dgv_DatDV.Rows[index].Cells["MaDV_1"].Value.ToString();
                    if (isThongTinDatDV(sl))
                    {
                        int giadv = int.Parse(dgv_DatDV.Rows[index].Cells["GiaDV"].Value.ToString());
                        int thanhtien = hddvblldal.TinhThanhTien(giadv, int.Parse(sl));
                        hddvblldal.update(tssLbl_HoaDon.Text, madv, int.Parse(sl), thanhtien);
                        LoadDataDatDV();
                    }
                }
                else
                {
                    this.Message("Chưa chọn dịch vụ đã đặt", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_XoaDV_Click(object sender, EventArgs e)
        {
            if (dgv_DatDV.RowCount > 0 && dgv_DichVu.RowCount > 0)
            {
                int index = dgv_DatDV.CurrentRow.Index;
                string mahd = tssLbl_HoaDon.Text;
                if (index >= 0)
                {
                    string madv = dgv_DatDV.Rows[index].Cells["MaDV_1"].Value.ToString();
                    hddvblldal.delete(mahd, madv);
                    LoadDataDatDV();
                }
                else
                {
                    this.Message("Chưa chọn dịch vụ đã đặt", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
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

        private void tsBtn_ResetDV_Click(object sender, EventArgs e)
        {
            dgv_DichVu.DataSource = dv_blldal.getDVs();
            txt_TimKiemDV.Text = "";
            txt_SoLuongDV.Text = "";
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

        private void dgv_DatDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_DatDV.Rows[e.RowIndex];
                txt_SoLuongDV.Text = row.Cells["SoLuongDV"].Value.ToString();
            }
        }

        private void dgv_DatVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_DatVT.Rows[e.RowIndex];
                txt_SoLuongVT.Text = row.Cells["SoLuongVT"].Value.ToString();
            }
        }
        public void LoadData(string mahd,string giaph,string tgnp)
        {
            tssLbl_HoaDon.Text = mahd;
            tslbl_GiaPhong.Text = giaph;
            tslbl_TongTien.Text = hdblldal.getHD(mahd).TongTien.ToString();
            tslbl_TGNhanPH.Text = tgnp;
            dgv_DichVu.DataSource = dv_blldal.getDVs();
            vt_blldal.getVT_DatPhong(dgv_VatTu);
            hddvblldal.getHDDVs(dgv_DatDV, tssLbl_HoaDon.Text);
            if (dgv_DatDV.RowCount > 0)
            {
                tssLbl_TongTT_DV.Text = hddvblldal.TongThanhTien(tssLbl_HoaDon.Text).ToString();
            }
            else
            {
                tssLbl_TongTT_DV.Text = 0.ToString();
            }
            hdvtblldal.getHDVTs(dgv_DatVT, tssLbl_HoaDon.Text);
            if (dgv_DatVT.RowCount > 0)
            {
                tssLbl_TongTT_VT.Text = hdvtblldal.TongThanhTien(tssLbl_HoaDon.Text).ToString();
            }
            else
            {
                tssLbl_TongTT_VT.Text = 0.ToString();
            }


            if (tslbl_TGNhanPH.Text == "")
            {
                tsBtn_DatVT.Enabled = false;
                tsBtn_SuaVT.Enabled = false;
                tsBtn_XoaVT.Enabled = false;
            }
            else
            {
                tsBtn_DatVT.Enabled = true;
                tsBtn_SuaVT.Enabled = true;
                tsBtn_XoaVT.Enabled = true;
            }

        }
        private void frm_DatDV_VT_Load(object sender, EventArgs e)
        {
            
        }
    }
}