using Decent_Custom_Logic_Simulator.FrontEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decent_Custom_Logic_Simulator
{
    public partial class Form1 : Form
    {
        #region Singleton
        private static Form1 instance;
        private Form1()
        {
            InitializeComponent();
            panel2.AllowDrop = true;
            flowLayoutPanel1.AllowDrop = false;
        }

        public static Form1 getInstance()
        {
            if(instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }
        #endregion

        private Point startPoint, endPoint;

         #region Methods that Work with frontEnd 
        
        public void DrawOnForm(Point start, customControl SenderCntrl)
        {
            this.startPoint.X = start.X + SenderCntrl.Location.X;
            this.startPoint.Y = start.Y + SenderCntrl.Location.Y;
            String txt = startPoint.X.ToString() + " " + startPoint.Y.ToString();
            Form1.getInstance().textBoxLocation.Text = txt;

        }
        
        private void buttonGate_Click(object sender, EventArgs e)
        {
            //<summary>
            //// creates Gate_front object that creates a Gate object of type suitable to the name of the button
            //// for example a button Named "OR" will create an OR gate and call its draw function
            //// also that class is responsible for handling interactions with the gate object from the front end.
            //</summary>
            
            Gate_Front newGate = new Gate_Front(ActiveControl.Name);
            this.Controls.Add(newGate);
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            Input_Front s = new Input_Front();
            this.Controls.Add(s);
        }
        #endregion 

        private void LED_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(SystemPens.ControlText, startPoint, endPoint);
        }
        public void DrawWire(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && startPoint != null)
                endPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string txt = e.X.ToString() + " " + e.Y.ToString();
            textBoxLocationEnd.Text = txt;
            DrawWire(e);
            //Microsoft.VisualBasic.PowerPacks.RectangleShape rec;

        }



        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            ((customControl)e.Data.GetData(typeof(customControl))).Parent = (Panel)sender;

        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(customControl)))
                e.Effect = DragDropEffects.Link;
        }

        Point mousePos;
        

        private void customControl8_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 30;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawLine(Pens.Black, x + 60, y + 10, x + 100, y + 10);

        }

        private void customControl2_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 20;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 40, x + 40, y + 40);
            e.Graphics.DrawLine(Pens.Black, x + 70, y + 20, x + 100, y + 20);
            e.Graphics.DrawLine(Pens.Black, x + 40, y - 10, x + 40, y + 50);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 10, 60, 60, 270, 180);
            Graphics and = e.Graphics;
        }

        private void customControl3_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 20;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 30, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 40, x + 30, y + 40);
            e.Graphics.DrawLine(Pens.Black, x + 30, y - 10, x + 30, y + 50);
            e.Graphics.DrawArc(Pens.Black, x, y - 10, 60, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 60, y + 15, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x + 70, y + 20, x + 100, y + 20);
            Graphics nand = e.Graphics;
        }

        private void customControl7_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 30;
            e.Graphics.DrawArc(Pens.Black, x + 62, y + 5, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawLine(Pens.Black, x + 72, y + 10, x + 100, y + 10);
        }

        private void customControl6_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 30;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(Pens.Black, x + 5, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawLine(Pens.Black, x + 60, y + 10, x + 100, y + 10);
        }

        private void customControl5_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 30;
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 25, x + 40, y + 25);
            e.Graphics.DrawArc(Pens.Black, x + 5, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 62, y + 5, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x + 73, y + 10, x + 110, y + 10);
        }

        private void customControl4_Paint(object sender, PaintEventArgs e)
        {

            int x = 0;
            int y = 40;

            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x + 40, y - 20, x + 40, y + 20);
            e.Graphics.DrawLine(Pens.Black, x + 40, y - 20, x + 60, y);
            e.Graphics.DrawLine(Pens.Black, x + 40, y + 20, x + 60, y);
            e.Graphics.DrawArc(Pens.Black, x + 60, y - 5, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x + 70, y, x + 100, y);
        }
        private void Gate_MouseDown(object sender, MouseEventArgs e)
        {

            textBoxLocation.Text = ActiveControl.Name .ToString();
            Gate_Front newGate = new Gate_Front(this.ActiveControl.Name.ToString());
           
            //  DecentUserControl DecentUserControlChild = new DecentUserControl(ActiveControl.Name.ToString());
            Point d;
            d = Gate_Front.MousePosition;
            if (d.X < 2 * flowLayoutPanel1.Right && d.X > 0)
            {

                //  notgate2.Show();
                // lw 3wzen na3mal click msh drag wa drop
                DoDragDrop(newGate, DragDropEffects.Link);
                newGate.Parent = panel2;
                mousePos = Gate_Front.MousePosition;


                // int dx = mousePos.X - DecentUserControlChild.Width - panel2.Left;
                // int dy = mousePos.Y - panel2.Top - 3 * DecentUserControlChild.Height + DecentUserControlChild.Height / 2;
                newGate.Location = new Point(mousePos.X - 360, mousePos.Y - 120);
            }
        }

    }
}
