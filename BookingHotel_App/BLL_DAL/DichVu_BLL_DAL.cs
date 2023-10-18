using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DichVu_BLL_DAL
    {
        public DichVu_BLL_DAL() { }
        QLKHACHSANDataContext qlks = new QLKHACHSANDataContext();

        public List<DichVu> getDVs()
        {
            var Dvs = from dv in qlks.DichVus select dv;
            return Dvs.ToList();
        }
        public int isMaDV(string madv)
        {
            var kq = qlks.DichVus.Where(o=>o.MaDV.Equals(madv)).Count();
            return kq;
        }
        public void insert(string madv,string tendv,int giadv,string mota)
        {
            DichVu dv = new DichVu();
            dv.MaDV = madv;
            dv.TenDV = tendv;
            dv.GiaDV = giadv;
            dv.MotaDV = mota;
            qlks.DichVus.InsertOnSubmit(dv);
            qlks.SubmitChanges();
        }
        public void delete(string madv)
        {
            DichVu dv = qlks.DichVus.Where(o => o.MaDV.Equals(madv)).FirstOrDefault();
            if (dv!=null)
            {
                qlks.DichVus.DeleteOnSubmit(dv);
                qlks.SubmitChanges();
            }
        }
        public void update(string madv, string tendv, int giadv, string mota)
        {
            DichVu dv = qlks.DichVus.Where(o=>o.MaDV.Equals(madv)).FirstOrDefault();
            if (dv != null)
            {
                dv.TenDV = tendv;
                dv.GiaDV = giadv;
                dv.MotaDV = mota;
                qlks.SubmitChanges();
            }
        }
        public List<DichVu> search(string value)
        {
            var kq = from dv in qlks.DichVus where dv.TenDV.Contains(value) select dv;
            return kq.ToList();
        }
        public List<DichVu> MaxGiaDV()
        {
            var maxgia = (from dv in qlks.DichVus select dv).Max(o => o.GiaDV);
            var kq = from s in qlks.DichVus where s.GiaDV.Equals(maxgia) select s;
            return kq.ToList();
        }
        public List<DichVu> MinGiaDV()
        {
            var mingia = (from dv in qlks.DichVus select dv).Min(o => o.GiaDV);
            var kq = from s in qlks.DichVus where s.GiaDV.Equals(mingia) select s;
            return kq.ToList();
        }
        public List<DichVu> sort(int sortType)
        {
            var kq = from dv in qlks.DichVus orderby dv.TenDV ascending select dv;
            switch(sortType) 
            {
                case 0: kq = from dv in qlks.DichVus orderby dv.TenDV ascending select dv; break;
                case 1: kq = from dv in qlks.DichVus orderby dv.GiaDV ascending, dv.TenDV descending select dv; break;
                case 2: kq = from dv in qlks.DichVus orderby dv.GiaDV descending, dv.TenDV ascending select dv; break;
            }
            return kq.ToList();
        }
        public List<DichVu> search_KhoangGia(int giabd,int giakt)
        {
            var kq = from dv in qlks.DichVus where dv.GiaDV >= giabd && dv.GiaDV <= giakt select dv;
            return kq.ToList();
        }
    }
}
