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
       
        public List<Quyen> GetQuyens()
        {
            var kq = from q in qlks.Quyens where !q.MaQuyen.Equals("Owner") select q;
            return kq.ToList();
        }
    }
}
