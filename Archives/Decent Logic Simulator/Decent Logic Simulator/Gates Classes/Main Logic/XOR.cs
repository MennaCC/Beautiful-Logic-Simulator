﻿using OUR_LogicSimulator.Gates_Classes;
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
        public XOR(short? Input1, short? Input2, short? Out)
        {
            InputNodesList[0].SetValue(Input1);
            InputNodesList[1].SetValue(Input2);
            if (this.checkThatAllInputsAreSet())
            {
                Out = this.calculateMinInputs(Input1, Input2);
                Output.SetValue(Out);
            }
        }

        public XOR(Node Input1, Node Input2, Node Out)
        {
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input1;
            Output = Out;
        }
        
        public override short? calculateMinInputs(short? x, short? y)
        {
            short result;
            if (x == y)
                result = (1);
            else
                result = (0);

            return result;

        }

        #endregion
    }
}
