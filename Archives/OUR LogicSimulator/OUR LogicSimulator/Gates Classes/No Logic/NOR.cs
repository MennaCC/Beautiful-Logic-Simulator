using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace OUR_LogicSimulator
{
   public class NOR : Gate
   {
       public NOR()
       { 
       }


        #region Dealing With Integers

        public NOR(Node Input1, Node Input2, Node Out)
        {
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input2;
            Output = Out;
        }

       public override void calculate()
        {
           Node tempOut = new Node();
           OR or = new OR(InputNodesList[0], InputNodesList[1], tempOut);
           or.validate();
           NOT not = new NOT(tempOut, Output);
           not.validate();
       }

        #endregion
    }
}
