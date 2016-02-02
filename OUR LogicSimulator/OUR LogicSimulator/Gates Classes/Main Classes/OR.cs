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
    public class OR : Gate
    {
        public OR()
        { 
        }

        #region frontEnd
        public override void Draw(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(Pens.Black, 30, 40, 10, 10);
            //e.Graphics.DrawRectangle(Pens.Black, 30, 70, 10, 10);
           // e.Graphics.DrawRectangle(Pens.Black, 70, 55, 10, 10);
            e.Graphics.DrawArc(Pens.Black, 10, 25, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, 2, 25, 60, 60, 270, 180);
        }

        #endregion


        #region Dealing With Integers
        public OR(short? Input1, short? Input2, short? Out)
        {
            InputNodesList[0].SetValue(Input1);
            InputNodesList[1].SetValue(Input2);
            if (this.checkThatAllInputsAreSet())
            {
                Out = this.calculateMinInputs(Input1, Input2);
                Output.SetValue(Out);
            }
        }
        public OR(Node Input1, Node Input2, Node Out)
        {
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input2;
            Output = Out;


        }

        public override short? calculateMinInputs(short? x, short? y)
        {
            short result;
            if (x == 0 && y == 0)
            {
                result = (0);
            }
            else
            {
                result = (1);
            }

            return result;
        }
        #endregion
    }


}
