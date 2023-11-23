using BLL_DAL;
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
        TaiKhoan_BLL_DAL tkblldal = new TaiKhoan_BLL_DAL();
        UC_DanhSachNV ucDSNV;
        UC_DanhSachKH ucDSKH;
        UC_DichVu ucdv;
        UC_VatTu ucvt;
        UC_DanhSachTK ucDSTK;
        UC_DanhSachHD ucDSHD;
        UC_NhaCC ucncc;
        UC_TaiKhoan uctk;
        UC_DanhSachPhong ucDSP;
        UC_DatPhongOnline ucDPOnl;
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
                ucDSTK.setTenTK(barStaticItem_TenTK.Caption);
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

        private void ace_Phong_Click(object sender, EventArgs e)
        {
            if (ucDSP == null)
            {
                ucDSP = new UC_DanhSachPhong();
                ucDSP.setTenTK(barStaticItem_TenTK.Caption);
                ucDSP.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucDSP);
                ucDSP.BringToFront();
            }
            else
                ucDSP.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string quyen = tkblldal.getTK(barStaticItem_TenTK.Caption).MaQuyen;
            if(quyen == "User")
            {
                ace_NhanVien.Enabled = false;
                ace_DanhSachTK.Enabled = false;
                ace_NhaCC.Enabled = false;
                ace_DichVu.Enabled = false;
                ace_VatTu.Enabled = false;

            }
            
            if (ucDSP == null)
            {
                ucDSP = new UC_DanhSachPhong();
                ucDSP.setTenTK(barStaticItem_TenTK.Caption);
                ucDSP.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucDSP);
                ucDSP.BringToFront();
            }
            else
                ucDSP.BringToFront();
        }

        private void ace_DatPHOnl_Click(object sender, EventArgs e)
        {
            if (ucDPOnl == null)
            {
                ucDPOnl = new UC_DatPhongOnline();
                ucDPOnl.setTenTK(barStaticItem_TenTK.Caption);
                ucDPOnl.Dock = DockStyle.Fill;
                MainContainer.Controls.Add(ucDPOnl);
                ucDPOnl.BringToFront();
            }
            else
                ucDPOnl.BringToFront();
        }
    }
}
