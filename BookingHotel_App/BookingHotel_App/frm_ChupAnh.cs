using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;

namespace BookingHotel_App
{
    public partial class frm_ChupAnh : DevExpress.XtraEditors.XtraForm
    {
        public frm_ChupAnh()
        {
            InitializeComponent();
        }
        bool streaming;
        bool flag;
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

        private void frm_ChupAnh_Load(object sender, EventArgs e)
        {
            streaming = false;
            flag = false;
            capture = new Capture();
        }
        private void Streaming(object sender, EventArgs e)
        {
            var img = capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            pic_stream.Image = bmp;
        }
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        
        private void btn_Capture_Click(object sender, EventArgs e)
        {
            pic_Image.Image = pic_stream.Image;
            
            Bitmap bitmap = new Bitmap(pic_Image.Image);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 0);
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
            if (flag == true)
            {
                this.Message("Đây là ảnh chân dung", MyMessageBox.enmType.Success);
            }
            else
                this.Message("Đây không là ảnh chân dung",MyMessageBox.enmType.Error);
            pic_Image.Image = bitmap;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                this.Message("Không lưu vì không là ảnh chân dung", MyMessageBox.enmType.Error);
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