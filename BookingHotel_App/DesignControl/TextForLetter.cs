using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignControl
{
    public class TextForLetter:TextBox
    {
        public TextForLetter()
        {
            this.KeyPress += TextForLetter_KeyPress;
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.ForeColor = Color.White;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

        }

        private void TextForLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.Equals(""))
            {
                e.Handled = true;
            }
        }
    }
}
