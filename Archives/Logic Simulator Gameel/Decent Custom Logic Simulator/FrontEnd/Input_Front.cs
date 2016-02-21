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

        }

        //Composittion relation between node_front & Input_Front
        //Shimaa
        private Node_Front outputNode;

        private void ovalShapeInner_Click(object sender, EventArgs e)
        {
            if (ovalShapeInner.BackColor == Color.Crimson)
            {
                ovalShapeInner.BackColor = Color.SpringGreen;
            }
            else
            {
                ovalShapeInner.BackColor = Color.Crimson;
            }
        }

        private void rectangleShape1_MouseHover(object sender, EventArgs e)
        {
            rectangleShape1.BackColor = Color.MediumBlue;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
