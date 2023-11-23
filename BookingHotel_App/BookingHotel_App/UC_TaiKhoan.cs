using BLL_DAL;
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
    public partial class UC_TaiKhoan : UserControl
    {
        public UC_TaiKhoan()
        {
            InitializeComponent();
        }
        Basis ba = new Basis();
        ErrorProvider ep = new ErrorProvider();
        TaiKhoan_BLL_DAL tkblldal = new TaiKhoan_BLL_DAL();
        public void Loaddata(string tentk)
        {
            lbl_TenTK.Text = tentk;
            txt_Password.Text = tkblldal.getTK(tentk).MatKhau;
            pic_Image.ImageLocation = tkblldal.getTK(tentk).AnhTK;
        }
        private void btn_UpImage_Click(object sender, EventArgs e)
        {
            ba.UpLoadImage(pic_Image);
        }
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }
        public bool isThongTinTK( string mk, string anh)
        {
            if (mk.Equals(""))
            {
                ep.SetError(txt_Password, "Mật khẩu không để trống");
                return false;
            }
            else
                ep.Clear();
            if (anh == null)
            {
                this.Message("Chưa có ảnh", MyMessageBox.enmType.Error);
                return false;
            }
            return true;
        }
        private void btn_Change_Click(object sender, EventArgs e)
        {
            string mk = txt_Password.Text.Trim();
            string anh = pic_Image.ImageLocation;
            if (isThongTinTK(mk, anh))
            {
                tkblldal.update(lbl_TenTK.Text, mk, anh);
                this.Message("Success", MyMessageBox.enmType.Success);
            }
        }
    }
}
