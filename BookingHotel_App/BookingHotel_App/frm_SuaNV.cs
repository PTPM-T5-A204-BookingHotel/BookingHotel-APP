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
    public partial class frm_SuaNV : DevExpress.XtraEditors.XtraForm
    {
        public frm_SuaNV()
        {
            InitializeComponent();
        }

        private void btn_EditChucVu_Click(object sender, EventArgs e)
        {
            frm_ChucVu frm = new frm_ChucVu();
            frm.ShowDialog();
        }
    }
}