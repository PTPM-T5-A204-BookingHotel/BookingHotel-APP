using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Quyen_BLL_DAL
    {
        public Quyen_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public int isMaQuyen(string maquyen)
        {
            var kq = qlks.Quyens.Where(o=>o.MaQuyen.Equals(maquyen)).Count();
            return kq;
        }
        public List<Quyen> GetQuyens()
        {
            var kq = from q in qlks.Quyens select q;
            return kq.ToList();
        }
        public void insert(string maquyen,string tenquyen)
        {
            Quyen q = new Quyen();
            q.MaQuyen = maquyen;
            q.TenQuyen = tenquyen;
            qlks.Quyens.InsertOnSubmit(q);
            qlks.SubmitChanges();
        }
        public void update(string maquyen, string tenquyen)
        {
            Quyen q = qlks.Quyens.Where(o => o.MaQuyen.Equals(maquyen)).FirstOrDefault();
            if (q != null)
            {
                q.TenQuyen = tenquyen;
                qlks.SubmitChanges();
            }
        }
        public void delete(string maquyen)
        {
            Quyen q = qlks.Quyens.Where(o=>o.MaQuyen.Equals (maquyen)).FirstOrDefault();
            if (q != null)
            {
                qlks.Quyens.DeleteOnSubmit(q);
                qlks.SubmitChanges();
            }
        }
    }
}
