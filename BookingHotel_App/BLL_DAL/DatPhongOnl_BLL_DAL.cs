using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class DatPhongOnl_BLL_DAL
    {
        public DatPhongOnl_BLL_DAL() { }
        QLKhachSanDataContext qlks = new QLKhachSanDataContext();
        public void getDPs(DataGridView dgv)
        {
            var kq = from dp in qlks.DatPhongs
                     orderby dp.TinhtrangDP descending
                     select new { dp.MaDP, dp.SoLuongNg, dp.TinhtrangDP, dp.SoLuongTGoLai, dp.ThoiGianNhanPhong, dp.Email, dp.Hoten };
            dgv.DataSource = kq;
        }
        public void Update(int madp)
        {
            DatPhong dp = qlks.DatPhongs.Where(o => o.MaDP.Equals(madp)).FirstOrDefault();
            if(dp!=null)
            {
                dp.TinhtrangDP = "Đã Check";
                qlks.SubmitChanges();
            }
        }
    }
}
