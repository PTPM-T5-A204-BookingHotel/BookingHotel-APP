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
        bool streaming = false;
        Capture capture = new Capture();
        
        bool flag;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
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
            
            Bitmap bitmap = new Bitmap(pic_stream.Image);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 0);
            flag = false;
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                        flag = true;
                    }
                }
            }
            
            pic_Image.Image = bitmap;
            if (flag == false)
            {
                this.Message("Đây không là ảnh chân dung", MyMessageBox.enmType.Error);
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                this.Message("Đây không là ảnh chân dung", MyMessageBox.enmType.Error);
            }
            else
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
            
        }
    }
}