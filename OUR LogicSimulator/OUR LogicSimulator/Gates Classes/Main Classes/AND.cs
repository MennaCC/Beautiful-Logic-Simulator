using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
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


        #region Dealing With Integers
        public AND(Node Input1, Node Input2, Node Out)
        {
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input2;
            Output = Out;
        }

      public override void calculateMinInputs()
        {
          

            if (x == 1 && y == 1)
            {
                Output.SetValue(1);
            }
            else
            {
                Output.SetValue(0);
            }
        }
        #endregion
    }
}
