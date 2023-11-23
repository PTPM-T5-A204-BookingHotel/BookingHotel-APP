using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class Phong_BLL_DAL
    {
        public Phong_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public int isTenPhong(string tenph)
        {
            var kq = qlks.Phongs.Where(o => o.TenPH.Equals(tenph)).Count();
            return kq;
        }
        public int getMaPh(string tenph)
        {
            var kq = from ph in qlks.Phongs where ph.TenPH.Equals(tenph) select ph.MaPH;
            return kq.FirstOrDefault();
        }
        public Phong getPH(int maph)
        {
            var kq = from ph in qlks.Phongs where ph.MaPH.Equals(maph) select ph;
            return kq.FirstOrDefault();
        }
        public List<Phong> GetPhongs(int tang)
        {
            var kq = from ph in qlks.Phongs where ph.Tang.Equals(tang) select ph;
            return kq.ToList();
        }
        public void GetPhongs(DataGridView dgv)
        {
            var kq = from ph in qlks.Phongs select new {ph.MaPH,ph.TenPH,ph.MaLP,ph.TinhTrangPH,ph.Tang};
            dgv.DataSource = kq;
        }
        public void insert(string tenph,int malp,int tang)
        {
            Phong ph = new Phong();
            ph.TenPH = tenph;
            ph.MaLP=malp;
            ph.Tang=tang;
            ph.TinhTrangPH = "Trống";
            qlks.Phongs.InsertOnSubmit(ph);
            qlks.SubmitChanges();
        }
        public void update(int maph, string tenph, int malp, int tang)
        {
            Phong ph = qlks.Phongs.Where(o=>o.MaPH.Equals(maph)).FirstOrDefault();
            if (ph != null)
            {
                ph.TenPH = tenph;
                ph.MaLP=malp;
                ph.Tang=tang;
                qlks.SubmitChanges();
            }
        }
        public void delete(int maph)
        {
            Phong ph = qlks.Phongs.Where(o => o.MaPH.Equals(maph)).FirstOrDefault();
            if (ph != null)
            {
                qlks.Phongs.DeleteOnSubmit(ph);
                qlks.SubmitChanges();
            }
        }
        public List<int> getTang()
        {
            var kq = (from ph in qlks.Phongs select ph.Tang).Distinct();
            return kq.ToList();
        }
        public void search(int searchType,string value,DataGridView dgv)
        {
            var kq = from ph in qlks.Phongs where ph.MaLP.Equals(value) select new { ph.MaPH, ph.TenPH, ph.MaLP, ph.TinhTrangPH, ph.Tang };
            switch (searchType) 
            {
                case 0: kq = from ph in qlks.Phongs where ph.MaLP.Equals(value) select new { ph.MaPH, ph.TenPH, ph.MaLP, ph.TinhTrangPH, ph.Tang }; break;
                case 1: kq = from ph in qlks.Phongs where ph.TenPH.Contains(value) select new { ph.MaPH, ph.TenPH, ph.MaLP, ph.TinhTrangPH, ph.Tang }; break;
                case 2: kq = from ph in qlks.Phongs where ph.Tang.Equals(value) select new { ph.MaPH, ph.TenPH, ph.MaLP, ph.TinhTrangPH, ph.Tang }; break;
            }
            dgv.DataSource = kq;

        }
        public void sort(DataGridView dgv)
        {
            var kq = from ph in qlks.Phongs orderby ph.Tang ascending, ph.TenPH ascending select new { ph.MaPH, ph.TenPH, ph.MaLP, ph.TinhTrangPH, ph.Tang };
            dgv.DataSource = kq;
        }
    }
}
