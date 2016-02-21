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
    class NAND : Gate
    {
        public NAND()
        { 
        }

        #region frontEnd
        public override void Draw(PaintEventArgs e)
        {

           // SolidBrush sb = new SolidBrush(Color.Black);
            int x = 0;
            int y = 20;
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 30, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 40, x + 30, y + 40);
            e.Graphics.DrawLine(myPen, x + 30, y - 10, x + 30, y + 50);
            e.Graphics.DrawArc(myPen, x, y - 10, 60, 60, 270, 180);
            e.Graphics.DrawArc(myPen, x + 60, y + 15, 10, 10, 0, 360);
            // e.Graphics.DrawLine(Pens.Black, x + 70, y + 20, x + 100, y + 20);
            Graphics nand = e.Graphics;
        }

        #endregion
        //public NAND(Node Input1, Node Input2, Node Out)
        //{
        //    Input[0] = Input1;
        //    Input[1] = Input2;
        //    Output = Out;

        //}
        public override short? calculateMinInputs(short? x, short? y)
         {
            short? result = null;
            if (x == 0 && y == 0)
            {
                result = (1);
            }
            else
            {
                result = (0);
            }
            return result;

        }
    }

}
