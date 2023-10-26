using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ChucVu_BLL_DAL
    {
        public ChucVu_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();

        public List<ChucVu> getCVs()
        {
            var Cvs = from cv in qlks.ChucVus select cv;
            return Cvs.ToList();
        }
        public void insert(string tencv)
        {
            ChucVu cv = new ChucVu();
            cv.TenCV = tencv;
            qlks.ChucVus.InsertOnSubmit(cv);
            qlks.SubmitChanges();
        }
        public void delete(int macv)
        {
            ChucVu cv = qlks.ChucVus.Where(o => o.MaCV.Equals(macv)).FirstOrDefault();
            if (cv != null)
            {
                qlks.ChucVus.DeleteOnSubmit(cv);
                qlks.SubmitChanges();
            }
        }
        
    }
}
