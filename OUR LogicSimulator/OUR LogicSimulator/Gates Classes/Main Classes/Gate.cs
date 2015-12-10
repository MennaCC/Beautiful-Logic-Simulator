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


        #region Attributes
        protected List <Node> InputNodesList = new List<Node>;
        protected Node Output = new Node();

        #endregion

        
        #region Methods With No Implementation

        public Gate()
        {

        }

        public virtual void calculate()
        {
        }

        #endregion


        #region Methods With Implementation
        public virtual void validate()
        {
            bool ThereIsNull = false;

            //check nulls in the inputs 
            //turn the flag on and break if any Null is found 

            for (int i = 0; i < InputNodesList.Count; i++)
            {
                if (InputNodesList[i].GetValue() == null)
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


        public void AddIp(Node ip)
        {
            InputNodesList.Add(ip);

        }
       

        public Node GetOp()
        {
            return Output;
        }
        #endregion

        #region Backend Testing Methods
        //change the privacy of the method from private
        //if you want to use any of them

        private void SetIp1(Node Input1)
        {
            InputNodesList[0] = Input1;

        }

        private void SetIp2(Node Input2)
        {
            InputNodesList[1] = Input2;

        }

        private void SetOp(Node Out)
        {
            Output = Out;

        }
        /* 
        protected Node In1;
        protected Node In2;
        protected Node Out;

        protected TextBox[] Input = new TextBox[2];
        */


        #endregion
    }



}


    
 
       