using BLL_DAL;
using DevExpress.Utils.Gesture;
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
    public partial class frm_QLLoaiPh : DevExpress.XtraEditors.XtraForm
    {
        public frm_QLLoaiPh()
        {
            InitializeComponent();
        }
        LoaiPhong_BLL_DAL lpblldal = new LoaiPhong_BLL_DAL();
        Basis ba = new Basis();
        ErrorProvider ep = new ErrorProvider();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        public void LoadCbo_LoaiTK()
        {
            string[] strings = { "Tên", "Giá"};
            foreach (string s in strings)
            {
                cbo_LoaiTK.Items.Add(s);
            }
            cbo_LoaiTK.SelectedIndex = 0;
        }
        public void LoadData()
        {
            lpblldal.getLoaiPhs(dgv_LoaiPH);
            tssLbl_TongCong.Text = dgv_LoaiPH.RowCount.ToString();
        }
        private void frm_QLLoaiPh_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCbo_LoaiTK();
        }
        public bool isThongTinLP(string ten,string gia,string anh)
        {
            if (ten.Equals(""))
            {
                ep.SetError(txt_TenLP, "Tên không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (gia.Equals(""))
            {
                ep.SetError(txt_GiaLP, "Giá không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (anh == null)
            {
                this.Message("Chưa có ảnh", MyMessageBox.enmType.Error);
                return false;
            }
            return true;
        }
        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            string ten = txt_TenLP.Text.Trim();
            string gia = txt_GiaLP.Text.Trim();
            string anh = pic_Image.ImageLocation;
            if (isThongTinLP(ten, gia, anh))
            {
                if (lpblldal.isTenLP(ten) == 0)
                {
                    lpblldal.insert(ten, int.Parse(gia), anh);
                    this.Message("Success", MyMessageBox.enmType.Success);
                    LoadData();
                }
                else
                {
                    this.Message("Trùng tên loại phòng", MyMessageBox.enmType.Error);
                }
            }
        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_LoaiPH.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                string ten = txt_TenLP.Text.Trim();
                string gia = txt_GiaLP.Text.Trim();
                string anh = pic_Image.ImageLocation;
                int index = dgv_LoaiPH.CurrentRow.Index;
                if (index < 0)
                {
                    this.Message("Chưa chọn loại phòng", MyMessageBox.enmType.Error);
                }
                else
                {
                    if (isThongTinLP(ten, gia, anh))
                    {
                        string ma = dgv_LoaiPH.Rows[index].Cells[0].ToString();
                        lpblldal.update(int.Parse(ma), ten, int.Parse(gia), anh);
                        this.Message("Success", MyMessageBox.enmType.Success);
                        LoadData();
                    }
                }
            }
            
            
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_LoaiPH.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                int index = dgv_LoaiPH.CurrentRow.Index;
                if (index < 0)
                {
                    this.Message("Chưa chọn loại phòng", MyMessageBox.enmType.Error);
                }
                else
                {
                    string ma = dgv_LoaiPH.Rows[index].Cells["MaLP"].ToString();
                    lpblldal.delete(int.Parse(ma));
                    this.Message("Success", MyMessageBox.enmType.Success);
                    LoadData();
                }
            }
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            if (dgv_LoaiPH.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                lpblldal.sort(dgv_LoaiPH);
            }
        }

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            if (dgv_LoaiPH.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                string value = "";
                if (cbo_LoaiTK.SelectedIndex == 0)
                {
                    value = txt_TenLP.Text.Trim();
                }
                else
                {
                    value = txt_GiaLP.Text.Trim();
                }
                lpblldal.search(cbo_LoaiTK.SelectedIndex, value, dgv_LoaiPH);
            }
        }

        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            ba.clearTextBoxs(this.Controls);
            LoadData();
            cbo_LoaiTK.SelectedIndex = 0;
        }

        private void dgv_LoaiPH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex > 0)
            {
                row = dgv_LoaiPH.Rows[e.RowIndex];
                txt_TenLP.Text = row.Cells["TenLP"].Value.ToString();
                txt_GiaLP.Text = row.Cells["GiaPH"].Value.ToString();
                if(lpblldal.getAnh(row.Cells["MaLP"].ToString()) !=null)
                {
                    pic_Image.ImageLocation = lpblldal.getAnh(row.Cells["MaLP"].ToString());
                }
                
            }
        }

        private void btn_UpImage_Click(object sender, EventArgs e)
        {
            ba.UpLoadImage(pic_Image);
        }
    }
}