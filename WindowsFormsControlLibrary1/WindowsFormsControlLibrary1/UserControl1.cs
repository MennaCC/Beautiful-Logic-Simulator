using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class TestingUserControl: UserControl
    {
        public TestingUserControl()
        {
            InitializeComponent();
        }

        private Point MouseDownLocation;

        private void TestingUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void TestingUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
            //Graphics g = this.CreateGraphics();
            //g.DrawLine(Pens.Black, MouseDownLocation, e.Location);
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

            if(ovalShape1.BackColor == Color.Green)
            {
                ovalShape1.BackColor = Color.Red;

            }
            else
            {
                ovalShape1.BackColor = Color.Green;

            }
        }
    }
}
