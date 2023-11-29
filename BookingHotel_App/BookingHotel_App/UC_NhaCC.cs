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
    public partial class UC_NhaCC : UserControl
    {
        public UC_NhaCC()
        {
            InitializeComponent();
        }
        NhaCC_BLL_DAL nccblldal = new NhaCC_BLL_DAL();
        Basis ba = new Basis();
        ErrorProvider ep = new ErrorProvider();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        public void Load_CboLoaiTK()
        {
            string[] s = { "Tên", "Số điện thoại" };
            foreach(string i in s)
            {
                cbo_LoaiTK.Items.Add(i);
            }
            if(cbo_LoaiTK.Items.Count>0)
            {
                cbo_LoaiTK.SelectedIndex = 0;
            }
        }
        public void LoadData()
        {
            dgv_NhaCC.DataSource = nccblldal.getNhaCCs();
            tssLbl_TongCong.Text = dgv_NhaCC.RowCount.ToString();
        }

        private void UC_NhaCC_Load(object sender, EventArgs e)
        {
            Load_CboLoaiTK();
            LoadData();
        }
        public bool isThongTinNCC(string ma,string ten,string sdt,string diachi)
        {
            if (ma.Equals(""))
            {
                ep.SetError(txt_MaNCC, "Mã không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (ten.Equals(""))
            {
                ep.SetError(txt_TenNCC, "Tên không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (sdt.Equals(""))
            {
                ep.SetError(txt_SDT, "Số điện thoại không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (!ba.isSDT(sdt))
            {
                ep.SetError(txt_SDT, "Số điện thoại không hợp lệ");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (diachi.Equals(""))
            {
                ep.SetError(txt_DiaChi, "Địa chỉ không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            return true;
        }
        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            string ma = txt_MaNCC.Text.Trim();
            string ten = txt_TenNCC.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            string dc = txt_DiaChi.Text.Trim();
            if (isThongTinNCC(ma, ten, sdt, dc))
            {
                if (nccblldal.isMaNCC(ma) == 0)
                {
                    nccblldal.insert(ma,ten, dc, sdt);
                    this.Message("Success", MyMessageBox.enmType.Success);
                    LoadData();
                }
                else
                {
                    this.Message("Nhà cung cấp đã tồn tại", MyMessageBox.enmType.Error);
                }
            }
        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_NhaCC.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                string ma = txt_MaNCC.Text.Trim();
                string ten = txt_TenNCC.Text.Trim();
                string sdt = txt_SDT.Text.Trim();
                string dc = txt_DiaChi.Text.Trim();
                if (isThongTinNCC(ma, ten, sdt, dc))
                {
                    nccblldal.update(ma, ten, dc, sdt);
                    this.Message("Success", MyMessageBox.enmType.Success);
                    LoadData();
                }
            }
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {


                string ma = txt_MaNCC.Text.Trim();
                if (dgv_NhaCC.RowCount > 0)
                {
                    if (ma.Equals(""))
                    {
                        this.Message("Chưa chọn nhà cung cấp", MyMessageBox.enmType.Error);
                    }
                    else
                    {
                        nccblldal.delete(ma);
                        this.Message("Success", MyMessageBox.enmType.Success);
                        LoadData();
                    }
                }
                else
                {
                    this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
                }
            }
            catch
            {
                this.Message("Nhà cung cấp này đang được sử dụng", MyMessageBox.enmType.Error);
            }
            
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            if (dgv_NhaCC.RowCount > 0)
            {
                dgv_NhaCC.DataSource = nccblldal.sort();
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            if (dgv_NhaCC.RowCount > 0)
            {
                string search = txt_Search.Text.Trim();
                if (search.Equals(""))
                {
                    this.Message("Chưa nhập tìm kiếm", MyMessageBox.enmType.Error);
                }
                else
                {
                    dgv_NhaCC.DataSource = nccblldal.search(cbo_LoaiTK.SelectedIndex,search);
                }
                
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            cbo_LoaiTK.SelectedIndex = 0;
            ba.clearTextBoxs(this.Controls);
            LoadData();
        }

        private void dgv_NhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >=0)
            {
                row = dgv_NhaCC.Rows[e.RowIndex];
                txt_MaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txt_TenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txt_SDT.Text = row.Cells["SDTNCC"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChiNCC"].Value.ToString();
            }
        }

        private void tsBtn_InExcel_Click(object sender, EventArgs e)
        {
            ba.XuatExcel(dgv_NhaCC);
        }
    }
}
