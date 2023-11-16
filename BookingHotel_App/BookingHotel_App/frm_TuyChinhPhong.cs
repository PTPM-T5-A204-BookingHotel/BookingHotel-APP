using BLL_DAL;
using DevExpress.XtraEditors;
using Emgu.CV.Flann;
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
    public partial class frm_TuyChinhPhong : DevExpress.XtraEditors.XtraForm
    {
        public frm_TuyChinhPhong()
        {
            InitializeComponent();
        }
        Phong_BLL_DAL phblldal = new Phong_BLL_DAL();
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
            string[] strings = { "Loại phòng", "Tên phòng","Tầng" };
            foreach (string s in strings)
            {
                cbo_LoaiTK.Items.Add(s);
            }
            cbo_LoaiTK.SelectedIndex = 0;
        }
        public void LoadData()
        {
            phblldal.GetPhongs(dgv_Phong);
            tssLbl_TongCong.Text = dgv_Phong.RowCount.ToString();
        }
        public void createCbo_LoaiPh()
        {
            cbo_LoaiPhong.DataSource = null;
            cbo_LoaiPhong.ValueMember = "MaLP";
            cbo_LoaiPhong.DisplayMember = "TenLP";
            cbo_LoaiPhong.DataSource = lpblldal.getLoaiPhs();
            if (cbo_LoaiPhong.Items.Count > 0)
            {
                cbo_LoaiPhong.SelectedIndex = 0;
            }
        }
        public void createCbo_TinhTrang()
        {
            string[] strings = { "Trống", "Đang sửa/dọn dẹp", "Đang thuê" };
            foreach (string s in strings)
            {
                cbo_TinhTrang.Items.Add(s);
            }
            cbo_TinhTrang.SelectedIndex = 0;
        }
        private void frm_TuyChinhPhong_Load(object sender, EventArgs e)
        {
            LoadCbo_LoaiTK();
            LoadData();
            createCbo_LoaiPh();
            createCbo_TinhTrang();
        }
        public bool isPhong(string tenph,string tang)
        {
            if (tenph.Equals(""))
            {
                ep.SetError(txt_Phong, "Phòng không để trống");
                return false;
            }
            else
            {
                ep.Clear();
            }
            if (tang.Equals(""))
            {
                ep.SetError(txt_Tang, "Tầng không để trống");
            }
            else
            {
                ep.Clear();
            }
            return true;
        }
        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            string tenph = txt_Phong.Text.Trim();
            string tang = txt_Tang.Text.Trim();
            string malp = cbo_LoaiPhong.SelectedValue.ToString();
            if (isPhong(tenph, tang))
            {
                if (phblldal.isTenPhong(tenph) == 0)
                {
                    phblldal.insert(tenph,int.Parse(malp),int.Parse(tang));
                    this.Message("Success", MyMessageBox.enmType.Success);
                    LoadData();
                }
                else
                {
                    this.Message("Phòng đã có", MyMessageBox.enmType.Error);
                }
            }
        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            string tenph = txt_Phong.Text.Trim();
            string tang = txt_Tang.Text.Trim();
            string malp = cbo_LoaiPhong.SelectedValue.ToString();
            int index = dgv_Phong.CurrentRow.Index;
            if (dgv_Phong.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                if (index < 0)
                    this.Message("Chưa chọn phòng", MyMessageBox.enmType.Error);
                else
                {
                    int maph = int.Parse(dgv_Phong.Rows[index].Cells[0].Value.ToString());
                    if (isPhong(tenph, tang))
                    {
                        phblldal.update(maph, tenph, int.Parse(malp), int.Parse(tang));
                        this.Message("Success", MyMessageBox.enmType.Success);
                        LoadData();
                    }
                }
            }
            
            
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_Phong.CurrentRow.Index;
            if (dgv_Phong.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                if (index < 0)
                    this.Message("Chưa chọn phòng", MyMessageBox.enmType.Error);
                else
                {
                    int maph = int.Parse(dgv_Phong.Rows[index].Cells[0].Value.ToString());
                    phblldal.delete(maph);
                    this.Message("Success", MyMessageBox.enmType.Success);
                    LoadData();
                }
            }
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            if (dgv_Phong.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                phblldal.sort(dgv_Phong);
            }
        }

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            if (dgv_Phong.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                int searchType = cbo_LoaiTK.SelectedIndex;
                string value = "";
                if (searchType == 0)
                {
                    value = cbo_LoaiPhong.SelectedValue.ToString();
                }
                else
                {
                    if (searchType == 1)
                    {
                        value = txt_Phong.Text.Trim();
                        if (value.Equals(""))
                        {
                            this.Message("Phòng không để trống", MyMessageBox.enmType.Error);
                        }
                    }
                    else
                    {
                        value = txt_Tang.Text.Trim();
                        if (value.Equals(""))
                        {
                            this.Message("Tầng không để trống", MyMessageBox.enmType.Error);
                        }
                    }
                }
                phblldal.search(searchType, value,dgv_Phong);
            }
        }

        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            createCbo_LoaiPh();
            cbo_LoaiTK.SelectedIndex = 0;
            LoadData();
            ba.clearTextBoxs(this.Controls);
        }

        private void btn_EditLoaiPh_Click(object sender, EventArgs e)
        {
            frm_QLLoaiPh frm = new frm_QLLoaiPh();
            frm.ShowDialog();
        }

        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Phong.RowCount < 1)
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                if (e.RowIndex > 0)
                {
                    row = dgv_Phong.Rows[e.RowIndex];
                    txt_Phong.Text = row.Cells["TenPH"].Value.ToString();
                    cbo_LoaiPhong.SelectedValue = int.Parse(row.Cells["MaLP"].Value.ToString());
                    txt_Tang.Text = row.Cells["Tang"].Value.ToString();
                    cbo_TinhTrang.SelectedItem = row.Cells["TinhTrangPH"].Value.ToString();
                }
            }
        }
    }
}