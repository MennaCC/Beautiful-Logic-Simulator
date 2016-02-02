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
        public override void Draw(object sender, PaintEventArgs e)
        {

            SolidBrush sb = new SolidBrush(Color.Black);
            //e.Graphics.DrawRectangle(Pens.Black, 30, 40, 10, 10);
            //e.Graphics.DrawRectangle(Pens.Black, 30, 70, 10, 10);
            //e.Graphics.DrawRectangle(Pens.Black, 70, 55, 10, 10);

            e.Graphics.DrawArc(Pens.Black, 10, 30, 60, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, 70, 55, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, 80, 60, 150, 60);
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
             AND and = new AND(x, y, result);
             NOT not = new NOT(result, result);
            return result;

         }
    }

}
