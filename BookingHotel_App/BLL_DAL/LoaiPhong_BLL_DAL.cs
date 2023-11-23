using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class LoaiPhong_BLL_DAL
    {
        public LoaiPhong_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public List<LoaiPhong> getLoaiPhs()
        {
            var kq = from lp in qlks.LoaiPhongs select lp;
            return kq.ToList();
        }
        public void getLoaiPhs(DataGridView dgv)
        {
            var kq = from lp in qlks.LoaiPhongs select new {lp.MaLP,lp.TenLP,lp.GiaPH};
            dgv.DataSource = kq;
        }
        public int isTenLP(string tenlp)
        {
            var kq = qlks.LoaiPhongs.Where(o=>o.TenLP.Equals(tenlp)).Count();
            return kq;
        }
        public string getAnh(string ma)
        {
            try
            {
                var kq = from lp in qlks.LoaiPhongs where lp.MaLP.Equals(ma) select lp.HinhLP;
                return kq.FirstOrDefault();
            }
            catch
            {
                return "";
            }
            
        }
        public string getTenlp(int mlp)
        {
            var kq = from lp in qlks.LoaiPhongs where lp.MaLP.Equals(mlp) select lp.TenLP;
            return kq.FirstOrDefault();
        }
        public string getGialp(int mlp)
        {
            var kq = from lp in qlks.LoaiPhongs where lp.MaLP.Equals(mlp) select lp.GiaPH;
            return kq.FirstOrDefault().ToString();
        }
        public void insert(string tenlp,int gia,string hinh)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.TenLP = tenlp;
            lp.GiaPH = gia;
            lp.HinhLP = hinh;
            qlks.LoaiPhongs.InsertOnSubmit(lp);
            qlks.SubmitChanges();
        }
        public void update(int malp, string tenlp, int gia,string hinh)
        {
            LoaiPhong lp = qlks.LoaiPhongs.Where(o=>o.MaLP.Equals(malp)).FirstOrDefault();
            if(lp != null)
            {
                lp.TenLP = tenlp;
                lp.GiaPH = gia;
                lp.HinhLP = hinh;
                qlks.SubmitChanges();
            }
        }
        public void delete(int malp)
        {
            LoaiPhong lp = qlks.LoaiPhongs.Where(o => o.MaLP.Equals(malp)).FirstOrDefault();
            if (lp != null)
            {
                qlks.LoaiPhongs.DeleteOnSubmit(lp);
                qlks.SubmitChanges();
            }
        }
        public void sort(DataGridView dgv)
        {
            var kq = from lp in qlks.LoaiPhongs orderby lp.GiaPH ascending select new { lp.MaLP, lp.TenLP, lp.GiaPH };
            dgv.DataSource = kq;
        }
        public void search(int searchType, string value, DataGridView dgv)
        {
            var kq = from lp in qlks.LoaiPhongs where lp.TenLP.Contains(value) select new { lp.MaLP, lp.TenLP, lp.GiaPH };
            switch(searchType)
            {
                case 0: kq = from lp in qlks.LoaiPhongs where lp.TenLP.Contains(value) select new { lp.MaLP, lp.TenLP, lp.GiaPH }; break;
                case 1: kq = from lp in qlks.LoaiPhongs where lp.GiaPH.Equals(value) select new { lp.MaLP, lp.TenLP, lp.GiaPH }; break;
            }
            dgv.DataSource = kq;
        }
    }
}
