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
    public partial class UC_DatPhongOnline : UserControl
    {
        public UC_DatPhongOnline()
        {
            InitializeComponent();
        }
        DatPhongOnl_BLL_DAL dponlblldal = new DatPhongOnl_BLL_DAL();
        TaiKhoan_BLL_DAL tkblldal = new TaiKhoan_BLL_DAL();
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
        public void LoadData()
        {
            dponlblldal.getDPs(dgv_DatPhongOnl);
            tssLbl_TongCong.Text = dgv_DatPhongOnl.RowCount.ToString();
            string quyen = tkblldal.getTK(taikhoan).MaQuyen;
            if (quyen == "Admin")
            {
                tsBtn_Check.Enabled = false;


            }
        }
        private void UC_DatPhongOnline_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tsBtn_Check_Click(object sender, EventArgs e)
        {
            int index = dgv_DatPhongOnl.CurrentRow.Index;
            if (index < 0)
            {
                this.Message("Chưa chọn dòng cần check", MyMessageBox.enmType.Error);
            }
            else
            {
                int madp = int.Parse(dgv_DatPhongOnl.Rows[index].Cells["MaDP"].Value.ToString());
                dponlblldal.Update(madp);
                LoadData();
                this.Message("Success", MyMessageBox.enmType.Success);
            }
        }
    }
}
