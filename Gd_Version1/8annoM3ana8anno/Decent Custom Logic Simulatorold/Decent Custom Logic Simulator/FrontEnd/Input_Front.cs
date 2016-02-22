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

namespace Decent_Custom_Logic_Simulator.FrontEnd
{
    public partial class Input_Front : customControl
    {
        public Input_Front()
        {
            InitializeComponent();
            newNode = new Node();
        }
        private Node newNode;
         //Composittion relation between node_front & Input_Front
        //Shimaa

        private void ovalShapeInner_Click(object sender, EventArgs e)
        {
            if (ovalShapeInner.BackColor == Color.Crimson)
            {
                ovalShapeInner.BackColor = Color.SpringGreen;
                newNode.SetValue(1);
            }
            else
            {
                ovalShapeInner.BackColor = Color.Crimson;
                newNode.SetValue(0);
            }
        }

        private void rectangleShape1_MouseHover(object sender, EventArgs e)
        {
            rectangleShape1.BackColor = Color.MediumBlue;
        }


        private void rectangleShapeMouseDowmn(object sender, MouseEventArgs e)
        {
            Node_Front rec = new Node_Front();
           // Form1.getInstance().Nodes.Add(rec);
            Form1.getInstance().senderNode = this.newNode;
            Form1.getInstance().startPointHyma2 = new Point(e.X + this.Location.X + this.nodeFront4.Location.X, e.Y + this.Location.Y + this.nodeFront4.Location.Y);
            rec.DoDragDrop(rec, DragDropEffects.Copy);
            rec.BringToFront();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
