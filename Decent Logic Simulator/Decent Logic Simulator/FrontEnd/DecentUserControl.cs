using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Decent_Logic_Simulator.FrontEnd
{
    public partial class DecentUserControl : UserControl
    {
        public DecentUserControl()
        {
            InitializeComponent();
        }
        private Point mol;

        private void rectangleShape_click(object sender, EventArgs e)
        {
            this.ActiveControl.BackColor = Color.Azure;
        }

        private void OurUserControl_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void OurUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mol.X;
                this.Top = e.Y + this.Top - mol.Y;
            }
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

        private Point setPointA;

        public void DrawConnection(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                setPointA = new Point(rectangleShape4.Location.X, rectangleShape4.Location.Y);
            Refresh();
            

            SingletonForm.getFormInstance().DrawOnForm(setPointA,this);
        }

        private void rectangleShape4_MouseClick(object sender, MouseEventArgs e)
        {
            RectangleShape rec = new RectangleShape();

        //SingletonForm.getFormInstance().Controls.Add(rec);
            this.DrawConnection(e);         
           
        }

        private void DecentUserControl_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
