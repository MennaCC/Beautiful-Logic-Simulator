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
        protected List<Node> InputNodesList = new List<Node>();
        protected Node Output = new Node();

        #endregion
        


        #region Methods With No Implementation
        public Gate()
        {

        }

        public virtual short? calculateMinInputs(short? ip1,short? ip2)
        {
            return null;
        }

        public virtual void calculate()
        {
            short? x;
            short? y = InputNodesList[0].GetValue();
            for (int i = 1; i < InputNodesList.Count; i++)
            {
                x = InputNodesList[i].GetValue();
                y = calculateMinInputs(x, y);
            }

        }

        #endregion



        #region Methods With Implementation
        public virtual bool checkThatAllInputsAreSet()
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
            return !ThereIsNull;
            
        }


        public void AddIp(Node ip)
        {
            InputNodesList.Add(ip);
            ip.AddToGatesList(this);

        }

        public void Alert()
        {
            bool allIsSet = checkThatAllInputsAreSet();
            if (allIsSet)
                this.calculate();//calculateMinInputs will be called inside of calculate
        }


        public Node GetOp()
        {
            return Output;
        }
        #endregion



        #region Backend Testing Methods
        private void SetOp(Node Out)
        {
            Output = Out;

        }

        //change the privacy of the method from private
        //if you want to use any of them

        /*private void SetIp1(Node Input1)

              InputNodesList[0] = Input1;

          }

          private void SetIp2(Node Input2)
          {
              InputNodesList[1] = Input2;

          }*/ //those methods are not needed any more as we have addip function


        /* 
        protected Node In1;
        protected Node In2;
        protected Node Out;

        protected TextBox[] Input = new TextBox[2];
        */


        #endregion
    }



}




       