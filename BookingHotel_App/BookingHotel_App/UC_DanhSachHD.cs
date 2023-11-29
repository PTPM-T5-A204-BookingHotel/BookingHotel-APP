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
    public partial class UC_DanhSachHD : UserControl
    {
        public UC_DanhSachHD()
        {
            InitializeComponent();
        }
        HoaDon_BLL_DAL hdblldal = new HoaDon_BLL_DAL();
        Basis ba = new Basis();
        Phong_BLL_DAL phblldal = new Phong_BLL_DAL();
        public void LoadCbo_TimKiem()
        {
            string[] s = { "Phòng", "CCCD Khách" };
            foreach(string i in s)
            {
                cbo_LoaiTK.Items.Add(i);

            }
            cbo_LoaiTK.SelectedIndex = 0;
        }
        public void LoadCbo_Phong()
        {
            cbo_Phong.ValueMember = "MaPH";
            cbo_Phong.DisplayMember = "TenPH";
            cbo_Phong.DataSource = phblldal.GetPHs();
            if (cbo_Phong.Items.Count > 0)
            {
                cbo_Phong.SelectedIndex = 0;
            }
        }
        public void LoadData()
        {
            hdblldal.getHDs(dgv_HoaDon);
            tssLbl_TongCong.Text = dgv_HoaDon.RowCount.ToString();

        }
        private void UC_DanhSachHD_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCbo_Phong();
        }

        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            cbo_LoaiTK.SelectedIndex = 0;
            ba.clearTextBoxs(this.Controls);
            LoadCbo_Phong();
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {

        }

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
