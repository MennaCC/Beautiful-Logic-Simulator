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
    public partial class UserControl2 :UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private Point MouseDownLocation;
        private void UserControl2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }

        }

        private void UserControl2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calcout();
        }
        public void calcout()
        {
             

            int a, b;
            bool isAValid = int.TryParse(textBox1.Text, out a);
            bool isBValid = int.TryParse(textBox2.Text, out b);

            if (a==1&&b==1)
            { textBox3.Text = 1.ToString(); }

           else if (a==0&&b==0)
             { textBox3.Text = 0.ToString(); }
             else if(a==1&&b==0)
            { textBox3.Text = 0.ToString(); }
             else if(a==0&&b==1)
            { textBox3.Text = 0.ToString(); }
                

            else
                textBox3.Text = "Invalid input";
        
    }

       

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }

}
