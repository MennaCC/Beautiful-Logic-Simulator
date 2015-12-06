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
            Input[0] = Input1;
            Input[1] = Input1;
            Output = Out;
        }
        
        public override void calculate()
        {
            short? x = Input[0].GetValue();
            short? y = Input[1].GetValue();

            if (x == y)
                Output.SetValue(1);
            else
                Output.SetValue(0);

        }

        #endregion
    }
}
