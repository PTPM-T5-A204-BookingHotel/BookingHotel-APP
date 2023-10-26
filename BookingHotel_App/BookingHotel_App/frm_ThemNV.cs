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
    public partial class frm_ThemNV : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThemNV()
        {
            InitializeComponent();
        }
        ChucVu_BLL_DAL cvblldal = new ChucVu_BLL_DAL();
        NhanVien_BLL_DAL nvblldal = new NhanVien_BLL_DAL();
        Basis ba = new Basis();
        ErrorProvider ep = new ErrorProvider();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        private void btn_EditChucVu_Click(object sender, EventArgs e)
        {
            frm_ChucVu frm = new frm_ChucVu();
            frm.ShowDialog();
        }
        public void LoadCbo_ChucVu()
        {
            cbo_ChucVu.ValueMember = "MaCV";
            cbo_ChucVu.DisplayMember = "TenCV";
            cbo_ChucVu.DataSource = cvblldal.getCVs();
            if (cbo_ChucVu.Items.Count > 0)
            {
                cbo_ChucVu.SelectedIndex = 0;
            }
        }
        public bool isThongTinNV(string cccd,string hoten,string sodienthoai,DateTime ngaysinh, string diachi,string anhnv,string email)
        {
            if (cccd.Equals(""))
            {
                ep.SetError(txt_CCCD, "CCCD không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (!ba.isCCCD(cccd))
            {
                ep.SetError(txt_CCCD, "CCCD không hợp lệ");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (nvblldal.isCCCD(cccd)!=0)
            {
                ep.SetError(txt_CCCD, "CCCD đã có");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (hoten.Equals(""))
            {
                ep.SetError(txt_Hoten, "Họ tên không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (sodienthoai.Equals(""))
            {
                ep.SetError(txt_SDT, "Số điện thoại không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (!ba.isSDT(sodienthoai))
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
            
            if (!ba.isNgaySinh(ngaysinh))
            {
                ep.SetError(dt_NgaySinh, "Nhân viên >= 18 tuổi");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (!email.Equals(""))
            {
                if (!ba.isEmail(email))
                {
                    ep.SetError(txt_Email, "Email không hợp lệ");
                    return false;
                }
                else
                {
                    ep.Clear();
                }
            }
            if (anhnv == null)
            {
                this.Message("Chưa có ảnh", MyMessageBox.enmType.Error);
                return false;
            }
            return true;
        }

        private void frm_ThemNV_Load(object sender, EventArgs e)
        {
            rdo_Nam.Checked = true;
            LoadCbo_ChucVu();
        }

        private void btn_UpImage_Click(object sender, EventArgs e)
        {
            ba.UpLoadImage(pic_Image);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string cccd = txt_CCCD.Text.Trim();
            string hoten = txt_Hoten.Text.Trim();
            string gt = "";
            if(rdo_Nam.Checked)
            {
                gt = "Nam";
            }
            if(rdo_Nu.Checked)
            {
                gt = "Nữ";
            }
            string email = txt_Email.Text.Trim();
            string diachi = txt_DiaChi.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            int cv = int.Parse(cbo_ChucVu.SelectedValue.ToString());
            DateTime ns = dt_NgaySinh.Value;
            string anh = pic_Image.ImageLocation;
            try
            {
                if (isThongTinNV(cccd, hoten, sdt, ns, diachi, anh, email))
                {
                    nvblldal.insert(cccd, hoten, gt, sdt, ns, diachi, anh, email, cv);
                    this.Message("Success", MyMessageBox.enmType.Success);
                }
            }
            catch
            {
                this.Message("Error Data", MyMessageBox.enmType.DataFail);
            }
            
        }
    }
}