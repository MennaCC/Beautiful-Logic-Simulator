using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator.FrontEnd
{
    public partial class OurUserControl : UserControl
    {
        public OurUserControl()
        {
            InitializeComponent();
            

        }

        private Point mol;
        private  void rectangleShape_click(object sender, EventArgs e)
        {
            this.ActiveControl.BackColor = Color.Azure;
        }

        private void OurUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mol = e.Location;
            }
        }

        private void OurUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mol.X;
                this.Top = e.Y + this.Top - mol.Y;
            }
        }
    }
}
