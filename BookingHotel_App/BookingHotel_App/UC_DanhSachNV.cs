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
    public partial class UC_DanhSachNV : UserControl
    {
        public UC_DanhSachNV()
        {
            InitializeComponent();
        }
        NhanVien_BLL_DAL nvblldal = new NhanVien_BLL_DAL();
        Basis ba = new Basis();
        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemNV frm = new frm_ThemNV();
            frm.ShowDialog();
        }
        public void LoadCbo_TimKiem()
        {
            string[] strings = { "CCCD", "Họ tên", "Giới tính" };
            foreach(string s in strings)
            {
                cbo_LoaiTK.Items.Add(s);
            }
            if(cbo_LoaiTK.Items.Count > 0)
            {
                cbo_LoaiTK.SelectedIndex = 0;
            }
        }
        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                int index = dgv_NhanVien.CurrentRow.Index;
                if (index < 0)
                {
                    this.Message("Chưa chọn nhân viên", MyMessageBox.enmType.Error);
                }
                else
                {
                    string cccd = dgv_NhanVien.Rows[index].Cells[0].Value.ToString();
                    frm_SuaNV frm = new frm_SuaNV();
                    frm.LoadData(nvblldal.getMaNV(cccd));
                    frm.ShowDialog();
                }
            }
            
            
        }
        public void LoadData()
        {
            nvblldal.getNVs(dgv_NhanVien);
            tssLbl_TongCong.Text = dgv_NhanVien.RowCount.ToString();
            rdo_Nam.Checked = true;
        }
        private void UC_DanhSachNV_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCbo_TimKiem();
        }
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                string search = txt_TimKiem.Text.Trim();
                if (cbo_LoaiTK.SelectedIndex == 2)
                {
                    if (rdo_Nam.Checked)
                        search = "Nam";
                    if (rdo_Nu.Checked)
                        search = "Nữ";
                }
                if (search.Equals(""))
                {
                    this.Message("Chưa nhập tìm kiếm", MyMessageBox.enmType.Error); return;
                }
                else
                {
                    nvblldal.search(cbo_LoaiTK.SelectedIndex, search, dgv_NhanVien);
                }
            }
            
        }

        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            if (cbo_LoaiTK.Items.Count > 0)
            {
                cbo_LoaiTK.SelectedIndex = 0;
            }
            LoadData();
            txt_TimKiem.Text = "";

        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                nvblldal.sort(dgv_NhanVien);
            }
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_NhanVien.RowCount < 1)
                {
                    this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
                }
                else
                {
                    int index = dgv_NhanVien.CurrentRow.Index;
                    if (index < 0)
                    {
                        this.Message("Chưa chọn nhân viên", MyMessageBox.enmType.Error);
                    }
                    else
                    {
                        string cccd = dgv_NhanVien.Rows[index].Cells[0].Value.ToString();
                        int manv = nvblldal.getMaNV(cccd);
                        nvblldal.delete(manv);
                        this.Message("Success", MyMessageBox.enmType.Success);
                        LoadData();
                    }
                }
            }
            catch
            {
                this.Message("Nhân viên này đang được sử dụng", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_InExcel_Click(object sender, EventArgs e)
        {
            ba.XuatExcel(dgv_NhanVien);
        }
    }
}
