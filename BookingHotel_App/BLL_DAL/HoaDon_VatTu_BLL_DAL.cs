using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class HoaDon_VatTu_BLL_DAL
    {
        public HoaDon_VatTu_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public void getHDVTs(DataGridView dgv, string mahd)
        {

            var kq = from hdvt in qlks.HoaDon_VatTus
                     where hdvt.MaHD.Equals(mahd)
                     join vt in qlks.VatTus on hdvt.MaVT equals vt.MaVT
                     select new { hdvt.MaVT,vt.TenVT, vt.DonGia, hdvt.SoLuongVT, hdvt.ThanhTienVT };
            dgv.DataSource = kq;
        }
        public HoaDon_VatTu getHDVT(string mahd,string mavt)
        {
            var kq = qlks.HoaDon_VatTus.Where(o => o.MaHD.Equals(mahd) && o.MaVT.Equals(mavt)).FirstOrDefault();
            return kq;
        }
        public List<HoaDon_VatTu> getHDVTs(string mahd)
        {
            var kq = from hdvt in qlks.HoaDon_VatTus where hdvt.MaHD.Equals(mahd) select hdvt;
            return kq.ToList();
        }
        public int TinhThanhTien(int giavt, int soluongvt)
        {
            return giavt * soluongvt;
        }
        public int TongThanhTien(string mahd)
        {
            var kq = from hdvt in qlks.HoaDon_VatTus where hdvt.MaHD.Equals(mahd) select hdvt.ThanhTienVT;
            return kq.Sum().Value;
        }
        public int isHDVT(string mahd, string mavt)
        {
            var kq = qlks.HoaDon_VatTus.Where(o => o.MaHD.Equals(mahd) && o.MaVT.Equals(mavt)).Count();
            return kq;
        }
        public void insert(string mahd, string mavt, int soluongvt, int thanhtien)
        {
            HoaDon_VatTu hdvt = new HoaDon_VatTu();
            hdvt.MaHD = mahd;
            hdvt.MaVT = mavt;
            hdvt.SoLuongVT = soluongvt;
            hdvt.ThanhTienVT = thanhtien;
            qlks.HoaDon_VatTus.InsertOnSubmit(hdvt);
            qlks.SubmitChanges();
        }
        public void update(string mahd, string mavt, int soluongvt,int thanhtien)
        {
            HoaDon_VatTu hdvt = qlks.HoaDon_VatTus.Where(o => o.MaHD.Equals(mahd) && o.MaVT.Equals(mavt)).FirstOrDefault();
            if (hdvt != null)
            {
                hdvt.SoLuongVT = soluongvt;
                hdvt.ThanhTienVT = thanhtien;
                qlks.SubmitChanges();
            }
        }
        public void delete(string mahd, string mavt)
        {
            HoaDon_VatTu hdvt = qlks.HoaDon_VatTus.Where(o => o.MaHD.Equals(mahd) && o.MaVT.Equals(mavt)).FirstOrDefault();
            if (hdvt != null)
            {
                qlks.HoaDon_VatTus.DeleteOnSubmit(hdvt);
                qlks.SubmitChanges();
            }
        }
        public void deleteAllHD(string mahd)
        {
            HoaDon_VatTu hdvt = qlks.HoaDon_VatTus.Where(o => o.MaHD.Equals(mahd)).FirstOrDefault();
            if (hdvt != null)
            {
                qlks.HoaDon_VatTus.DeleteOnSubmit(hdvt);
                qlks.SubmitChanges();
            }
        }
    }
}
