using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decent_Logic_Simulator.FrontEnd
{
    public partial class Input_Front : DecentUserControl
    {
        public Input_Front()
        {
            InitializeComponent();
        }

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
    }
}
