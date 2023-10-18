using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class VatTu_BLL_DAL
    {
        public VatTu_BLL_DAL() { }
        QLKHACHSANDataContext qlks = new QLKHACHSANDataContext();

        public List<VatTu> getVTs()
        {
            var VTs = from VT in qlks.VatTus select VT;
            return VTs.ToList();
        }
        public int isMaVT(string maVT)
        {
            var kq = qlks.VatTus.Where(o => o.MaVT.Equals(maVT)).Count();
            return kq;
        }
        public void insert(string maVT, string tenVT, string dvt,string thuonghieu,int soluong, int dongia, byte[] Anh)
        {
            VatTu VT = new VatTu();
            VT.MaVT = maVT;
            VT.TenVT = tenVT;
            VT.DonViTinh = dvt;
            VT.ThuongHieu = thuonghieu;
            VT.SoLuong = soluong;
            VT.DonGia = dongia;
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
        public void update(string maVT, string tenVT, string dvt, string thuonghieu, int soluong, int dongia, byte[] Anh)
        {
            VatTu VT = qlks.VatTus.Where(o => o.MaVT.Equals(maVT)).FirstOrDefault();
            if (VT != null)
            {
                VT.TenVT = tenVT;
                VT.DonViTinh = dvt;
                VT.ThuongHieu = thuonghieu;
                VT.SoLuong = soluong;
                VT.DonGia = dongia;
                VT.AnhVT = Anh;
                qlks.SubmitChanges();
            }
        }
        public List<VatTu> search(int searchType,string value)
        {
            var kq = from VT in qlks.VatTus where VT.TenVT.Contains(value) select VT;
            switch (searchType)
            {
                case 0: kq = from VT in qlks.VatTus where VT.TenVT.Contains(value) select VT; break;
                case 1: kq = from VT in qlks.VatTus where VT.ThuongHieu.Contains(value) select VT; break;
            }
            return kq.ToList();
        }
        public List<VatTu> MaxGia()
        {
            var maxgia = (from dv in qlks.VatTus select dv).Max(o => o.DonGia);
            var kq = from s in qlks.VatTus where s.DonGia.Equals(maxgia) select s;
            return kq.ToList();
        }
        public List<VatTu> MinGia()
        {
            var mingia = (from dv in qlks.VatTus select dv).Min(o => o.DonGia);
            var kq = from s in qlks.VatTus where s.DonGia.Equals(mingia) select s;
            return kq.ToList();
        }
        public List<VatTu> sort(int sortType)
        {
            var kq = from VT in qlks.VatTus orderby VT.TenVT ascending select VT;
            switch(sortType)
            {
                case 0: kq = from VT in qlks.VatTus orderby VT.TenVT ascending select VT; break;
                case 1: kq = from VT in qlks.VatTus orderby VT.DonGia ascending, VT.SoLuong descending select VT; break;
                case 2: kq = from VT in qlks.VatTus orderby VT.DonGia descending, VT.SoLuong ascending select VT; break;
            }
            return kq.ToList();
        }
        public List<VatTu> search_KhoangGia(int giabd, int giakt)
        {
            var kq = from VT in qlks.VatTus where VT.DonGia >= giabd && VT.DonGia<=giakt select VT;
            
            return kq.ToList();
        }
    }
}
