using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class TaiKhoan_BLL_DAL
    {
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public TaiKhoan_BLL_DAL() { }
        public int isTK(string tentk)
        {
            var kq = qlks.TaiKhoans.Where(o=>o.TenTK.Equals(tentk)).Count();
            return kq;
        }
        public void getTKs(DataGridView dgv,string quyen)
        {
            var kq = from tk in qlks.TaiKhoans 
                     select new {tk.TenTK,tk.MatKhau,tk.MaNV, tk.MaQuyen };
            switch (quyen)
            {
                case "Admin":
                    kq = from tk in qlks.TaiKhoans where tk.MaQuyen.Equals("User")
                         select new { tk.TenTK, tk.MatKhau, tk.MaNV, tk.MaQuyen };
                    break;
                case "Owner":
                    kq = from tk in qlks.TaiKhoans
                         where !tk.MaQuyen.Equals("Owner")
                         select new { tk.TenTK, tk.MatKhau, tk.MaNV, tk.MaQuyen };
                    break;
            }
            dgv.DataSource = kq;
        }
        public TaiKhoan getTK(string tentk)
        {
            var kq = from tk in qlks.TaiKhoans where tk.TenTK.Equals(tentk) select tk;
            return kq.FirstOrDefault();
        }
        public int isTK(string tentk,string matkhau)
        {
            var kq = qlks.TaiKhoans.Where(o => o.TenTK.Equals(tentk) && o.MatKhau.Equals(matkhau)).Count();
            return kq;
        }
        public void insert(string tentk,string matkhau,int manv,string maquyen,string anh)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenTK = tentk;
            tk.MaNV = manv;
            tk.MatKhau = matkhau;
            tk.MaQuyen = maquyen;
            tk.AnhTK = anh;
            qlks.TaiKhoans.InsertOnSubmit(tk);
            qlks.SubmitChanges();

        }
        public void update(string tentk, string matkhau, int manv, string maquyen, string anh)
        {
            TaiKhoan tk = qlks.TaiKhoans.Where(o => o.TenTK.Equals(tentk)).FirstOrDefault();
            if (tk != null)
            {
                tk.MatKhau = matkhau;
                tk.MaNV = manv;
                tk.MaQuyen = maquyen;
                tk.AnhTK = anh;
                qlks.SubmitChanges();
            }
        }
        public void update(string tentk, string matkhau,string anh)
        {
            TaiKhoan tk = qlks.TaiKhoans.Where(o => o.TenTK.Equals(tentk)).FirstOrDefault();
            if (tk != null)
            {
                tk.MatKhau = matkhau;
                tk.AnhTK = anh;
                qlks.SubmitChanges();
            }
        }
        public void delete(string tentk)
        {
            TaiKhoan tk = qlks.TaiKhoans.Where(o => o.TenTK.Equals(tentk)).FirstOrDefault();
            if (tk != null)
            {
                qlks.TaiKhoans.DeleteOnSubmit(tk);
                qlks.SubmitChanges();
            }
        }
        public string getAnh(string tentk)
        {
            var kq = from tk in qlks.TaiKhoans where tk.TenTK.Equals(tentk) select tk.AnhTK.ToString();
            return kq.FirstOrDefault();
        }
        public void search(int searchType,string value,DataGridView dgv)
        {
            var kq = from tk in qlks.TaiKhoans
                     join nv in qlks.NhanViens on tk.MaNV equals nv.MaNV
                     where tk.MaQuyen.Equals(value)
                     select new { tk.TenTK, tk.MatKhau, nv.HoTenNV, tk.MaQuyen };
            switch (searchType)
            {
                case 0:
                    kq = from tk in qlks.TaiKhoans
                         join nv in qlks.NhanViens on tk.MaNV equals nv.MaNV
                         where tk.MaQuyen.Equals(value)
                         select new { tk.TenTK, tk.MatKhau, nv.HoTenNV, tk.MaQuyen }; break;
                case 1:
                    kq = from tk in qlks.TaiKhoans
                         join nv in qlks.NhanViens on tk.MaNV equals nv.MaNV
                         where tk.MaQuyen.Contains(value)
                         select new { tk.TenTK, tk.MatKhau, nv.HoTenNV, tk.MaQuyen }; break;
            }
            dgv.DataSource = kq;
        }
        public void sort(DataGridView dgv)
        {
            var kq = from tk in qlks.TaiKhoans
                     join nv in qlks.NhanViens on tk.MaNV equals nv.MaNV
                     orderby tk.TenTK ascending,tk.MatKhau descending
                     select new { tk.TenTK, tk.MatKhau, nv.HoTenNV, tk.MaQuyen };
            dgv.DataSource = kq; 
        }
    }
}
