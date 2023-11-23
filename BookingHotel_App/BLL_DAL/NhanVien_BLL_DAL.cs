using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class NhanVien_BLL_DAL
    {
        public NhanVien_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public void getNVs(DataGridView dgv)
        {
            var NVs = from NV in qlks.NhanViens select new { NV.CCCDNV, NV.HoTenNV, NV.GioiTinhNV, NV.SoDienThoaiNV, NV.NgaySinhNV, NV.DiaChiNV,NV.EmailNV };
            dgv.DataSource = NVs;
        }
        public int isCCCD(string cccd)
        {
            var kq = qlks.NhanViens.Where(o => o.CCCDNV.Equals(cccd)).Count();
            return kq;
        }
        public int getMaNV(string cccd)
        {
            var kq = from NV in qlks.NhanViens where NV.CCCDNV.Equals(cccd) select NV.MaNV;
            return kq.FirstOrDefault();
        }
        public void insert(string cccd, string hoten, string gt, string sdt, DateTime ngaysinh, string diachi,string anh,string email,int macv)
        {
            NhanVien NV = new NhanVien();
            NV.CCCDNV = cccd;
            NV.HoTenNV = hoten;
            NV.GioiTinhNV = gt;
            NV.SoDienThoaiNV = sdt;
            NV.NgaySinhNV = ngaysinh;
            NV.DiaChiNV = diachi;
            NV.AnhNV = anh;
            NV.EmailNV = email;
            NV.MaCV = macv;
            qlks.NhanViens.InsertOnSubmit(NV);
            qlks.SubmitChanges();
        }
        public void delete(int maNV)
        {
            NhanVien NV = qlks.NhanViens.Where(o => o.MaNV.Equals(maNV)).FirstOrDefault();
            if (NV != null)
            {
                qlks.NhanViens.DeleteOnSubmit(NV);
                qlks.SubmitChanges();
            }
        }
        public void update(int manv,string cccd, string hoten, string gt, string sdt, DateTime ngaysinh, string diachi, string anh, string email, int macv)
        {
            NhanVien NV = qlks.NhanViens.Where(o => o.MaNV.Equals(manv)).FirstOrDefault();
            if (NV != null)
            {
                NV.CCCDNV = cccd;
                NV.HoTenNV = hoten;
                NV.GioiTinhNV = gt;
                NV.SoDienThoaiNV = sdt;
                NV.NgaySinhNV = ngaysinh;
                NV.DiaChiNV = diachi;
                NV.AnhNV = anh;
                NV.EmailNV = email;
                NV.MaCV = macv;
                qlks.SubmitChanges();
            }
        }
        public string getAnh(string maNV)
        {
            var kq = from NV in qlks.NhanViens where NV.MaNV.Equals(maNV) select NV.AnhNV;
            return kq.FirstOrDefault();
        }
        public void search(int searchtype,string value,DataGridView dgv)
        {
            var kq  = from NV in qlks.NhanViens where NV.CCCDNV.Contains(value) select new { NV.CCCDNV, NV.HoTenNV, NV.GioiTinhNV, NV.SoDienThoaiNV, NV.NgaySinhNV, NV.DiaChiNV, NV.EmailNV };
            switch (searchtype)
            {
                case 0: kq = from NV in qlks.NhanViens where NV.CCCDNV.Contains(value) select new { NV.CCCDNV, NV.HoTenNV, NV.GioiTinhNV, NV.SoDienThoaiNV, NV.NgaySinhNV, NV.DiaChiNV, NV.EmailNV }; break;
                case 1: kq = from NV in qlks.NhanViens where NV.HoTenNV.Contains(value) select new { NV.CCCDNV, NV.HoTenNV, NV.GioiTinhNV, NV.SoDienThoaiNV, NV.NgaySinhNV, NV.DiaChiNV, NV.EmailNV }; break;
                case 2: kq = from NV in qlks.NhanViens where NV.GioiTinhNV.Equals(value) select new { NV.CCCDNV, NV.HoTenNV, NV.GioiTinhNV, NV.SoDienThoaiNV, NV.NgaySinhNV, NV.DiaChiNV, NV.EmailNV }; break;
            }
            dgv.DataSource = kq;
        }
        public void sort(DataGridView dgv)
        {
            var kq = from NV in qlks.NhanViens orderby NV.HoTenNV ascending, NV.CCCDNV descending select new { NV.CCCDNV, NV.HoTenNV, NV.GioiTinhNV, NV.SoDienThoaiNV, NV.NgaySinhNV, NV.DiaChiNV, NV.EmailNV };
            dgv.DataSource = kq;
        }
        public NhanVien getNV(int manv)
        {
            var kq = from NV in qlks.NhanViens where NV.MaNV.Equals(manv) select NV;
            return kq.FirstOrDefault();
        }
    }
}
