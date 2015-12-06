using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; // i included that !!


namespace OUR_LogicSimulator
{
   public class Gate
    {
       public Gate()
        {

        }
      
        #region Dealing With Integers

        protected List <Node > Input = new List <Node>();
        protected Node Output;
        protected Node In1;
        protected Node In2;
        protected Node Out;

        //protected TextBox[] Input = new TextBox[2];


        public virtual void calculate()
        { 
        }

        
        public virtual void validate()
        {
            bool ThereIsNull = false;

            //check nulls in the inputs 
            //turn the flag on and break if any Null is found 

            for (int i = 0; i < Input.Count; i++)
            {
                if (Input[i].GetValue() == null)
                {
                    ThereIsNull = true;
                    MessageBox.Show("Please Fill In All The Inputs");
                }

            }
            if (!ThereIsNull)
            {
                calculate(); //calculate if the flag isn't turned on
            }
          

        }

        //Menna 
        //Edit the code to point to reference of Textbox
        public void SetIp1(Node Input1)
        {
            Input[0] = Input1;

        }

        public void SetIp2(Node Input2)
        {
            Input[1] = Input2;

        }

        public void SetOp(Node Out)
        {
            Output = Out;

        }
        #endregion


    }

   

}


    
 
       