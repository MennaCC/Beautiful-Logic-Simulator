﻿using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        #region frontEnd
        public override void Draw(PaintEventArgs e)
        {
            int x = 0;
            int y = 30;
            e.Graphics.DrawArc(Pens.Black, x + 62, y + 5, 10, 10, 0, 360);
            e.Graphics.DrawLine(Pens.Black, x, y, x + 40, y);
            e.Graphics.DrawLine(Pens.Black, x, y + 20, x + 40, y + 20);
            e.Graphics.DrawArc(Pens.Black, x + 10, y - 20, 30, 60, 270, 180);
            e.Graphics.DrawArc(Pens.Black, x + 2, y - 20, 60, 60, 270, 180);
            e.Graphics.DrawLine(Pens.Black, x + 72, y + 10, x + 100, y + 10);
        }

        #endregion
        #region Dealing With Integers

        public NOR(Node Input1, Node Input2, Node Out)
        {
            InputNodesList[0] = Input1;
            InputNodesList[1] = Input2;
            Output = Out;
        }

       public override short? calculateMinInputs(short? x , short? y)
        {
            //Node tempOut = new Node();
           short? result = null;
           OR or = new OR(x, y, result);
           NOT not = new NOT(result, result);
           return result;
       }

        #endregion
    }
}
