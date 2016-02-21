using OUR_LogicSimulator;
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
        public Gate_Front(string gateType)
        {
            InitializeComponent();
            this.gateType = gateType;           
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            createGateDueToType(pe);
            base.OnPaint(pe);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            Form myForm = rectangleShape5.FindForm();
            // myForm.BackColor = Color.Blue;
            //DrawConnection(e);
            //OnPaint();
            // myForm.Paint;
            // Control control = rectangleShape5.Parent;
            //control.BackColor = Color.Black;
            //CreateControl();
            //CreateControlsInstance();
            // myForm.CreateGraphics();
            //DrawPath(Pen, GraphicsPath)

        }
        

        private void rectangleShape5_MouseDown(object sender, EventArgs e)
        {
            
        }
        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            //
        }

        public void DrawConnection(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                setPointA = new Point(rectangleShape4.Location.X, rectangleShape4.Location.Y);
            Refresh();
            //SingletonForm.getFormInstance().DrawOnForm(setPointA, this);
        }

        private Point setPointA;

        /// <summary>
        /// el function d el mafrood an2elha fel base class w hya elly bt3mel el instantiation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rectangleShape4_MouseClick(object sender, MouseEventArgs e)
        {
            Node_Front newInputRect = new Node_Front();
            newRect = newInputRect;
            Form1.getInstance().Controls.Add(newInputRect);
            int xPosition = this.rectangleShape4.Location.X + this.Location.X;
            int yPosition = this.rectangleShape4.Location.Y + this.Location.Y;
            // Point p = rectangleShape4.Parent.PointToScreen(rectangleShape4.Location);
            //newInputRect.Location = new Point((Cursor.Position.X - xPosition), (Cursor.Position.Y - yPosition));
            newInputRect.Location = new Point(xPosition, yPosition);
            newInputRect.BringToFront();
        }

        private void OurUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mol.X;
                this.Top = e.Y + this.Top - mol.Y;

            }
            if (newRect != null)
            {
                newInputRectMove(sender, e);
            }
        }

        private Node_Front newRect;
        private Point mol;

        private void newInputRectMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newRect.Left = e.X + newRect.Left - mol.X;
                newRect.Top = e.Y + newRect.Top - mol.Y;
            }
        }


        #region Private Attributes
        private string gateType = null;
        #endregion

        private void createGateDueToType(PaintEventArgs e)
        {

            //switch can be replaced by a one line of code using runtime Creation ((gotta GOOGLE it))
            Gate g;
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

                default:
                    g = null;
                    break;
            }
            g.Draw(e);

        }
    }
}
