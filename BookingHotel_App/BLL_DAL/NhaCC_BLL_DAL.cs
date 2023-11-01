using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NhaCC_BLL_DAL
    {
        public NhaCC_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public List<NhaCC> getNhaCCs()
        {
            var kq = from n in qlks.NhaCCs select n;
            return kq.ToList();
        }
        public int isMaNCC(string ma)
        {
            var kq = qlks.NhaCCs.Where(o => o.MaNCC == ma).Count();
            return kq;
        }
        public void insert(string ma,string ten,string diachi,string sdt)
        {
            NhaCC ncc = new NhaCC();
            ncc.MaNCC = ma;
            ncc.TenNCC = ten;
            ncc.DiaChiNCC = diachi;
            ncc.SDTNCC = sdt;
            qlks.NhaCCs.InsertOnSubmit(ncc);
            qlks.SubmitChanges();
        }
        public void delete(string ma)
        {
            NhaCC ncc = qlks.NhaCCs.Where(o=>o.MaNCC == ma).FirstOrDefault();
            if(ncc != null)
            {
                qlks.NhaCCs.DeleteOnSubmit(ncc);
                qlks.SubmitChanges();
            }
        }
        public void update(string ma, string ten, string diachi, string sdt)
        {
            NhaCC ncc = qlks.NhaCCs.Where(o => o.MaNCC == ma).FirstOrDefault();
            if(ncc != null)
            {
                ncc.TenNCC = ten;
                ncc.DiaChiNCC = diachi;
                ncc.SDTNCC = sdt;
                qlks.SubmitChanges();
            }       
        }
        public List<NhaCC> search(int searchType,string value)
        {
            var kq = from n in qlks.NhaCCs where n.TenNCC.Contains(value) select n;
            switch(searchType)
            {
                case 0: kq = from n in qlks.NhaCCs where n.TenNCC.Contains(value) select n; break;
                case 1: kq = from n in qlks.NhaCCs where n.SDTNCC.Contains(value) select n; break;
            }
            return kq.ToList();
        }
        public List<NhaCC> sort()
        {
            var kq = from n in qlks.NhaCCs orderby n.TenNCC ascending, n.SDTNCC descending select n;
            return kq.ToList();
        }
    }
}
