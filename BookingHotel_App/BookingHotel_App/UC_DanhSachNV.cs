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
    public partial class UC_DanhSachNV : UserControl
    {
        public UC_DanhSachNV()
        {
            InitializeComponent();
        }

        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemNV frm = new frm_ThemNV();
            frm.ShowDialog();
        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            frm_SuaNV frm = new frm_SuaNV();
            frm.ShowDialog();
        }
    }
}
