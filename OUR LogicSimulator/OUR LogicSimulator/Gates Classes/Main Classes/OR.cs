﻿using OUR_LogicSimulator.Gates_Classes;
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
            Input[0] = Input1;
            Input[1] = Input2;
            Output = Out;


        }

        public override void calculate()
        {
            short? x = Input[0].GetValue();
            short? y = Input[1].GetValue();
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
