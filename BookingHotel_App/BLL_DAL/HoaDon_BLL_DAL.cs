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
            string mahd = "HD";
            for (int i = 0; i < 1000000; i++)
            {
                mahd += (i + 1);
                var kq = qlks.HoaDons.Where(o => o.Equals(mahd)).Count();
                if (kq == 0)
                    break;
            }
            return mahd;
        }
        public List<HoaDon> getListHD(int maph)
        {
            var kq = qlks.HoaDons.Where(o => o.MaPH.Equals(maph) && o.TinhTrangHD.Equals("Chưa thanh toán"));
            return kq.ToList();
        }
        public void getHDs(DataGridView dgv)
        {
            var kq = from hd in qlks.HoaDons
                     join ph in qlks.Phongs on hd.MaPH equals ph.MaPH
                     join kh in qlks.KhachHangs on hd.MaKH equals kh.MaKH
                     select new
                     {
                         hd.MaHD,
                         hd.GiamGia,
                         hd.TongTien,
                         hd.ThanhTienHD,
                         hd.TinhTrangHD,
                         ph.TenPH,
                         kh.HoTenKH
                     };
            dgv.DataSource = kq;
        }
    }
}
