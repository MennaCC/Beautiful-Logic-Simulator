using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator.Classes
{
    class XNOR : Gate
    {
        public XNOR()
        { 
        }


        #region Dealing With Integers

        public XNOR(Node Input1, Node Input2, Node Out)
        {
            Input[0] = Input1;
            Input[1] = Input2;
            Output = Out;
        }

        public override void calculateMinInputs()
        {
            Node tempOut = new Node();
            XOR xor = new XOR(Input[0], Input[1], tempOut);
            xor.checkThatAllInputsAreSet();
            NOT not = new NOT(tempOut, Output);
            not.checkThatAllInputsAreSet();
        }

        #endregion
    }
}
