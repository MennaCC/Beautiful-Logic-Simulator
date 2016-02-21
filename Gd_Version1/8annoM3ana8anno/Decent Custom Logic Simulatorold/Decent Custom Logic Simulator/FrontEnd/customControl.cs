using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decent_Custom_Logic_Simulator.FrontEnd
{
    public partial class customControl : Panel
    {
        public customControl()
        {
            InitializeComponent();
        }

        private void makeActive(object sender, MouseEventArgs e)
        {
            this.Select();
        }

        public virtual void Alert()
        {
            //this function is created to be overridden in Gate and LED classes
            //to tell them that the node they take as an input was set to a value
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void OurUserControl_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private Point mol;

        private void OurUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mol.X;
                this.Top = e.Y + this.Top - mol.Y;
            }
        }

        // private void OurUserControl_MouseMove(object sender, MouseEventArgs e)
        // {
        //     if (e.Button == System.Windows.Forms.MouseButtons.Left)
        //     {
        //       this.Left = e.X + this.Left - mol.X;
        //       this.Top = e.Y + this.Top - mol.Y;
        //     }
        // }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {

        }
    }
}
