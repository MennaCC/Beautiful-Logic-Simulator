using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator.FrontEnd
{
    public partial class Input_front : OurUserControl
    {
        public Input_front()
        {
            InitializeComponent();
        }

        private void ovalShapeInner_Click(object sender, EventArgs e)
        {
            if(ovalShapeInner.BackColor == Color.Crimson)
            {
                ovalShapeInner.BackColor = Color.SpringGreen;
            } else
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
