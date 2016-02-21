using Decent_Custom_Logic_Simulator.FrontEnd;
using OUR_LogicSimulator.Gates_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; // i included that !!


namespace OUR_LogicSimulator
{
    public class Gate
    {

        #region frontEnd
        public virtual void Draw(PaintEventArgs e)
        {

        }
        #endregion

        #region Attributes
        protected List<Node> InputNodesList = new List<Node>();
        protected Node Output = new Node();
        protected Pen myPen = new Pen(Color.Black, (float)1.45);


        #endregion



        #region Methods With No Implementation
        public Gate()
        {

        }

        public virtual short? calculateMinInputs(short? ip1,short? ip2)
        {
            return 3;
        }

        //this is overriden in Not only
        public virtual void calculate()
        {
            
            short? nextNodeValue;
            short? result = InputNodesList[0].GetValue();
            for (int i = 1; i < InputNodesList.Count; i++)
            {
                nextNodeValue = InputNodesList[i].GetValue();
                result = calculateMinInputs(nextNodeValue, result);
            }
            this.Output.SetValue(result);
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


        public void AddIp(Node ip,customControl referencingGateOrLED)
        {
            InputNodesList.Add(ip);
            {
                ip.AddToGatesOrLEDsList(referencingGateOrLED);
            }

        }

        public void AlertGate()
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




       