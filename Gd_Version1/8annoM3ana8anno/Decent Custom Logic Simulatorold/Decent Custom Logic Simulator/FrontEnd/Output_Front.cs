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
    public partial class Output_Front : customControl
    {
        public Output_Front()
        {
            InitializeComponent();
            newInputNode = new Node();
        }
        private Node newInputNode;
         //Composittion relation between node_front & Input_Front
        //Shimaa


        public override void Alert()
        {
            if (newInputNode.GetValue() == 1)
            {
                ovalShapeInner.BackColor = Color.SpringGreen;
            }
            else if(newInputNode.GetValue() == 0)
            {
                ovalShapeInner.BackColor = Color.Crimson;
            }
            else
            {
                ovalShapeInner.BackColor = Color.LightGray;
            }
        }

        private void rectangleShape1_MouseHover(object sender, EventArgs e)
        {
            rectangleShape1.BackColor = Color.MediumBlue;
        }

        private void rectangleShapeMouseDowmn(object sender, MouseEventArgs e)
        {
            Node_Front rec = new Node_Front();
            rec.DoDragDrop(rec, DragDropEffects.Copy);
            rec.BringToFront();
        }

        private void nodeFront5_DragDrop(object sender, DragEventArgs e)
        {
            this.newInputNode = Form1.getInstance().senderNode;
            newInputNode.AddToGatesOrLEDsList(this);
            ((Node_Front)e.Data.GetData(typeof(Node_Front))).Parent = (Node_Front)sender;
            Form1.getInstance().end = new Point(this.Location.X, this.Location.Y + 15);
            Form1.getInstance().laE7naM4HnhazzarDaHytsallem(this);
            //Get the output node of the sender gate and add it to the List of Inputs in the reciever Gate i.e this gate
        }

        private void nodeFront5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Node_Front)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
