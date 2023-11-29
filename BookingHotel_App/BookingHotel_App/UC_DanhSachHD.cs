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
    public partial class UC_DanhSachHD : UserControl
    {
        public UC_DanhSachHD()
        {
            InitializeComponent();
        }
        HoaDon_BLL_DAL hdblldal = new HoaDon_BLL_DAL();
        Basis ba = new Basis();
        Phong_BLL_DAL phblldal = new Phong_BLL_DAL();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
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
            LoadCbo_TimKiem();
        }

        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            cbo_LoaiTK.SelectedIndex = 0;
            ba.clearTextBoxs(this.Controls);
            LoadCbo_Phong();
            LoadData();
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            hdblldal.sort(dgv_HoaDon);
        }

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            if(cbo_LoaiTK.SelectedIndex==1)
            {
                string search = txt_TimKiem.Text.Trim();
                if (!search.Equals("")) 
                { 
                    search = txt_TimKiem.Text.Trim();
                    hdblldal.Search(dgv_HoaDon, 1, search);
                }
                else
                {
                    this.Message("Tìm kiếm không để trống", MyMessageBox.enmType.Error);
                }
            }
            else
            {
                if (cbo_LoaiTK.SelectedIndex == 0)
                {
                    hdblldal.Search(dgv_HoaDon, 0, cbo_Phong.SelectedValue.ToString());
                }
            }
            
        }

        private void tsBtn_InHD_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDon.RowCount > 0) {
                int index = dgv_HoaDon.CurrentRow.Index;
                if(index>=0)
                {
                    if (dgv_HoaDon.Rows[index].Cells["TinhTrangHD"].Value.ToString().Equals("Đã thanh toán")){
                        frmInHD frm = new frmInHD();
                        frm.XuatHD(dgv_HoaDon.Rows[index].Cells["MaHD"].Value.ToString());
                        frm.ShowDialog();
                    }
                    else
                    {
                        this.Message("Hóa đơn chưa thanh toán", MyMessageBox.enmType.Error);
                    }
                }
                else
                {
                    this.Message("Chưa chọn hóa đơn", MyMessageBox.enmType.Error);
                }

            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }
    }
}
