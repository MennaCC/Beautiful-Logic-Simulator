using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gates_test
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private Point MouseDownLocation;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inverter();

        }
        public void inverter()
        {

            int a;
            bool isAValid = int.TryParse(textBox1.Text, out a);


            if (isAValid)
                if (a == 1)
                { textBox2.Text = 0.ToString(); }
            else if (a==0)
                { textBox2.Text = 1.ToString(); }
               else { textBox2.Text = "Error".ToString(); }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
    }
}
