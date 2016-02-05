using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Form1_Load);
        }
        private void Form1_Load(object sender, System.Windows.Forms.PaintEventArgs e)
        {
           
            e.Graphics.FillRectangle(Brushes.Lime, 0, 0, 60, 83);
            e.Graphics.FillRectangle(Brushes.Black, 60, 0, 10, 83);
            e.Graphics.FillRectangle(Brushes.Orange, 70, 0, 80, 83);
            e.Graphics.DrawString("ON", this.Font, Brushes.Black, new PointF(20, 20));
            e.Graphics.DrawString("OFF", this.Font, Brushes.Black, new PointF(85, 20));
        }
    }
}
