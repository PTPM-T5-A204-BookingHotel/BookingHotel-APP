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
    public partial class UC_DichVu : UserControl
    {
        public UC_DichVu()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        DichVu_BLL_DAL dv_blldal = new DichVu_BLL_DAL();
        Basis ba = new Basis();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        public void Load_cboTimKiem()
        {
            string[] arr = { "Tên", "Giá lớn nhất", "Giá nhỏ nhất", "Khoảng giá" };
            foreach(string str in arr)
            {
                cbo_LoaiTK.Items.Add(str);
            }
            cbo_LoaiTK.SelectedIndex = 0;
        }
        public void Load_cboSort()
        {
            string[] arr = { "Tên tăng dần", "Giá tăng dần", "Giá giảm dần" };
            foreach (string str in arr)
            {
                cbo_LoaiSapXep.Items.Add(str);
            }
            cbo_LoaiSapXep.SelectedIndex = 0;
        }
        public void LoadData()
        {
            dgv_DichVu.DataSource = dv_blldal.getDVs();
            tssLbl_TongCong.Text = dgv_DichVu.RowCount.ToString();
        }
        private void UC_DichVu_Load(object sender, EventArgs e)
        {
            Load_cboSort();
            Load_cboTimKiem();
            LoadData();
        }
        public bool isThongTinDV(string madv,string tendv,string giadv)
        {
            if (madv.Equals(""))
            {
                ep.SetError(txt_Ma, "Mã không để trống");
                return false;
            }
            else
                ep.Clear();
            if (tendv.Equals(""))
            {
                ep.SetError(txt_TenDV, "Tên không để trống");
                return false;
            }
            else
                ep.Clear();
            if (giadv.Equals(""))
            {
                ep.SetError(txt_GiaDV, "Giá không để trống");
                return false;
            }
            else
                ep.Clear();
            return true;
        }

        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            string madv = txt_Ma.Text.Trim();
            string tendv = txt_TenDV.Text.Trim();
            string giadv = txt_GiaDV.Text.Trim();
            string mota = rtxt_MoTa.Text.Trim();
            if (isThongTinDV(madv, tendv, giadv))
            {
                if(dv_blldal.isMaDV(madv) == 0)
                {
                    dv_blldal.insert(madv, tendv, int.Parse(giadv), mota);
                    this.Message("Success", MyMessageBox.enmType.Success);
                    LoadData();
                }else
                {
                    this.Message("Dịch vụ đã có", MyMessageBox.enmType.Error);
                }    
                
            }
        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            string madv = txt_Ma.Text.Trim();
            string tendv = txt_TenDV.Text.Trim();
            string giadv = txt_GiaDV.Text.Trim();
            string mota = rtxt_MoTa.Text.Trim();
            if (isThongTinDV(madv, tendv, giadv))
            {
                dv_blldal.update(madv, tendv, int.Parse(giadv), mota);
                this.Message("Success", MyMessageBox.enmType.Success);
                LoadData();
            }
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            string madv = txt_Ma.Text.Trim();
            if (madv.Equals(""))
                this.Message("Mã không để trống", MyMessageBox.enmType.Error);
            else
            {
                dv_blldal.delete(madv);
                this.Message("Success", MyMessageBox.enmType.Success);
                LoadData();
            }
        }

        private void dgv_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_DichVu.Rows[e.RowIndex];
            txt_Ma.Text = row.Cells[0].Value.ToString();
            txt_TenDV.Text = row.Cells[1].Value.ToString();
            txt_GiaDV.Text = row.Cells[2].Value.ToString();
            rtxt_MoTa.Text = row.Cells[3].Value.ToString();
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            if(dgv_DichVu.RowCount> 0)
            {
                int index = cbo_LoaiSapXep.SelectedIndex;
                dgv_DichVu.DataSource = dv_blldal.sort(index);
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            
        }

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            string tendv = txt_TenDV.Text.Trim();
            int index = cbo_LoaiTK.SelectedIndex;
            switch (index)
            {
                case 0:
                {
                       if (tendv.Equals(""))
                       {
                            this.Message("Chưa nhập tên dịch vụ", MyMessageBox.enmType.Error);
                       }
                       else
                       {
                            dgv_DichVu.DataSource = dv_blldal.search(tendv);
                       }
                       break;
                 }
                 case 1: 
                 {
                        dgv_DichVu.DataSource = dv_blldal.MaxGiaDV();
                        break; 
                 }
                case 2:
                    {
                        dgv_DichVu.DataSource = dv_blldal.MinGiaDV();
                        break;
                    }
                default:
                    {
                        
                        if(txt_GiaBD.Text.Trim().Equals("") || txt_GiaKT.Text.Trim().Equals(""))
                        {
                            this.Message("Giá bắt đầu/giá kết thúc không để trống", MyMessageBox.enmType.Error);
                        }
                        else
                        {
                            int giabd = int.Parse(txt_GiaBD.Text.Trim());
                            int giakt = int.Parse(txt_GiaKT.Text.Trim());
                            dgv_DichVu.DataSource = dv_blldal.search_KhoangGia(giabd, giakt);
                        }
                        
                        break;
                    }
            }
            
        }

        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            ba.clearTextBoxs(this.Controls);
            cbo_LoaiSapXep.SelectedIndex = 0;
            cbo_LoaiTK.SelectedIndex = 0;
            rtxt_MoTa.Text = "";
            LoadData();
        }
    }
}
