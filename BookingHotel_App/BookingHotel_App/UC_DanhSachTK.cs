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
    public partial class UC_DanhSachTK : UserControl
    {
        public UC_DanhSachTK()
        {
            InitializeComponent();
        }
        Basis ba = new Basis();
        TaiKhoan_BLL_DAL tkblldal = new TaiKhoan_BLL_DAL();
        NhanVien_BLL_DAL nvblldal = new NhanVien_BLL_DAL();
        Quyen_BLL_DAL qblldal = new Quyen_BLL_DAL();
        ErrorProvider ep = new ErrorProvider();

        string taikhoan;
        public void setTenTK(string tentk)
        {
            taikhoan = tentk;
        }
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        private void btn_UpImage_Click(object sender, EventArgs e)
        {
            pic_Image.ImageLocation = null;
            ba.UpLoadImage(pic_Image);
        }
        public void LoadCbo_Quyen()
        {
            //cbo_Quyen.DataSource = null;
            cbo_Quyen.ValueMember = "MaQuyen";
            cbo_Quyen.DisplayMember = "TenQuyen";
            cbo_Quyen.DataSource = qblldal.GetQuyens();
            if (cbo_Quyen.Items.Count > 0)
            {
                cbo_Quyen.SelectedIndex = 0;
            }
        }
        public void LoadCbo_LoaiTK()
        {
            string[] strings = { "Quyền", "Tên tài khoản" };
            foreach(string s in strings)
            {
                cbo_LoaiTK.Items.Add(s);
            }
            cbo_LoaiTK.SelectedIndex = 0;
        }
        public void LoadDataNhanVien()
        {
            nvblldal.getNVs(dgv_NhanVien);
        }
        public void LoadData()
        {
            string quyen = tkblldal.getTK(taikhoan).MaQuyen;
            tkblldal.getTKs(dgv_TaiKhoan, quyen);
            tssLbl_TongCong.Text = dgv_TaiKhoan.RowCount.ToString();
        }
        private void UC_DanhSachTK_Load(object sender, EventArgs e)
        {
            LoadCbo_Quyen();
            LoadData();
            LoadDataNhanVien();
            LoadCbo_LoaiTK();
        }
        public bool isThongTinTK(string tentk,string mk,string cccd,string anh)
        {
            if (tentk.Equals(""))
            {
                ep.SetError(txt_TenTK, "Tên tài khoản không để trống");
                return false;
            }
            else
                ep.Clear();
            if (mk.Equals(""))
            {
                ep.SetError(txt_MatKhau, "Mật khẩu không để trống");
                return false;
            }
            else
                ep.Clear();
            if (cccd.Equals(""))
            {
                ep.SetError(txt_CCCD, "CCCD không để trống");
                return false;
            }
            else
                ep.Clear();
            if (!ba.isCCCD(cccd))
            {
                ep.SetError(txt_CCCD, "CCCD không hợp lệ");
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
        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            LoadCbo_Quyen();
            cbo_LoaiTK.SelectedIndex = 0;
            ba.clearTextBoxs(this.Controls);
            LoadData();
        }

        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            string quyen = tkblldal.getTK(taikhoan).MaQuyen;
            string chonquyen = cbo_Quyen.SelectedValue.ToString();
            if (quyen == "Admin" && chonquyen == "Admin")
            {
                this.Message("Tài khoản này không tạo quyền Admin", MyMessageBox.enmType.Error);
                
            }
            else
            {
                string tentk = txt_TenTK.Text.Trim();
                string mk = txt_MatKhau.Text.Trim();
                string cccd = txt_CCCD.Text.Trim();
                string anh = pic_Image.ImageLocation;
                if (isThongTinTK(tentk, mk, cccd, anh))
                {
                    if (tkblldal.isTK(tentk) == 0)
                    {
                        int manv = nvblldal.getMaNV(cccd);
                        tkblldal.insert(tentk, mk, manv, cbo_Quyen.SelectedValue.ToString(), anh);
                        this.Message("Success", MyMessageBox.enmType.Success);
                        LoadData();
                    }
                    else
                    {
                        this.Message("Tài khoản này đã có", MyMessageBox.enmType.Error);
                    }

                }
            }
        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
           
            if (dgv_TaiKhoan.RowCount > 0)
            {
                string quyen = tkblldal.getTK(taikhoan).MaQuyen;
                string chonquyen = cbo_Quyen.SelectedValue.ToString();
                if (quyen == "Admin" && chonquyen == "Admin")
                {
                    this.Message("Tài khoản này không sửa quyền Admin", MyMessageBox.enmType.Error);
                    
                }
                else
                {
                    string tentk = txt_TenTK.Text.Trim();
                    string mk = txt_MatKhau.Text.Trim();
                    string cccd = txt_CCCD.Text.Trim();
                    string anh = pic_Image.ImageLocation;
                    if (isThongTinTK(tentk, mk, cccd, anh))
                    {
                        int manv = nvblldal.getMaNV(cccd);
                        tkblldal.update(tentk, mk, manv, cbo_Quyen.SelectedValue.ToString(), anh);
                        this.Message("Success", MyMessageBox.enmType.Success);
                        LoadData();
                    }
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            string tentk = txt_TenTK.Text.Trim();
            if (dgv_TaiKhoan.RowCount > 0)
            {
                if (tentk.Equals(""))
                    this.Message("Tên tài khoản không để trống", MyMessageBox.enmType.Error);
                else
                {
                    tkblldal.delete(tentk);
                    this.Message("Success", MyMessageBox.enmType.Success);
                    LoadData();
                }
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            if (dgv_TaiKhoan.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                tkblldal.sort(dgv_TaiKhoan);
            }
        }

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            if (dgv_TaiKhoan.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                string tk = "";
                if (cbo_LoaiTK.SelectedIndex == 1)
                {
                    tk = txt_TimKiem.Text.Trim();
                    if (tk.Equals(""))
                    {
                        this.Message("Chưa nhập tìm kiếm", MyMessageBox.enmType.Error);
                    }
                }
                else
                {
                    tk = cbo_Quyen.SelectedValue.ToString();
                }
                tkblldal.search(cbo_LoaiTK.SelectedIndex, tk, dgv_TaiKhoan);
            }
            
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {
                row = dgv_NhanVien.Rows[e.RowIndex];
                txt_CCCD.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex >= 0)
            {

                row = dgv_TaiKhoan.Rows[e.RowIndex];
                txt_TenTK.Text = row.Cells["TenTK"].Value.ToString();
                txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
               
                if (row.Cells["MaNV"].Value != null)
                {
                    int manv = int.Parse(row.Cells["MaNV"].Value.ToString());
                    txt_CCCD.Text = nvblldal.getNV(manv).CCCDNV;
                }
                else
                {
                    txt_CCCD.Text = "";
                }
                cbo_Quyen.SelectedValue = row.Cells[3].Value.ToString();
                pic_Image.ImageLocation = tkblldal.getAnh(txt_TenTK.Text);
            }
        }

        
    }
}
