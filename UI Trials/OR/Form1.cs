using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OR
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
            e.Graphics.DrawLine(Pens.Black, 0,45, 40, 45);
            e.Graphics.DrawLine(Pens.Black, 0, 65, 40, 65);
            e.Graphics.DrawArc(Pens.Black, 10, 25, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, 2, 25, 60, 60, 270, 180);
            e.Graphics.DrawLine(Pens.Black, 60, 55, 150, 55);

        }


    }
}
