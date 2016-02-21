using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator
{
    class XNOR : Gate
    {
        public XNOR()
        { 
        }

        #region frontEnd
        public override void Draw(PaintEventArgs e)
        {
            //SolidBrush sb = new SolidBrush(Color.Black);

            int x = 0;
            int y = 30;
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 25, x + 40, y + 25);
            e.Graphics.DrawArc(myPen, x + 5, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 62, y + 5, 10, 10, 0, 360);
            //e.Graphics.DrawLine(Pens.Black, x + 73, y + 10, x + 110, y + 10);
        }

        #endregion
        #region Dealing With Integers

        public XNOR(Node Input1, Node Input2, Node Out)
        {
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input2;
            Output = Out;
        }

        public override short? calculateMinInputs(short? x , short? y)
        {
            short result;
            if (x == y)
                result = (1);
            else
                result = (0);

            return result;

        }

        #endregion
    }
}
