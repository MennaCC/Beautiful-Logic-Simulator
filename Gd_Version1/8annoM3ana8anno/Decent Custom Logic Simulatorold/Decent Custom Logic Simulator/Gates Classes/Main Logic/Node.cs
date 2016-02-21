using Decent_Custom_Logic_Simulator.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUR_LogicSimulator.Gates_Classes
{
    public class Node
    {

        #region Protected Attributes
        protected string Name;
        protected short? Value;
        //protected List<Gate> GatesThatReferenceMeAsAnInput = new List<Gate>();
        protected List<customControl> GatesThatReferenceMeAsAnInput = new List<customControl>();

        #endregion

        #region Primary Methods
        public void SetName(string N)
        {
            Name = N;
        }

        public void SetValue(short? v)
        {
            Value = v;
            //Alert the Gates that reference to this node to check the rest of the inputs
            //The Gate will Calculate the ouput if all the inputs are set
            foreach (customControl referencingGateOrLED in GatesThatReferenceMeAsAnInput)
            {
                referencingGateOrLED.Alert();
            }
        }

        public string GetName()
        {
            return Name;
        }

        public short? GetValue()
        {
            return Value;
        }

        #endregion

        #region Linking to Referencing Gates
        public void AddToGatesOrLEDsList(customControl referencingGateOrLED)
        {
            //Check that the gate isn't already existing in the list
            if(referencingGateOrLED.GetType() == typeof(Gate_Front)||
                referencingGateOrLED.GetType() == typeof(Output_Front))
            {
                GatesThatReferenceMeAsAnInput.Add(referencingGateOrLED);

            }
        }

        #endregion

        #region extra
        /*public string sName
        {
            get { return Name; }
            set { Name = value; }
        }*/
        #endregion

    }
}

