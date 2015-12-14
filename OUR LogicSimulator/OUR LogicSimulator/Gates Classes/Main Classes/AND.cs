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


        //el7etta d 3yza ttzabbat 

        #region Dealing With Integers
        public AND(short? Input1, short? Input2, short? Out)
        {
            InputNodesList[0].SetValue( Input1);
            InputNodesList[1].SetValue( Input2);
            Output.SetValue(Out);

        }

      public override short? calculateMinInputs(short? x, short? y)
        {

            short? result;
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
