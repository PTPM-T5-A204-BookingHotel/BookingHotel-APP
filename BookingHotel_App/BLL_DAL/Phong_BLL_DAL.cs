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
        public List<Phong> GetPhongs()
        {
            var kq = from ph in qlks.Phongs select ph;
            return kq.ToList();
        }
        public void insert(string tenph,string tinhtrangph,int malp,int tang)
        {
            Phong ph = new Phong();
            ph.TenPH = tenph;
            ph.TinhTrangPH = tinhtrangph;
            ph.MaLP=malp;
            ph.Tang=tang;
        }
        public void update(int maph, string tenph, string tinhtrangph, int malp, int tang)
        {
            Phong ph = qlks.Phongs.Where(o=>o.MaPH.Equals(maph)).FirstOrDefault();
            if (ph != null)
            {
                ph.TenPH = tenph;
                ph.TinhTrangPH = tinhtrangph;
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
        public List<Phong> search(int searchType,string value,DataGridView dgv)
        {
            var kq = from ph in qlks.Phongs where ph.MaLP.Equals(value) select ph;
            switch (searchType) 
            {
                case 0: kq = from ph in qlks.Phongs where ph.MaLP.Equals(value) select ph; break;
                case 1: kq = from ph in qlks.Phongs where ph.TinhTrangPH.Equals(value) select ph; break;
                case 2: kq = from ph in qlks.Phongs where ph.Tang.Equals(value) select ph; break;
            }
            return kq.ToList();

        }
        public List<Phong> sort(int sortType)
        {
            var kq = from ph in qlks.Phongs orderby ph.Tang ascending select ph;
            switch(sortType)
            {
                case 0: kq = from ph in qlks.Phongs orderby ph.Tang ascending select ph; break;
                case 1: kq = from ph in qlks.Phongs orderby ph.Tang descending select ph; break;
            }
            return kq.ToList();
        }
    }
}
