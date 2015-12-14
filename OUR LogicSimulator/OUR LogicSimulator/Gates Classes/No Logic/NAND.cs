using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
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


        //public NAND(Node Input1, Node Input2, Node Out)
        //{
        //    Input[0] = Input1;
        //    Input[1] = Input2;
        //    Output = Out;

        //}
         public override short? calculateMinInputs(short? x, short? y)
         {
             short? result;
             AND and = new AND(x, y, result);
             and.checkThatAllInputsAreSet();
             NOT not = new NOT(result, result);
            not.checkThatAllInputsAreSet();

         }
    }

}
