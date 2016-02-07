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
            SolidBrush sb = new SolidBrush(Color.Black);

            //e.Graphics.DrawRectangle(Pens.Black, 30, 40, 10, 10);
            //e.Graphics.DrawRectangle(Pens.Black, 30, 70, 10, 10);
            //e.Graphics.DrawRectangle(Pens.Black, 70, 55, 10, 10);
            e.Graphics.DrawLine(Pens.Black, 40, 30, 40, 90);
            e.Graphics.DrawArc(Pens.Black, 10, 30, 60, 60, 270, 180);
        }

        #endregion

        //el7etta d 3yza ttzabbat 

        #region Dealing With Integers
        public AND(short? Input1, short? Input2, short? Out)
        {
            InputNodesList[0].SetValue( Input1);
            InputNodesList[1].SetValue( Input2);
            if (this.checkThatAllInputsAreSet())
            {
                Out = this.calculateMinInputs(Input1, Input2);
                Output.SetValue(Out);
            }
           

        }

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
