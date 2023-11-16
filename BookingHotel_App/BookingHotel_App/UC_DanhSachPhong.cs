using BLL_DAL;
using DevExpress.Utils.Extensions;
using DevExpress.XtraRichEdit.Import.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingHotel_App
{
    public partial class UC_DanhSachPhong : UserControl
    {
        public UC_DanhSachPhong()
        {
            InitializeComponent();
        }
        Phong_BLL_DAL phblldal = new Phong_BLL_DAL();
        LoaiPhong_BLL_DAL lpblldal = new LoaiPhong_BLL_DAL();
        
        public void creatCbo_Tang()
        {
            foreach(int t in phblldal.getTang())
            {
                cbo_Tầng.Items.Add(t);
            }
            if (cbo_Tầng.Items.Count > 0)
            {
                cbo_Tầng.SelectedIndex = 0;
            }
        }
        
        public void removeAll()
        {
            this.pnl_Phong.Controls.Clear();
            
            //cardPhong = null;
        }
        public void LoadData(int tang)
        {
            int x = 10, y = 10;
            for (int i=0;i<phblldal.GetPhongs(tang).Count;i++)
            {
                UC_Phong ph = new UC_Phong();
                string tenph = phblldal.GetPhongs(tang)[i].TenPH;
                string ttph = phblldal.GetPhongs(tang)[i].TinhTrangPH;
                string tenlp = lpblldal.getTenlp(phblldal.GetPhongs(tang)[i].MaLP);
                ph.LoadData(tang, tenph, tenlp, ttph);
                
                this.pnl_Phong.Controls.Add(ph);
                if (i%2 == 0 && i != 0)
                {
                    y += ph.Height;
                    x = 10;
                }
                ph.Location = new Point(x, y);
                x += ph.Width;
            }
        }

        private void cbo_Tầng_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.pnl_Phong.Controls.Count > 0)
            {
                removeAll();
            }
            LoadData(int.Parse(cbo_Tầng.SelectedItem.ToString()));
        }

        private void tsBtn_TuyChinh_Click(object sender, EventArgs e)
        {
            frm_TuyChinhPhong frm = new frm_TuyChinhPhong();
            frm.ShowDialog();
        }

        private void UC_DanhSachPhong_Load(object sender, EventArgs e)
        {
            creatCbo_Tang();
        }
    }
}
