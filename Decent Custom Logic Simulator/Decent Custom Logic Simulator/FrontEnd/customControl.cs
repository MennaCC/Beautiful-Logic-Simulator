using Microsoft.VisualBasic.PowerPacks;
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
    public partial class customControl : Control
    {
        public customControl()
        {
            InitializeComponent();
        }

        #region Node Creation
        private Node_Front newRect;

        private void newInputRectMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newRect.Left = e.X + newRect.Left - mol.X;
                newRect.Top = e.Y + newRect.Top - mol.Y;
            }
        }

        private RectangleShape outRec;
        protected void generateNode(RectangleShape rec,Point ourLocation, MouseEventArgs e)
        {
            outRec = rec;
            Node_Front newInputRect = new Node_Front();
            newRect = newInputRect;
            Form1.getInstance().Controls.Add(newInputRect);
            int xPosition = outRec.Location.X + ourLocation.X;
            int yPosition = outRec.Location.Y + ourLocation.Y;
            // Point p = rectangleShape4.Parent.PointToScreen(rectangleShape4.Location);
            //newInputRect.Location = new Point((Cursor.Position.X - xPosition), (Cursor.Position.Y - yPosition));
            newInputRect.Location = new Point(xPosition, yPosition);
            newInputRect.BringToFront();
            this.DrawConnection(e);
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
        #endregion


        #region hide dlw2ty
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Point mol;

        private Point setPointA;

        public void DrawConnection(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                setPointA = new Point(outRec.Location.X, outRec.Location.Y);
            Refresh();


            //SingletonForm.getFormInstance().DrawOnForm(setPointA, this);
        }

        private void DecentUserControl_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion
    }
}
