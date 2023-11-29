using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLL_DAL
{
    public class Basis
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
        public void XuatExcel(DataGridView dgv)
        {
            if (dgv.RowCount > 0)
            {
                Microsoft.Office.Interop.Excel.Application AppExcel = new Microsoft.Office.Interop.Excel.Application();
                AppExcel.Application.Workbooks.Add(Type.Missing);
                for(int i=0;i<dgv.Columns.Count;i++)
                {
                    AppExcel.Cells[1, i+1] = dgv.Columns[i].HeaderText;

                }
                for(int i = 0; i < dgv.Rows.Count; i++)
                {
                    for(int j = 0; j < dgv.Columns.Count; j++)
                    {
                        AppExcel.Cells[i+2, j + 1] = dgv.Rows[i].Cells[j].Value;
                    }
                }
                AppExcel.Columns.AutoFit();
                AppExcel.Visible = true;
            }
        }


    }
}
