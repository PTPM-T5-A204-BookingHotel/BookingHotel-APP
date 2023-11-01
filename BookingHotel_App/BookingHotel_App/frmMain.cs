using DesignControl;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookingHotel_App
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        UC_DanhSachNV ucDSNV;
        UC_DanhSachKH ucDSKH;
        UC_DichVu ucdv;
        UC_VatTu ucvt;
        UC_DanhSachTK ucDSTK;
        UC_DanhSachHD ucDSHD;
        UC_NhaCC ucncc;
        UC_TaiKhoan uctk;
        public void LoadData(string tentk)
        {
            barStaticItem_TenTK.Caption = tentk;
        }
        private void ace_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void ace_NhanVien_Click(object sender, EventArgs e)
        {
            if (ucDSNV == null)
            {
                ucDSNV = new UC_DanhSachNV();
                ucDSNV.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucDSNV);
                ucDSNV.BringToFront();
            }else
                ucDSNV.BringToFront();
        }

        private void ace_KhachHang_Click(object sender, EventArgs e)
        {
            if (ucDSKH == null)
            {
                ucDSKH = new UC_DanhSachKH();
                ucDSKH.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucDSKH);
                ucDSKH.BringToFront();
            }
            else
                ucDSKH.BringToFront();
        }

        private void ace_DichVu_Click(object sender, EventArgs e)
        {
            if (ucdv == null)
            {
                ucdv = new UC_DichVu();
                ucdv.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucdv);
                ucdv.BringToFront();
            }
            else
                ucdv.BringToFront();
        }

        private void ace_VatTu_Click(object sender, EventArgs e)
        {
            if (ucvt == null)
            {
                ucvt = new UC_VatTu();
                ucvt.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucvt);
                ucvt.BringToFront();
            }
            else
                ucvt.BringToFront();
        }

        private void ace_DanhSachTK_Click(object sender, EventArgs e)
        {
            if (ucDSTK == null)
            {
                ucDSTK = new UC_DanhSachTK();
                ucDSTK.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucDSTK);
                ucDSTK.BringToFront();
            }
            else
                ucDSTK.BringToFront();
        }

        private void ace_HoaDon_Click(object sender, EventArgs e)
        {
            if (ucDSHD == null)
            {
                ucDSHD = new UC_DanhSachHD();
                ucDSHD.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucDSHD);
                ucDSHD.BringToFront();
            }
            else
                ucDSHD.BringToFront();
        }

        private void ace_NhaCC_Click(object sender, EventArgs e)
        {
            if (ucncc == null)
            {
                ucncc = new UC_NhaCC();
                ucncc.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucncc);
                ucncc.BringToFront();
            }
            else
                ucncc.BringToFront();
        }

        private void ace_ThongTinTK_Click(object sender, EventArgs e)
        {
            if (ucncc == null)
            {
                uctk = new UC_TaiKhoan();
                uctk.Dock = DockStyle.Fill;
                uctk.Loaddata(barStaticItem_TenTK.Caption);
                MainContainer.Controls.Add(uctk);
                uctk.BringToFront();
            }
            else
                uctk.BringToFront();
        }
    }
}
