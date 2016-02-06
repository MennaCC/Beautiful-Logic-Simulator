using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace LogicSimulatorGui
{
    public partial class Form1 : Form
    {
        public int x=10;
        public int y =30;
        public Form1()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_MouseHover(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void knowMoreAboutGatesToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        Point mousePos;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                if (pictureBox1.Left + dx > 0 && pictureBox1.Right + dx < panel1.Size.Width &&
                    pictureBox1.Top + dy > 0 && pictureBox1.Bottom + dy < panel1.Size.Height)
                    pictureBox1.Location = new Point(pictureBox1.Left + dx, pictureBox1.Top + dy);
            }
            
        }
        Point mousePos1;
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos1 = e.Location;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos1.X;
                int dy = e.Y - mousePos1.Y;
                if (pictureBox2.Left + dx > 0 && pictureBox2.Right + dx < panel1.Size.Width &&
                    pictureBox2.Top + dy > 0 && pictureBox2.Bottom + dy < panel1.Size.Height)
                    pictureBox2.Location = new Point(pictureBox2.Left + dx, pictureBox2.Top + dy);
            }

        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            SolidBrush sb = new SolidBrush(Color.Black);
            List<Graphics> drawings = new List<Graphics>();
            //nand
            e.Graphics.DrawLine(Pens.Black, x, y, x + 30, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 40, x + 30, y + 40);
            e.Graphics.DrawLine(Pens.Black, x + 30, y - 10, x + 30, y + 50);
            e.Graphics.DrawArc(Pens.Black, x, y - 10, 60, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 60, y + 15, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x + 70, y + 20, x + 100, y + 20);
            Graphics nand = e.Graphics;
            drawings.Add(nand);
            //and

            x = x + 120;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 40, x + 40, y + 40);
            e.Graphics.DrawLine(Pens.Black, x + 70, y + 20, x + 100, y + 20);
            e.Graphics.DrawLine(Pens.Black, x + 40, y - 10, x + 40, y + 50);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 10, 60, 60, 270, 180);
            Graphics and = e.Graphics;
            drawings.Add(and);
            //or
            y = y + 100;
            x = x - 120;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawLine(Pens.Black, x + 60, y + 10, x + 100, y + 10);
            //nor
            x = x + 120;

            e.Graphics.DrawArc(Pens.Black, x + 62, y + 5, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawLine(Pens.Black, x + 72, y + 10, x + 100, y + 10);

            //xor
            y = y + 100;
            x = x - 120;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(Pens.Black, x + 5, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawLine(Pens.Black, x + 60, y + 10, x + 100, y + 10);
            //xnor
            x = x + 120;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 25, x + 40, y + 25);
            e.Graphics.DrawArc(Pens.Black, x + 5, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 62, y + 5, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x + 73, y + 10, x + 110, y + 10);
            //not
            y = y + 100;
            x = x - 120;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x + 40, y - 20, x + 40, y + 20);
            e.Graphics.DrawLine(Pens.Black, x + 40, y - 20, x + 60, y);
            e.Graphics.DrawLine(Pens.Black, x + 40, y + 20, x + 60, y);
            e.Graphics.DrawArc(Pens.Black, x + 60, y - 5, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x + 70, y, x + 100, y);
           
        }

        

       
                //private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    Point p = new Point(e.Location.X + pictureBox1.Location.X, e.Location.Y + pictureBox1.Location.Y);
        //    if (p.X > 0 && p.X + pictureBox1.Size.Width < panel1.Size.Width &&
        //        p.Y > 0 && p.Y + pictureBox1.Size.Height < panel1.Size.Height)
        //    {
        //        pictureBox1.Location = p;
        //    }
        //}
    }
}
