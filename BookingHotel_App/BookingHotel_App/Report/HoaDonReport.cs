using BLL_DAL;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace BookingHotel_App.Report
{
    public partial class HoaDonReport : DevExpress.XtraReports.UI.XtraReport
    {
        public HoaDonReport()
        {
            InitializeComponent();
        }
        
        
        public void InitData(string mahd,string thungan,DateTime dt,string ph,string kh,int tongtien,int GiaPH,List<DichVu_VatTu_InHD> data,int songayluutru)
        {
            pSoHD.Value = mahd;
            pThuNgan.Value = thungan;
            pThoiGian.Value = dt;
            pPhong.Value = ph;
            pKhachHang.Value = kh;
            pTongTienHD.Value = tongtien;
            pGiaPhong.Value = GiaPH;
            pSoNgayLuuTru.Value = songayluutru;
            objectDataSource1.DataSource = data;

        }
        
    }
}
