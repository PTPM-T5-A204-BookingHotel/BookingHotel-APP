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
        bool isShowPass = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            if (isShowPass == true)
            {
                txt_Password.UseSystemPasswordChar = false;
                isShowPass = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
                isShowPass = true;
            }
                
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }
    }
}