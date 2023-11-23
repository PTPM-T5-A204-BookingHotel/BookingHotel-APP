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
    public partial class UC_Phong : UserControl
    {
        public UC_Phong()
        {
            InitializeComponent();
        }
        TaiKhoan_BLL_DAL tkblldal = new TaiKhoan_BLL_DAL();
        string taikhoan;
        public void setTenTK(string tentk)
        {
            taikhoan = tentk;
        }
        public void LoadData(int tang,string phong,string loaiphong,string tinhtrang)
        {
            lbl_Tang.Text = tang.ToString();
            lbl_Phong.Text = phong;
            lbl_LoaiPH.Text = loaiphong;
            lbl_TinhTrangPH.Text = tinhtrang;
        }
        private void UC_Phong_Load(object sender, EventArgs e)
        {
            string quyen = tkblldal.getTK(taikhoan).MaQuyen;
            if (quyen == "Admin")
            {
                btn_Mo.Enabled = false;


            }
        }

        private void btn_Mo_Click(object sender, EventArgs e)
        {
            frm_DatPhong frm = new frm_DatPhong();
            frm.LoadData(lbl_Phong.Text, taikhoan);
            frm.ShowDialog();
        }
    }
}
