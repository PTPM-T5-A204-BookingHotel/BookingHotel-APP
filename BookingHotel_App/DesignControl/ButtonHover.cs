using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignControl
{
    public class ButtonHover:Button
    {
        public ButtonHover() 
        {
            this.ForeColor = Color.Lime;
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            this.FlatAppearance.BorderSize = 2;
            this.FlatAppearance.MouseOverBackColor = Color.Lime;
            this.FlatStyle = FlatStyle.Flat;
            this.Cursor = Cursors.Hand;
            this.MouseEnter += ButtonHover_MouseEnter;
            this.MouseLeave += ButtonHover_MouseLeave;
        }

        private void ButtonHover_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Lime;
        }

        private void ButtonHover_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromArgb(46, 51, 73);
        }
    }
}
