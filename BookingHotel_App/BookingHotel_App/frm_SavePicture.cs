using DevExpress.XtraEditors;
using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class frm_SavePicture : DevExpress.XtraEditors.XtraForm
    {
        public frm_SavePicture()
        {
            InitializeComponent();
        }
        bool streaming;
        Capture capture;
        
        public void Message(string message, MyMessageBox.enmType type)
        {
            MyMessageBox frm = new MyMessageBox();
            frm.showMess(message, type);
        }
        private void btn_Stream_Click(object sender, EventArgs e)
        {
            if (!streaming)
            {
                Application.Idle += Streaming;
                btn_Stream.Text = "Stop streaming";

            }
            else
            {
                Application.Idle -= Streaming;
                btn_Stream.Text = "Start streaming";
            }
            streaming = !streaming;
        }
        private void Streaming(object sender, EventArgs e)
        {
            var img = capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            pic_stream.Image = bmp;
        }
        private void btn_Capture_Click(object sender, EventArgs e)
        {
            pic_Image.Image = pic_stream.Image;
            
            
            

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = @"Please save your photo";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_Image.Image.Save(saveFileDialog.FileName + ".jpg",
                    System.Drawing.Imaging.ImageFormat.Jpeg);
                this.Message("Save image success", MyMessageBox.enmType.Success);
            }

        }

        private void frm_SavePicture_Load(object sender, EventArgs e)
        {
            try
            {
                capture = new Capture();
                streaming = false;
            }
            catch
            {

            }
        }
    }
}