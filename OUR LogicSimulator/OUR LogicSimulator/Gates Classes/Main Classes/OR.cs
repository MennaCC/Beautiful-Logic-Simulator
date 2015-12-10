using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
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



        #region Dealing With Integers
        public OR(Node Input1, Node Input2, Node Out)
        {
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input2;
            Output = Out;


        }

        public override void calculateMinInputs()
        {
            short? x = InputNodesList[0].GetValue();
            short? y = InputNodesList[1].GetValue();
            if (x == 0 && y == 0)
            {
                Output.SetValue(0);
            }
            else
            {
                Output.SetValue(1);
            }


        }
        #endregion
    }


}
