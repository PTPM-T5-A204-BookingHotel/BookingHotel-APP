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
        public void LoadData(int tang,string phong,string loaiphong,string tinhtrang)
        {
            lbl_Tang.Text = tang.ToString();
            lbl_Phong.Text = phong;
            lbl_LoaiPH.Text = loaiphong;
            lbl_TinhTrangPH.Text = tinhtrang;
        }
        private void UC_Phong_Load(object sender, EventArgs e)
        {

        }
    }
}
