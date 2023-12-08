using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class HoaDon_BLL_DAL
    {
        public HoaDon_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public string CreateMaHD()
        {
            string mahd = "";
            for (int i = 0; i < 1000000; i++)
            {
                mahd = "HD"+ (i + 1);
                var kq = qlks.HoaDons.Where(o => o.MaHD.Equals(mahd)).Count();
                if (kq == 0)
                    break;
            }
            return mahd;
        }
        public bool KTTGDatPhong(DateTime dt,int maph)
        {
            foreach(HoaDon hd in getListHD(maph))
            {
                for (int i = 0; i < hd.SoNgayLuuTru.Value; i++)
                {
                    if (hd.TGDatPhong.Value.AddDays(i) == dt)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }
        public List<HoaDon> getListHD(int maph)
        {
            var kq = qlks.HoaDons.Where(o => o.MaPH.Equals(maph) && o.TinhTrangHD.Equals("Chưa thanh toán"));
            return kq.ToList();
        }
        public HoaDon getHD(string mahd)
        {
            var kq = from hd in qlks.HoaDons where hd.MaHD.Equals(mahd) select hd;
            return kq.FirstOrDefault();
        }
        public void getHDs(DataGridView dgv)
        {
            var kq = from hd in qlks.HoaDons
                     join ph in qlks.Phongs on hd.MaPH equals ph.MaPH
                     join kh in qlks.KhachHangs on hd.MaKH equals kh.MaKH
                     select new
                     {
                         hd.MaHD,
                         hd.TongTien,
                         hd.TinhTrangHD,
                         ph.TenPH,
                         kh.CCCDKH,
                         hd.TenTK,
                         hd.TGTraPhong
                     };
            dgv.DataSource = kq;
        }
        public void getHD_DatPhong(DataGridView dgv,string tenph)
        {
            var kq = from hd in qlks.HoaDons
                     join ph in qlks.Phongs on hd.MaPH equals ph.MaPH
                     join kh in qlks.KhachHangs on hd.MaKH equals kh.MaKH
                     where hd.TinhTrangHD.Equals("Chưa thanh toán") && ph.TenPH.Equals(tenph)
                     orderby hd.TGDatPhong descending
                     select new
                     {
                         hd.MaHD,
                         hd.TongTien,
                         kh.HoTenKH,
                         kh.CCCDKH,
                         kh.SDTKH,
                         hd.TGNhanPhong
                     };
            dgv.DataSource = kq;
        }
        public int CalTongTien(int giaph, int soNgayLuutru)
        {
            return giaph * soNgayLuutru;
        }
        public void DatPhong(string mahd,int makh,int maph,string tentk,DateTime tgdp,int soNgayLuuTru,int SoLuongNg,int TongTien)
        {
            HoaDon hd = new HoaDon();
            hd.MaHD = mahd;
            hd.MaKH = makh;
            hd.MaPH = maph;
            hd.TenTK = tentk;
            hd.TGDatPhong = tgdp;
            hd.SoNgayLuuTru = soNgayLuuTru;
            hd.SoLuongNguoi = SoLuongNg;
            hd.TongTien = TongTien;
            hd.TinhTrangHD = "Chưa thanh toán";
            qlks.HoaDons.InsertOnSubmit(hd);
            qlks.SubmitChanges();
        }
        public void delete(string mahd)
        {
            HoaDon hd = qlks.HoaDons.Where(o => o.MaHD.Equals(mahd)).FirstOrDefault();
            if (hd != null)
            {
                qlks.HoaDons.DeleteOnSubmit(hd);
                qlks.SubmitChanges();
            }
        }
        public void update(string mahd,int TongTien)
        {
            HoaDon hd = qlks.HoaDons.Where(o => o.MaHD.Equals(mahd)).FirstOrDefault();
            if (hd != null)
            {
                hd.TongTien = TongTien;
                qlks.SubmitChanges();
            }
        }
        public void update(string mahd,DateTime tgdp, int soNgayLuuTru, int SoLuongNg,int TongTien)
        {
            HoaDon hd = qlks.HoaDons.Where(o => o.MaHD.Equals(mahd)).FirstOrDefault();
            if (hd != null)
            {
                hd.TGDatPhong = tgdp;
                hd.SoNgayLuuTru = soNgayLuuTru;
                hd.SoLuongNguoi = SoLuongNg;
                hd.TongTien = TongTien;
                qlks.SubmitChanges();
            }
        }
        public void NhanPhong(string mahd,DateTime tgnp)
        {
            HoaDon hd = qlks.HoaDons.Where(o => o.MaHD.Equals(mahd)).FirstOrDefault();
            if(hd != null)
            {
                hd.TGNhanPhong = tgnp;
                qlks.SubmitChanges();
            }
        }
        public void TraPhong(string mahd,DateTime tgtp)
        {
            HoaDon hd = qlks.HoaDons.Where(o => o.MaHD.Equals(mahd)).FirstOrDefault();
            if (hd != null)
            {
                hd.TGTraPhong = tgtp;
                hd.TinhTrangHD = "Đã thanh toán";
                qlks.SubmitChanges();
            }

        }
        public void update(string mahd, string tt)
        {
            HoaDon hd = qlks.HoaDons.Where(o => o.MaHD.Equals(mahd)).FirstOrDefault();
            if (hd != null)
            {
                hd.TinhTrangHD = tt;
                qlks.SubmitChanges();
            }

        }
        public void Search(DataGridView dgv, int chon,string value)
        {
            var kq = from hd in qlks.HoaDons
                     join ph in qlks.Phongs on hd.MaPH equals ph.MaPH
                     join kh in qlks.KhachHangs on hd.MaKH equals kh.MaKH
                     where hd.MaPH.Equals(value)
                     select new
                     {
                         hd.MaHD,
                         hd.TongTien,
                         hd.TinhTrangHD,
                         ph.TenPH,
                         kh.CCCDKH,
                         hd.TenTK,
                         hd.TGTraPhong
                     };
            switch (chon)
            {
                case 0:
                    kq = from hd in qlks.HoaDons
                         join ph in qlks.Phongs on hd.MaPH equals ph.MaPH
                         join kh in qlks.KhachHangs on hd.MaKH equals kh.MaKH
                         where hd.MaPH.Equals(value)
                         select new
                         {
                             hd.MaHD,
                             hd.TongTien,
                             hd.TinhTrangHD,
                             ph.TenPH,
                             kh.CCCDKH,
                             hd.TenTK,
                             hd.TGTraPhong
                         };
                    break;
                case 1:
                    kq = from hd in qlks.HoaDons
                         join ph in qlks.Phongs on hd.MaPH equals ph.MaPH
                         join kh in qlks.KhachHangs on hd.MaKH equals kh.MaKH
                         where kh.CCCDKH.Contains(value)
                         select new
                         {
                             hd.MaHD,
                             hd.TongTien,
                             hd.TinhTrangHD,
                             ph.TenPH,
                             kh.CCCDKH,
                             hd.TenTK,
                             hd.TGTraPhong
                         };
                    break;
            }
            dgv.DataSource = kq;
        }
        public void sort(DataGridView dgv)
        {
            var kq = from hd in qlks.HoaDons
                     join ph in qlks.Phongs on hd.MaPH equals ph.MaPH
                     join kh in qlks.KhachHangs on hd.MaKH equals kh.MaKH
                     orderby hd.TGTraPhong descending
                     select new
                     {
                         hd.MaHD,
                         hd.TongTien,
                         hd.TinhTrangHD,
                         ph.TenPH,
                         kh.CCCDKH,
                         hd.TenTK,
                         hd.TGTraPhong
                     };
            dgv.DataSource = kq;
        }
    }
}
