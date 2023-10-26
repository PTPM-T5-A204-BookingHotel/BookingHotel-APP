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
    public partial class frm_ChucVu : DevExpress.XtraEditors.XtraForm
    {
        
        public frm_ChucVu()
        {
            InitializeComponent();
        }
        ChucVu_BLL_DAL cvblldal = new ChucVu_BLL_DAL();
        ErrorProvider ep = new ErrorProvider();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        public void LoadData()
        {
            cbo_ChucVu.ValueMember = "MaCV";
            cbo_ChucVu.DisplayMember = "TenCV";
            cbo_ChucVu.DataSource = cvblldal.getCVs();
            if(cbo_ChucVu.Items.Count>0 )
            {
                cbo_ChucVu.SelectedIndex = 0;
            }
        }

        private void frm_ChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            string cv = txt_ChucVu.Text.Trim();
            if (cv.Equals(""))
            {
                ep.SetError(txt_ChucVu, "Chức vụ không để trống");
            }
            else
            {
                ep.Clear();
                cvblldal.insert(cv);
                this.Message("Success", MyMessageBox.enmType.Success);
                LoadData();
            }
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                cvblldal.delete(int.Parse(cbo_ChucVu.SelectedValue.ToString()));
                this.Message("Success", MyMessageBox.enmType.Success);
                LoadData();
            }
            catch
            {
                this.Message("Chức vụ này đang được sử dụng",MyMessageBox.enmType.Error);
            }
            
        }
    }
}