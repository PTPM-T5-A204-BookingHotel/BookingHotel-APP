using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class HoaDon_DichVu_BLL_DAL
    {
        public HoaDon_DichVu_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();

        public int isHDDV(string mahd,string madv)
        {
            var kq = qlks.HoaDon_DichVus.Where(o => o.MaHD.Equals(mahd) && o.MaDV.Equals(madv)).Count();
            return kq;
        }
        public List<HoaDon_DichVu> getHDDVs(string mahd)
        {
            var kq = from hddv in qlks.HoaDon_DichVus where hddv.MaHD.Equals(mahd) select hddv;
            return kq.ToList();
        }
        public void getHDDVs(DataGridView dgv,string mahd)
        {

            var kq = from hddv in qlks.HoaDon_DichVus where hddv.MaHD.Equals(mahd)
                     join dv in qlks.DichVus on hddv.MaDV equals dv.MaDV
                     select new { hddv.MaDV,dv.TenDV, dv.GiaDV, hddv.SoLuongDV, hddv.ThanhTienDV };
            dgv.DataSource = kq;
        }
        public int TinhThanhTien(int giadv,int soluongdv)
        {
            return giadv * soluongdv;
        }
        public int TongThanhTien(string mahd)
        {
            var kq = from hddv in qlks.HoaDon_DichVus where hddv.MaHD.Equals(mahd) select hddv.ThanhTienDV;
            return kq.Sum().Value;
        }
        public void insert(string mahd,string madv,int soluongdv,int thanhtien)
        {
            HoaDon_DichVu hddv = new HoaDon_DichVu();
            hddv.MaHD = mahd;
            hddv.MaDV = madv;
            hddv.SoLuongDV = soluongdv;
            hddv.ThanhTienDV=thanhtien;
            qlks.HoaDon_DichVus.InsertOnSubmit(hddv);
            qlks.SubmitChanges();
        }
        public void update(string mahd,string madv,int soluongdv, int thanhtien)
        {
            HoaDon_DichVu hddv = qlks.HoaDon_DichVus.Where(o => o.MaHD.Equals(mahd) && o.MaDV.Equals(madv)).FirstOrDefault();
            if(hddv != null)
            {
                hddv.SoLuongDV = soluongdv;
                hddv.ThanhTienDV = thanhtien;
                qlks.SubmitChanges();
            }
        }
        public void delete(string mahd, string madv)
        {
            HoaDon_DichVu hddv = qlks.HoaDon_DichVus.Where(o => o.MaHD.Equals(mahd) && o.MaDV.Equals(madv)).FirstOrDefault();
            if (hddv != null)
            {
                qlks.HoaDon_DichVus.DeleteOnSubmit(hddv);
                qlks.SubmitChanges();
            }
        }
        public void deleteAllHD(string mahd)
        {
            HoaDon_DichVu hddv = qlks.HoaDon_DichVus.Where(o => o.MaHD.Equals(mahd)).FirstOrDefault();
            if (hddv != null)
            {
                qlks.HoaDon_DichVus.DeleteOnSubmit(hddv);
                qlks.SubmitChanges();
            }
        }
    }
}
