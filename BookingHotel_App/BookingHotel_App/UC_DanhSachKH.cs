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
    public partial class UC_DanhSachKH : UserControl
    {
        public UC_DanhSachKH()
        {
            InitializeComponent();
        }

        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemKH frm = new frm_ThemKH();
            frm.ShowDialog();
        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            frm_SuaNV frm = new frm_SuaNV();
            frm.ShowDialog();
        }
    }
}
