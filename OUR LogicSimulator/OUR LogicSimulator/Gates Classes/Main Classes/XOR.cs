using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator
{
    class XOR : Gate
    {
        public XOR()
        { 
        }


        #region Dealing With Integers

        public XOR(Node Input1, Node Input2, Node Out)
        {
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input1;
            Output = Out;
        }
        
        public override void calculate()
        {
            short? x = InputNodesList[0].GetValue();
            short? y = InputNodesList[1].GetValue();

            if (x == y)
                Output.SetValue(0);
            else
                Output.SetValue(1);

        }

        #endregion
    }
}
