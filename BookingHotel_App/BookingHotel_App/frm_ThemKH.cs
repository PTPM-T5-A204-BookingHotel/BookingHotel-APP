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
    public partial class frm_ThemKH : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThemKH()
        {
            InitializeComponent();
        }
        Basis ba = new Basis();
        private void btn_ChupAnh_Click(object sender, EventArgs e)
        {
            frm_ChupAnh frm = new frm_ChupAnh();
            frm.ShowDialog();
        }

        private void frm_ThemKH_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_UpImage_Click(object sender, EventArgs e)
        {
            ba.UpLoadImage(pic_Image);
        }
    }
}