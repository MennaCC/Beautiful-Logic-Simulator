using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decent_Logic_Simulator.FrontEnd
{
    public partial class newInputRectangle : UserControl
    {
        public newInputRectangle()
        {
            InitializeComponent();
        }
        private Point mol;

        private void newInputRectangle_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mol.X;
                this.Top = e.Y + this.Top - mol.Y;
            }
        }
    }
}
