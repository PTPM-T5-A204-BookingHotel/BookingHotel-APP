using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class KhachHang_BLL_DAL
    {
        public KhachHang_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();

        public void getKHs(DataGridView dgv)
        {
            var kq = from kh in qlks.KhachHangs select new { kh.CCCDKH, kh.HoTenKH, kh.GioiTinhKH, kh.SDTKH, kh.NgaySinhKH, kh.DiaChiKH, kh.EmailKH };
            dgv.DataSource = kq;
        }
        public void getKH_DatPhong(DataGridView dgv)
        {
            var kq = from kh in qlks.KhachHangs select new { kh.CCCDKH, kh.HoTenKH, kh.GioiTinhKH, kh.SDTKH };
            dgv.DataSource = kq;
        }
        public int getMaKH(string cccd)
        {
            var kq = from kh in qlks.KhachHangs where kh.CCCDKH.Equals(cccd) select kh.MaKH;
            return kq.FirstOrDefault();
        }
        public int isCCCD(string cccd)
        {
            var kq = qlks.KhachHangs.Where(o => o.CCCDKH.Equals(cccd)).Count();
            return kq;
        }
        public string getAnh(string makh)
        {
            var kq = from kh in qlks.KhachHangs where kh.MaKH.Equals(makh) select kh.AnhKH;
            return kq.FirstOrDefault();
        }
        public void insert(string cccd, string hoten, string gt, string sdt, DateTime ngaysinh, string diachi, string anh, string email)
        {
            KhachHang kh = new KhachHang();
            kh.CCCDKH = cccd;
            kh.HoTenKH = hoten;
            kh.GioiTinhKH = gt;
            kh.SDTKH = sdt;
            kh.NgaySinhKH= ngaysinh;
            kh.DiaChiKH = diachi;
            kh.AnhKH = anh;
            kh.EmailKH = email;
            qlks.KhachHangs.InsertOnSubmit(kh);
            qlks.SubmitChanges();
        }
        public void delete(int makh)
        {
            KhachHang kh = qlks.KhachHangs.Where(o => o.MaKH.Equals(makh)).FirstOrDefault();
            if (kh != null)
            {
                qlks.KhachHangs.DeleteOnSubmit(kh);
                qlks.SubmitChanges();
            }
        }
        public void update(int makh, string cccd, string hoten, string gt, string sdt, DateTime ngaysinh, string diachi, string anh, string email)
        {
            KhachHang kh = qlks.KhachHangs.Where(o => o.MaKH.Equals(makh)).FirstOrDefault();
            if (kh != null)
            {
                kh.CCCDKH = cccd;
                kh.HoTenKH = hoten;
                kh.GioiTinhKH = gt;
                kh.SDTKH = sdt;
                kh.NgaySinhKH = ngaysinh;
                kh.DiaChiKH = diachi;
                kh.AnhKH = anh;
                kh.EmailKH = email;
                qlks.SubmitChanges();
            }
        }
        public void search(string value, DataGridView dgv)
        {
            var kq = from kh in qlks.KhachHangs
                     where kh.CCCDKH.Contains(value)
                     select new { kh.CCCDKH, kh.HoTenKH, kh.GioiTinhKH, kh.SDTKH };
            dgv.DataSource = kq;
        }
        public void search(int searchtype, string value, DataGridView dgv)
        {
            var kq = from kh in qlks.KhachHangs where kh.CCCDKH.Contains(value) select new { kh.CCCDKH, kh.HoTenKH, kh.GioiTinhKH, kh.SDTKH, kh.NgaySinhKH, kh.DiaChiKH, kh.EmailKH };
            switch (searchtype)
            {
                case 0: kq = from kh in qlks.KhachHangs where kh.CCCDKH.Contains(value) select new { kh.CCCDKH, kh.HoTenKH, kh.GioiTinhKH, kh.SDTKH, kh.NgaySinhKH, kh.DiaChiKH, kh.EmailKH }; break;
                case 1: kq = from kh in qlks.KhachHangs where kh.HoTenKH.Contains(value) select new { kh.CCCDKH, kh.HoTenKH, kh.GioiTinhKH, kh.SDTKH, kh.NgaySinhKH, kh.DiaChiKH, kh.EmailKH }; break;
                case 2: kq = from kh in qlks.KhachHangs where kh.GioiTinhKH.Equals(value) select new { kh.CCCDKH, kh.HoTenKH, kh.GioiTinhKH, kh.SDTKH, kh.NgaySinhKH, kh.DiaChiKH, kh.EmailKH }; break;
            }
            dgv.DataSource = kq;
        }
        public void sort(DataGridView dgv)
        {
            var kq = from kh in qlks.KhachHangs orderby kh.HoTenKH ascending, kh.CCCDKH descending select new { kh.CCCDKH, kh.HoTenKH, kh.GioiTinhKH, kh.SDTKH, kh.NgaySinhKH, kh.DiaChiKH, kh.EmailKH };
            dgv.DataSource = kq;
        }
        public KhachHang getKH(int makh)
        {
            var kq = from kh in qlks.KhachHangs where kh.MaKH.Equals(makh) select kh;
            return kq.FirstOrDefault();
        }
    }
}
