using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Led
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

            e.Graphics.FillPie(Brushes.Orange,15,15,40,40,0,360);
         
            e.Graphics.FillPie(Brushes.Lime,27,27,15,15,0,360);
           
        }
    }
}
