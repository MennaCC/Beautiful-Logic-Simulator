using Microsoft.VisualBasic.PowerPacks;
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

namespace Decent_Custom_Logic_Simulator.FrontEnd
{
    public partial class Gate_Front : customControl
    {
        public Gate_Front()
        {
            InitializeComponent();
        }

        public Gate_Front(string gateType)
        {
            InitializeComponent();
            this.gateType = gateType;
        }


        #region ana w hager w shimaa w hwak :"D

        public override void Alert()
        {
            this.g.AlertGate();
        }
        private void rectangleShapeMouseDowmn(object sender, MouseEventArgs e)
        {
            Form1.getInstance().setSenderNode(this.g.GetOp());
            Form1.getInstance().startPointHyma2 = new Point(e.X + this.Location.X + this.nodeFront4.Location.X, e.Y + this.Location.Y + this.nodeFront4.Location.Y);
            Node_Front rec = new Node_Front();
           // Form1.getInstance().Nodes.Add(rec);
            rec.DoDragDrop(rec, DragDropEffects.Copy);
            rec.BringToFront();


        }

        private void nodeFront5_DragDrop(object sender, DragEventArgs e)
        {
            Node senderNd = Form1.getInstance().getSenderNode();
            this.g.AddIp(senderNd, this);
            Form1.getInstance().end = new Point(this.Location.X, this.Location.Y + 15);
            Form1.getInstance().laE7naM4HnhazzarDaHytsallem(this);
            ((Node_Front)e.Data.GetData(typeof(Node_Front))).Parent = (Node_Front)sender;
            Invalidate();
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

        private void nodeFront6_DragDrop(object sender, DragEventArgs e)
        {
            Node senderNd = Form1.getInstance().getSenderNode();
            this.g.AddIp(senderNd, this);
            Form1.getInstance().end = new Point(this.Location.X + this.nodeFront6.Location.X, this.Location.Y+ this.nodeFront6.Location.Y + 15);
            Form1.getInstance().laE7naM4HnhazzarDaHytsallem(this);
            ((Node_Front)e.Data.GetData(typeof(Node_Front))).Parent = (Node_Front)sender;
            Invalidate();
        }

        private void nodeFront6_DragEnter(object sender, DragEventArgs e)
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






        #endregion


        public Gate g ;

        #region Private Attributes

        private string gateType = null;
        

        #endregion

        protected override void OnPaint(PaintEventArgs pe)
        {
            Form1.getInstance().gates[Form1.getInstance().gates.Count - 1].g.Draw(pe);
           
            base.OnPaint(pe);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// el function d el mafrood an2elha fel base class w hya elly bt3mel el instantiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        
       
        public void createGateDueToType()
        {

            //switch can be replaced by a one line of code using runtime Creation ((gotta GOOGLE it))
            switch (gateType)
            {
                case "OR":
                    g = new OR();
                    break;
                case "NOT":
                    g = new NOT();
                    break;
                case "AND":
                    g = new AND();
                    break;
                case "NAND":
                    g = new NAND();
                    break;
                case "NOR":
                    g = new NOR();
                    break;
                case "XOR":
                    g = new XOR();
                    break;
                case "XNOR":
                    g = new XNOR();
                    break;
                //case "input_Front1":
                //    g = new XNOR();
                //    break;
                //default:
                //    g = null;
                //    break;
            }
           // g.Draw(e);

        }
    }
}
