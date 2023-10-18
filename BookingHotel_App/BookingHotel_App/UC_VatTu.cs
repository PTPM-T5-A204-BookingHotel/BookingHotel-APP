﻿using BLL_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingHotel_App
{
    public partial class UC_VatTu : UserControl
    {
        public UC_VatTu()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        VatTu_BLL_DAL vt_blldal = new VatTu_BLL_DAL();
        Basis ba = new Basis();
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        public void Load_cboTimKiem()
        {
            string[] arr = { "Tên","Thương hiệu","Giá lớn nhất", "Giá nhỏ nhất", "Khoảng giá" };
            foreach (string str in arr)
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
            dgv_VatTu.DataSource = vt_blldal.getVTs();
            tssLbl_TongCong.Text = dgv_VatTu.RowCount.ToString();
        }
        private void UC_VatTu_Load(object sender, EventArgs e)
        {
            Load_cboSort();
            Load_cboTimKiem();
            LoadData();
        }
        public bool isThongTinVT(string mavt, string tenvt, string giavt,string soluong)
        {
            if (mavt.Equals(""))
            {
                ep.SetError(txt_Ma, "Mã không để trống");
                return false;
            }
            else
                ep.Clear();
            if (tenvt.Equals(""))
            {
                ep.SetError(txt_TenVT, "Tên không để trống");
                return false;
            }
            else
                ep.Clear();
            if (giavt.Equals(""))
            {
                ep.SetError(txt_GiaVT, "Giá không để trống");
                return false;
            }
            else
                ep.Clear();
            if (soluong.Equals(""))
            {
                ep.SetError(txt_SL, "Số lượng không để trống");
                return false;
            }
            else
                ep.Clear();
            return true;
        }
        private void tsBtn_Reset_Click(object sender, EventArgs e)
        {
            ba.clearTextBoxs(this.Controls);
            cbo_LoaiSapXep.SelectedIndex = 0;
            cbo_LoaiTK.SelectedIndex = 0;
            LoadData();
        }

        private void tsBtn_Them_Click(object sender, EventArgs e)
        {
            string mavt = txt_Ma.Text.Trim();
            string tenvt = txt_TenVT.Text.Trim();
            string thghieu = txt_ThgHieu.Text.Trim();
            string dvt = txt_DVT.Text.Trim();
            string soluong = txt_SL.Text.Trim();
            string gia = txt_GiaVT.Text.Trim();
            byte[] anh = ba.ConvertImgToByte(pic_Image.Image);
            if (isThongTinVT(mavt, tenvt, gia, soluong) && vt_blldal.isMaVT(mavt)==0)
            {
                vt_blldal.insert(mavt, tenvt, dvt, thghieu, int.Parse(soluong), int.Parse(gia), anh);
                this.Message("Success", MyMessageBox.enmType.Success);
                LoadData();
            }

        }

        private void tsBtn_Sua_Click(object sender, EventArgs e)
        {
            string mavt = txt_Ma.Text.Trim();
            string tenvt = txt_TenVT.Text.Trim();
            string thghieu = txt_ThgHieu.Text.Trim();
            string dvt = txt_DVT.Text.Trim();
            string soluong = txt_SL.Text.Trim();
            string gia = txt_GiaVT.Text.Trim();
            byte[] anh = ba.ConvertImgToByte(pic_Image.Image);
            if (isThongTinVT(mavt, tenvt, gia, soluong))
            {
                vt_blldal.update(mavt, tenvt, dvt, thghieu, int.Parse(soluong), int.Parse(gia), anh);
                this.Message("Success", MyMessageBox.enmType.Success);
                LoadData();
            }
        }

        private void tsBtn_Xoa_Click(object sender, EventArgs e)
        {
            string mavt = txt_Ma.Text.Trim();
            if (mavt.Equals(""))
                this.Message("Mã không để trống", MyMessageBox.enmType.Error);
            else
            {
                vt_blldal.delete(mavt);
                this.Message("Success", MyMessageBox.enmType.Success);
                LoadData();
            }
        }

        private void tsBtn_SapXep_Click(object sender, EventArgs e)
        {
            if (dgv_VatTu.RowCount > 0)
            {
                int index = cbo_LoaiSapXep.SelectedIndex;
                dgv_VatTu.DataSource = vt_blldal.sort(index);
            }
            else
            {
                this.Message("Chưa có dữ liệu", MyMessageBox.enmType.Error);
            }
        }

        private void tsBtn_TimKiem_Click(object sender, EventArgs e)
        {
            string tenvt = txt_TenVT.Text.Trim();
            string thghieu = txt_ThgHieu.Text.Trim();
            int index = cbo_LoaiTK.SelectedIndex;
            switch (index)
            {
                case 0:
                    {
                        if (tenvt.Equals(""))
                        {
                            this.Message("Chưa nhập tên vật tư", MyMessageBox.enmType.Error);
                        }
                        else
                        {
                            dgv_VatTu.DataSource = vt_blldal.search(index,tenvt);
                        }
                        break;
                    }
                case 1:
                    {
                        if (thghieu.Equals(""))
                        {
                            this.Message("Chưa nhập thương hiệu", MyMessageBox.enmType.Error);
                        }
                        else
                        {
                            dgv_VatTu.DataSource = vt_blldal.search(index, thghieu);
                        }
                        break;
                    }
                case 2:
                    {
                        dgv_VatTu.DataSource = vt_blldal.MaxGia();
                        break;
                    }
                case 3:
                    {
                        dgv_VatTu.DataSource = vt_blldal.MinGia();
                        break;
                    }
                default:
                    {

                        if (txt_GiaBD.Text.Trim().Equals("") || txt_GiaKT.Text.Trim().Equals(""))
                        {
                            this.Message("Giá bắt đầu/giá kết thúc không để trống", MyMessageBox.enmType.Error);
                        }
                        else
                        {
                            int giabd = int.Parse(txt_GiaBD.Text.Trim());
                            int giakt = int.Parse(txt_GiaKT.Text.Trim());
                            dgv_VatTu.DataSource = vt_blldal.search_KhoangGia(giabd, giakt);
                        }

                        break;
                    }
            }
        }

        private void dgv_VatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_VatTu.Rows[e.RowIndex];
            txt_Ma.Text = row.Cells[0].Value.ToString();
            var data = (byte[])(row.Cells[1].Value);
            var stream = new MemoryStream(data);
            pic_Image.Image = Image.FromStream(stream);
            txt_TenVT.Text = row.Cells[2].Value.ToString();
            txt_GiaVT.Text = row.Cells[3].Value.ToString();
            txt_SL.Text = row.Cells[4].Value.ToString();
            txt_DVT.Text = row.Cells[5].Value.ToString();
            txt_ThgHieu.Text = row.Cells[6].Value.ToString();
        }

        private void btn_UpImage_Click(object sender, EventArgs e)
        {
            ba.UpLoadImage(pic_Image);
        }
    }
}