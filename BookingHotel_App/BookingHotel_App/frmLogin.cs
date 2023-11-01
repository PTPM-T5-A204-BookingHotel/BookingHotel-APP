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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        TaiKhoan_BLL_DAL tkblldal = new TaiKhoan_BLL_DAL();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string tentk = txt_Account.Text.Trim();
            string mk = txt_Password.Text.Trim();
            if (tkblldal.isTK(tentk, mk) == 1)
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.LoadData(tentk);
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                this.Message("Account is invalid", MyMessageBox.enmType.Error);
            }
            
        }
    }
}