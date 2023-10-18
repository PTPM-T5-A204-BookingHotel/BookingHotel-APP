using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public  class Basis
    {
        public void UpLoadImage(PictureBox pictureBox)
        {
            string path = "";
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
                pictureBox.ImageLocation = path;
            }

        }
        public byte[] ConvertImgToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }
        public void clearTextBoxs(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                else
                    clearTextBoxs(control.Controls);
            }
        }
        public bool isNgaySinh(DateTime date)
        {
            DateTime nowdate = DateTime.Now;
            var result = nowdate.Year - date.Year;
            if (result < 18)
                return false;
            return true;
        }
        public bool isEmail(string mail)
        {
            if (string.IsNullOrEmpty(mail))
                return false;
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(mail);

        }
        public bool isSDT(string phone)
        {
            if (phone == null)
                return false;
            if (phone.Length < 10 || phone.Length > 10)
                return false;
            char c = phone[0];
            if (!c.Equals('0'))
                return false;
            return true;

        }
        public bool isCCCD(string idNum)
        {
            if (idNum == null)
                return false;
            if (idNum.Length < 12 || idNum.Length > 12)
                return false;
            char c = idNum[0];
            if (!c.Equals('0'))
                return false;
            return true;

        }

    }
}
