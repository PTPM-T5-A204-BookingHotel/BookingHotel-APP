using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class VatTu_BLL_DAL
    {
        public VatTu_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();

        public void getVTs(DataGridView dgv)
        {
            var VTs = from VT in qlks.VatTus select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu,VT.GiaNhap };
            dgv.DataSource = VTs;
        }
        public void getVT_DatPhong(DataGridView dgv)
        {
            var VTs = from VT in qlks.VatTus select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh };
            dgv.DataSource = VTs;
        }
        public void search(string value, DataGridView dgv)
        {
            var kq = from VT in qlks.VatTus
                     where VT.TenVT.Contains(value)
                     select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh };
            dgv.DataSource = kq;
        }
        public int isMaVT(string maVT)
        {
            var kq = qlks.VatTus.Where(o => o.MaVT.Equals(maVT)).Count();
            return kq;
        }
        public void insert(string maVT, string tenVT, string dvt, string thuonghieu, int soluong, int dongia, int gianhap, string Anh)
        {
            VatTu VT = new VatTu();
            VT.MaVT = maVT;
            VT.TenVT = tenVT;
            VT.DonViTinh = dvt;
            VT.ThuongHieu = thuonghieu;
            VT.SoLuong = soluong;
            VT.DonGia = dongia;
            VT.GiaNhap = gianhap;
            VT.AnhVT = Anh;
            qlks.VatTus.InsertOnSubmit(VT);
            qlks.SubmitChanges();
        }
        public void delete(string maVT)
        {
            VatTu VT = qlks.VatTus.Where(o => o.MaVT.Equals(maVT)).FirstOrDefault();
            if (VT != null)
            {
                qlks.VatTus.DeleteOnSubmit(VT);
                qlks.SubmitChanges();
            }
        }
        public void update(string maVT, string tenVT, string dvt, string thuonghieu, int soluong, int dongia, int gianhap, string Anh)
        {
            VatTu VT = qlks.VatTus.Where(o => o.MaVT.Equals(maVT)).FirstOrDefault();
            if (VT != null)
            {
                VT.TenVT = tenVT;
                VT.DonViTinh = dvt;
                VT.ThuongHieu = thuonghieu;
                VT.SoLuong = soluong;
                VT.DonGia = dongia;
                VT.GiaNhap = gianhap;
                VT.AnhVT = Anh;
                qlks.SubmitChanges();
            }
        }
        public string getAnh(string mavt)
        {
            var kq = from vt in qlks.VatTus where vt.MaVT.Equals(mavt) select vt.AnhVT;
            return kq.FirstOrDefault();
        }
        public void search(int searchType, string value, DataGridView dgv)
        {
            var kq = from VT in qlks.VatTus where VT.TenVT.Contains(value) select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu, VT.GiaNhap };
            switch (searchType)
            {
                case 0: kq = from VT in qlks.VatTus where VT.TenVT.Contains(value) select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu, VT.GiaNhap }; break;
                case 1: kq = from VT in qlks.VatTus where VT.ThuongHieu.Contains(value) select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu, VT.GiaNhap }; break;
            }
            dgv.DataSource = kq;
        }
        public void MaxGia(DataGridView dgv)
        {
            var maxgia = (from dv in qlks.VatTus select dv).Max(o => o.DonGia);
            var kq = from s in qlks.VatTus where s.DonGia.Equals(maxgia) select new { s.MaVT, s.TenVT, s.DonGia, s.SoLuong, s.DonViTinh, s.ThuongHieu, s.GiaNhap };
            dgv.DataSource = kq;
        }
        public void MinGia(DataGridView dgv)
        {
            var mingia = (from dv in qlks.VatTus select dv).Min(o => o.DonGia);
            var kq = from s in qlks.VatTus where s.DonGia.Equals(mingia) select new { s.MaVT, s.TenVT, s.DonGia, s.SoLuong, s.DonViTinh, s.ThuongHieu, s.GiaNhap };
            dgv.DataSource = kq;
        }
        public void sort(int sortType, DataGridView dgv)
        {
            var kq = from VT in qlks.VatTus orderby VT.TenVT ascending select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu, VT.GiaNhap };
            switch (sortType)
            {
                case 0: kq = from VT in qlks.VatTus orderby VT.TenVT ascending select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu, VT.GiaNhap }; break;
                case 1: kq = from VT in qlks.VatTus orderby VT.DonGia ascending, VT.SoLuong descending select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu, VT.GiaNhap }; break;
                case 2: kq = from VT in qlks.VatTus orderby VT.DonGia descending, VT.SoLuong ascending select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu, VT.GiaNhap }; break;
            }
            dgv.DataSource = kq;
        }
        public void search_KhoangGia(int giabd, int giakt, DataGridView dgv)
        {
            var kq = from VT in qlks.VatTus where VT.DonGia >= giabd && VT.DonGia <= giakt select new { VT.MaVT, VT.TenVT, VT.DonGia, VT.SoLuong, VT.DonViTinh, VT.ThuongHieu, VT.GiaNhap };

            dgv.DataSource = kq;
        }
    }
}
