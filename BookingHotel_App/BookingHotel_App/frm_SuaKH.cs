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
    public partial class frm_SuaKH : DevExpress.XtraEditors.XtraForm
    {
        public frm_SuaKH()
        {
            InitializeComponent();
        }
        KhachHang_BLL_DAL khblldal = new KhachHang_BLL_DAL();
        Basis ba = new Basis();
        ErrorProvider ep = new ErrorProvider();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        public void LoadData(int manv)
        {
            KhachHang kh = khblldal.getKH(manv);
            pic_Image.ImageLocation = kh.AnhKH;
            txt_CCCD.Text = kh.CCCDKH;
            txt_Hoten.Text = kh.HoTenKH;
            txt_SDT.Text = kh.SDTKH;
            if (kh.EmailKH == null)
                txt_Email.Text = "";
            else
                txt_Email.Text = kh.EmailKH;
            txt_DiaChi.Text = kh.DiaChiKH;
            if (kh.GioiTinhKH == "Nam")
            {
                rdo_Nam.Checked = true;
            }
            if (kh.GioiTinhKH == "Nữ")
            {
                rdo_Nu.Checked = true;
            }
            dt_NgaySinh.Value = kh.NgaySinhKH;
        }
        private void btn_ChupAnh_Click(object sender, EventArgs e)
        {
            frm_SavePicture frm = new frm_SavePicture();
            frm.ShowDialog();
        }
        public bool isThongTinkh(string cccd, string hoten, string sodienthoai, DateTime ngaysinh, string diachi, string anhnv, string email)
        {
            if (cccd.Equals(""))
            {
                ep.SetError(txt_CCCD, "CCCD không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (!ba.isCCCD(cccd))
            {
                ep.SetError(txt_CCCD, "CCCD không hợp lệ");
                return false;
            }
            else
            {
                ep.Clear();
            }

            if (hoten.Equals(""))
            {
                ep.SetError(txt_Hoten, "Họ tên không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (sodienthoai.Equals(""))
            {
                ep.SetError(txt_SDT, "Số điện thoại không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (!ba.isSDT(sodienthoai))
            {
                ep.SetError(txt_SDT, "Số điện thoại không hợp lệ");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (diachi.Equals(""))
            {
                ep.SetError(txt_DiaChi, "Địa chỉ không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (anhnv == null)
            {
                this.Message("Chưa có ảnh", MyMessageBox.enmType.Error);
                return false;
            }
            if (!ba.isNgaySinh(ngaysinh))
            {
                ep.SetError(dt_NgaySinh, "Khách hàng >= 18 tuổi");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (!email.Equals(""))
            {
                if (!ba.isEmail(email))
                {
                    ep.SetError(txt_Email, "Email không hợp lệ");
                    return false;
                }
                else
                {
                    ep.Clear();
                }
            }
            return true;
        }

        private void btn_UpImage_Click(object sender, EventArgs e)
        {
            ba.UpLoadImage(pic_Image);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string cccd = txt_CCCD.Text.Trim();
            int makh = khblldal.getMaKH(cccd);
            string hoten = txt_Hoten.Text.Trim();
            string gt = "";
            if (rdo_Nam.Checked)
            {
                gt = "Nam";
            }
            if (rdo_Nu.Checked)
            {
                gt = "Nữ";
            }
            string email = txt_Email.Text.Trim();
            string diachi = txt_DiaChi.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            DateTime ns = dt_NgaySinh.Value;
            string anh = pic_Image.ImageLocation;
            try
            {
                if (isThongTinkh(cccd, hoten, sdt, ns, diachi, anh, email))
                {
                    khblldal.update(makh, cccd, hoten, gt, sdt, ns, diachi, anh, email);
                    this.Message("Success", MyMessageBox.enmType.Success);
                }
            }
            catch
            {
                this.Message("Error Data", MyMessageBox.enmType.DataFail);
            }
        }
    }
}