using BLL_DAL;
using BookingHotel_App.Report;
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
    public partial class frmInHD : DevExpress.XtraEditors.XtraForm
    {
        public frmInHD()
        {
            InitializeComponent();
        }
        KhachHang_BLL_DAL khblldal = new KhachHang_BLL_DAL();
        HoaDon_BLL_DAL hdblldal = new HoaDon_BLL_DAL();
        Phong_BLL_DAL phblldal = new Phong_BLL_DAL();
        LoaiPhong_BLL_DAL lphblldal = new LoaiPhong_BLL_DAL();
        HoaDon_DichVu_BLL_DAL hddvblldal = new HoaDon_DichVu_BLL_DAL();
        HoaDon_VatTu_BLL_DAL hdvtblldal = new HoaDon_VatTu_BLL_DAL();
        DichVu_BLL_DAL dvblldal = new DichVu_BLL_DAL();
        VatTu_BLL_DAL vtblldal = new VatTu_BLL_DAL();
        public void XuatHD(string mahd)
        {
            string kh = khblldal.getKH(int.Parse(hdblldal.getHD(mahd).MaKH.ToString())).HoTenKH;
            string ph = phblldal.getPH(int.Parse(hdblldal.getHD(mahd).MaPH.ToString())).TenPH;
            string tk = hdblldal.getHD(mahd).TenTK;
            int tongtien = hdblldal.getHD(mahd).TongTien.Value;
            DateTime dt = hdblldal.getHD(mahd).TGTraPhong.Value;
            int maph = hdblldal.getHD(mahd).MaPH;
            int malp = phblldal.getPH(maph).MaLP;
            int giaph = int.Parse(lphblldal.getGialp(malp));
            int songayluutru = hdblldal.getHD(mahd).SoNgayLuuTru.Value;
            List<DichVu_VatTu_InHD> list = new List<DichVu_VatTu_InHD>();
            if (hddvblldal.getHDDVs(mahd).Count > 0)
            {
                foreach(HoaDon_DichVu i in hddvblldal.getHDDVs(mahd))
                {
                    DichVu_VatTu_InHD t = new DichVu_VatTu_InHD();
                    t.ten = dvblldal.getDV(i.MaDV).TenDV;
                    t.gia = dvblldal.getDV(i.MaDV).GiaDV.Value;
                    t.soluong = i.SoLuongDV.Value;
                    t.thanhtien = i.ThanhTienDV.Value;
                    list.Add(t);
                }
            }
            if (hdvtblldal.getHDVTs(mahd).Count > 0)
            {
                foreach (HoaDon_VatTu i in hdvtblldal.getHDVTs(mahd))
                {
                    DichVu_VatTu_InHD t = new DichVu_VatTu_InHD();
                    t.ten = vtblldal.getVT(i.MaVT).TenVT;
                    t.gia = vtblldal.getVT(i.MaVT).DonGia.Value;
                    t.soluong = i.SoLuongVT.Value;
                    t.thanhtien = i.ThanhTienVT.Value;
                    list.Add(t);
                }
            }
            HoaDonReport reports = new HoaDonReport();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in reports.Parameters)
            {
                p.Visible = false;
            }
            reports.InitData(mahd, tk, dt, ph, kh,tongtien,giaph,list,songayluutru);
            documentViewer2.DocumentSource = reports;
            reports.CreateDocument();
        }
        
    }
}