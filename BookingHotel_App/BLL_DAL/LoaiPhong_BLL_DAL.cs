using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void insert(string tenlp,int gia)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.TenLP = tenlp;
            lp.GiaPH = gia;
        }
        public void update(int malp, string tenlp, int gia)
        {
            LoaiPhong ph = qlks.LoaiPhongs.Where(o=>o.MaLP.Equals(malp)).FirstOrDefault();
            if(ph != null)
            {
                ph.TenLP = tenlp;
                ph.GiaPH = gia;
                qlks.SubmitChanges();
            }
        }
        public void delete(int malp)
        {
            LoaiPhong ph = qlks.LoaiPhongs.Where(o => o.MaLP.Equals(malp)).FirstOrDefault();
            if (ph != null)
            {
                qlks.LoaiPhongs.DeleteOnSubmit(ph);
                qlks.SubmitChanges();
            }
        }
    }
}
