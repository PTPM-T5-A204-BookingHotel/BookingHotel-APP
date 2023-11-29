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
    public partial class UC_DanhSachKH : UserControl
    {
        public UC_DanhSachKH()
        {
            InitializeComponent();
        }
        KhachHang_BLL_DAL khblldal = new KhachHang_BLL_DAL();
        Basis ba = new Basis();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemKH frm = new frm_ThemKH();
            frm.ShowDialog();
        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                int index = dgv_KhachHang.CurrentRow.Index;
                if (index < 0)
                {
                    this.Message("Chưa chọn khách hàng", MyMessageBox.enmType.Error);
                }
                else
                {
                    string cccd = dgv_KhachHang.Rows[index].Cells["CCCDKH"].Value.ToString();
                    frm_SuaKH frm = new frm_SuaKH();
                    frm.LoadData(khblldal.getMaKH(cccd));
                    frm.ShowDialog();
                }
            }
        }
        public void LoadCbo_TimKiem()
        {
            string[] strings = { "CCCD", "Họ tên", "Giới tính" };
            foreach (string s in strings)
            {
                cbo_LoaiTK.Items.Add(s);
            }
            if (cbo_LoaiTK.Items.Count > 0)
            {
                cbo_LoaiTK.SelectedIndex = 0;
            }
        }
        public void LoadData()
        {
            khblldal.getKHs(dgv_KhachHang);
            tssLbl_TongCong.Text = dgv_KhachHang.RowCount.ToString();
            rdo_Nam.Checked = true;
        }
        private void UC_DanhSachKH_Load(object sender, EventArgs e)
        {
            LoadCbo_TimKiem();
            LoadData();
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

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.RowCount < 1)
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
                    khblldal.search(cbo_LoaiTK.SelectedIndex, search, dgv_KhachHang);
                }
            }
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                khblldal.sort(dgv_KhachHang);
            }
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_KhachHang.RowCount < 1)
                {
                    this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
                }
                else
                {
                    int index = dgv_KhachHang.CurrentRow.Index;
                    if (index < 0)
                    {
                        this.Message("Chưa chọn nhân viên", MyMessageBox.enmType.Error);
                    }
                    else
                    {
                        string cccd = dgv_KhachHang.Rows[index].Cells["CCCDKH"].Value.ToString();
                        int manv = khblldal.getMaKH(cccd);
                        khblldal.delete(manv);
                        this.Message("Success", MyMessageBox.enmType.Success);
                        LoadData();
                    }
                }
            }
            catch
            {
                this.Message("Khách hàng này đang được sử dụng", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_InExcel_Click(object sender, EventArgs e)
        {
            ba.XuatExcel(dgv_KhachHang);
        }
    }
}
