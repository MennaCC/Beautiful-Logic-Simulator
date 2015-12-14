﻿using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OUR_LogicSimulator
{
   public class NOT : Gate
   {
       public NOT()
       { 
       }

        #region Dealing With Integers

        public NOT(short? Input1, short? Out)
        {
            InputNodesList[0].SetValue(Input1);
            Output.SetValue(Out);

        }
        public NOT(Node Input1, Node Out)
        {
            InputNodesList[0] = Input1;
            Output = Out;
        }
        public override bool checkThatAllInputsAreSet()
        {
            if (InputNodesList.Count > 1)
            {
                MessageBox.Show("Only One Input is allowed for Not Gate!");
            }
            
            bool ThereIsNull = false;
            if (InputNodesList[0].GetValue() == null )
            {
                ThereIsNull = true;
                MessageBox.Show("Please specify an input for the Not Gate :')");
            }

            return !ThereIsNull;

        }

        public override void calculate()
        {
            if (InputNodesList[0].GetValue() == 0)
            {
                Output.SetValue(1);
            }
            else if (InputNodesList[0].GetValue() == 1)
            {
                Output.SetValue(0);
            }
        }
        
        #endregion
    }
}
