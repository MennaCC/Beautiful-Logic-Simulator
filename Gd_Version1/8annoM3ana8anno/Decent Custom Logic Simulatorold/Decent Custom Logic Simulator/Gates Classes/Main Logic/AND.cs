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
    public class AND : Gate
    {
        public AND()
        { 
        }


        #region frontEnd
        public override void Draw(PaintEventArgs e)
        {
            // SolidBrush sb = new SolidBrush(Color.Black);

            int x = 0;
            int y = 20;
            //e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            //e.Graphics.DrawLine(Pens.Black, x, y + 40, x + 40, y + 40);
            //e.Graphics.DrawLine(Pens.Black, x + 70, y + 20, x + 100, y + 20);
            e.Graphics.DrawLine(myPen, x + 40, y - 10, x + 40, y + 50);
            e.Graphics.DrawArc(myPen, x + 10, y - 10, 60, 60, 270, 180);
            /////////e.Graphics.DrawPath(Pen.Black);

        }

        #endregion

        //el7etta d 3yza ttzabbat 

        #region Dealing With Integers
        //public AND(short? Input1, short? Input2, short? Out,List<Node> inputNodesList)
        //{
        //    inputNodesList[0].SetValue( Input1);
        //    inputNodesList[1].SetValue( Input2);
        //    if (this.checkThatAllInputsAreSet())
        //    {
        //        Out = this.calculateMinInputs(Input1, Input2);
        //        Output.SetValue(Out);
        //    }


        //}

        public override short? calculateMinInputs(short? x, short? y)
        {

            short? result = null;
            if (x == 1 && y == 1)
            {
                result = (1);
            }
            else
            {
                result = (0);
            }
            return result;
        }
        #endregion
    }
}
