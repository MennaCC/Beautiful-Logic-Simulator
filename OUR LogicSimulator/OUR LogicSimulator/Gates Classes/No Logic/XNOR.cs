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
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input2;
            Output = Out;
        }

        public override void calculateMinInputs(short? x , short? y)
        {
            //Node tempOut = new Node();
            short? result;
            XOR xor = new XOR(x,y, result);
            xor.checkThatAllInputsAreSet();
            NOT not = new NOT(result,result);
            not.checkThatAllInputsAreSet();
        }

        #endregion
    }
}
