using Decent_Custom_Logic_Simulator.FrontEnd;
using OUR_LogicSimulator;
using OUR_LogicSimulator.Gates_Classes;
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
            if (instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }
        #endregion

        #region ana w shimaa w hager :'D

        public Node senderNode;
        public Node getSenderNode()
        {
            return senderNode;
        }
        public void setSenderNode(Node n)
        {
            senderNode = n;
        }
        public Point startPointHyma2;
        public Point end { set; get; }
        List<Point> p1List = new List<Point>();
        List<Point> p2List = new List<Point>();
        public void laE7naM4HnhazzarDaHytsallem(customControl senderCtrl)
        {
            p1List.Add(new Point(startPointHyma2.X + senderCtrl.Location.X, startPointHyma2.Y + senderCtrl.Location.Y));
            p2List.Add(new Point(end.X + senderCtrl.Location.X, end.Y + senderCtrl.Location.Y));

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            using (var p = new Pen(Color.Black, 4))
            {
                for (int x = 0; x < p1List.Count; x++)
                {
                    e.Graphics.DrawLine(p, p1List[x], p2List[x]);
                }
            }
            Invalidate();
        }


        #endregion
        #region private Attributes
        private Point startPoint, endPoint, mousePos;
        private List<Gate_Front> GateFrontList = new List<Gate_Front>();
        #endregion

        #region Temporary Methods for testing

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string txt = e.X.ToString() + " " + e.Y.ToString();
            textBoxLocationEnd.Text = txt;
            DrawWire(e);
            //Microsoft.VisualBasic.PowerPacks.RectangleShape rec;

        }

        #endregion

        #region Drawing the Connection Wire (OLD)

        public void DrawOnForm(Point start, customControl SenderCntrl)
        {
            this.startPoint.X = start.X + SenderCntrl.Location.X;
            this.startPoint.Y = start.Y + SenderCntrl.Location.Y;
            String txt = startPoint.X.ToString() + " " + startPoint.Y.ToString();
            Form1.getInstance().textBoxLocation.Text = txt;

        }

        public void DrawWire(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && startPoint != null)
                endPoint = new Point(e.X, e.Y);
        }

        #endregion


        private void Switch_Click(object sender, EventArgs e)
        {
            Output_Front s = new Output_Front();
            this.Controls.Add(s);
        }

        private void LED_Click(object sender, EventArgs e)
        {

        }

        private void Gate_MouseDown(object sender, MouseEventArgs e)
        {

            textBoxLocation.Text = ActiveControl.Name.ToString();
           

              
                Gate_Front newGate = new Gate_Front(this.ActiveControl.Name.ToString());
               
            

            GateFrontList.Add(newGate);
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
                newGate.Location = new Point(mousePos.X - panel2.Left- 3*newGate.Width/2, mousePos.Y - 100);
            }
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

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName == null)
            {
                // Need to select an album file
                //menuSaveAs_Click(sender, e);
            }
            else
            {
                // Save the album in the current file
                //_album.Save();
                //_bAlbumChanged = false;
            }
        }

        private void toolStripOpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != null)
            {
                //Import the circuit
            }
        }



        #region Drawing Gates on Fixed Controls Panel
        private int x = -25;
        private SolidBrush mySolidBrush = new SolidBrush(Color.Black);
        private Pen myPen = new Pen(Color.Black, (float)1.45);

            
            private void customControlOR_Paint(object sender, PaintEventArgs e)
        {
            int y = 30;
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(myPen, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 2, y - 20, 60, 60, 270, 180);
            //e.Graphics.DrawLine(Pens.Black, x + 60, y + 10, x + 100, y + 10);

        }

        private void customControlAND_Paint(object sender, PaintEventArgs e)
        {
            int y = 20;
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 40, x + 40, y + 40);
            //e.Graphics.DrawLine(Pens.Black, x + 70, y + 20, x + 100, y + 20);
            e.Graphics.DrawLine(myPen, x + 40, y - 10, x + 40, y + 50);
            e.Graphics.DrawArc(myPen, x + 10, y - 10, 60, 60, 270, 180);
            /////////e.Graphics.DrawPath(Pen.Black);
            Graphics and = e.Graphics;
        }

        private void customControlNAND_Paint(object sender, PaintEventArgs e)
        {
            int y = 20;
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 30, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 40, x + 30, y + 40);
            e.Graphics.DrawLine(myPen, x + 30, y - 10, x + 30, y + 50);
            e.Graphics.DrawArc(myPen, x, y - 10, 60, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 60, y + 15, 10, 10, 0, 360);
           // e.Graphics.DrawLine(Pens.Black, x + 70, y + 20, x + 100, y + 20);
            Graphics nand = e.Graphics;
        }

        private void customControlNOR_Paint(object sender, PaintEventArgs e)
        {
            int y = 30;
            e.Graphics.DrawArc(myPen, x + 62, y + 5, 10, 10, 0, 360);
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(myPen, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 2, y - 20, 60, 60, 270, 180);
            //e.Graphics.DrawLine(Pens.Black, x + 72, y + 10, x + 100, y + 10);
        }

        private void customControlXOR_Paint(object sender, PaintEventArgs e)
        {
            int y = 30;
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(myPen, x + 5, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 2, y - 20, 60, 60, 270, 180);
            //e.Graphics.DrawLine(Pens.Black, x + 60, y + 10, x + 100, y + 10);
        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void customControlXNOR_Paint(object sender, PaintEventArgs e)
        {
            int y = 30;
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 25, x + 40, y + 25);
            e.Graphics.DrawArc(myPen, x + 5, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 62, y + 5, 10, 10, 0, 360);
            //e.Graphics.DrawLine(Pens.Black, x + 73, y + 10, x + 110, y + 10);
        }

        private void customControlNOT_Paint(object sender, PaintEventArgs e)
        {

            int y = 40;

            //e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(myPen, x + 40, y - 20, x + 40, y + 20);
            e.Graphics.DrawLine(myPen, x + 40, y - 20, x + 60, y);
            e.Graphics.DrawLine(myPen, x + 40, y + 20, x + 60, y);
            e.Graphics.DrawArc(myPen, x + 60, y - 5, 10, 10, 0, 360);
            //e.Graphics.DrawLine(Pens.Black, x + 70, y, x + 100, y);
        }

        #endregion

       
        private void INPUT_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawArc(myPen, 5, 15, 40, 40, 0, 360);

        }

        private void OUTPUT_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawArc(myPen, 5, 10, 40, 40, 0, 360);


        }

        private void INPUT_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxLocation.Text = ActiveControl.Name.ToString();
            Input_Front newGate = new Input_Front ();
            //GateFrontList.Add(newGate);
            Point d;
            d = Gate_Front.MousePosition;
            if (d.X < 2 * flowLayoutPanel1.Right && d.X > 0)
            {
                DoDragDrop(newGate, DragDropEffects.Link);
                newGate.Parent = panel2;
                mousePos = Gate_Front.MousePosition;
                // int dx = mousePos.X - DecentUserControlChild.Width - panel2.Left;
                // int dy = mousePos.Y - panel2.Top - 3 * DecentUserControlChild.Height + DecentUserControlChild.Height / 2;
                newGate.Location = new Point(mousePos.X - panel2.Left - 3 * newGate.Width / 2, mousePos.Y - 100);
            }
        }

        private void OUTPUT_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxLocation.Text = ActiveControl.Name.ToString();
            Output_Front newGate = new Output_Front();
            //GateFrontList.Add(newGate);
            Point d;
            d = Gate_Front.MousePosition;
            if (d.X < 2 * flowLayoutPanel1.Right && d.X > 0)
            {
                DoDragDrop(newGate, DragDropEffects.Link);
                newGate.Parent = panel2;
                mousePos = Gate_Front.MousePosition;
                // int dx = mousePos.X - DecentUserControlChild.Width - panel2.Left;
                // int dy = mousePos.Y - panel2.Top - 3 * DecentUserControlChild.Height + DecentUserControlChild.Height / 2;
                newGate.Location = new Point(mousePos.X - panel2.Left -  newGate.Width / 2, mousePos.Y - 100);
            }
        }

        #region old commented methods (e7tyaty)

        //private void buttonGate_Click(object sender, EventArgs e)
        //{
        //    //<summary>
        //    //// creates Gate_front object that creates a Gate object of type suitable to the name of the button
        //    //// for example a button Named "OR" will create an OR gate and call its draw function
        //    //// also that class is responsible for handling interactions with the gate object from the front end.
        //    //</summary>

        //    Gate_Front newGate = new Gate_Front(ActiveControl.Name);
        //    this.Controls.Add(newGate);
        //}

        #endregion

    }
}
