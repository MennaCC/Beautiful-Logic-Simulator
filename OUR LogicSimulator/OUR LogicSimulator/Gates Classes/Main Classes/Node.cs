using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUR_LogicSimulator.Gates_Classes
{
    public class Node
    {
        protected string Name;
        protected short Value;
       
        public void SetName(string N)
        {
            Name = N;
        }

        public void SetValue(short v)
        {
            Value = v;
        }

        public string GetName()
        {
            return Name;
        }

        public short? GetValue()
        {
            return Value;
        }

        /*public string sName
        {
            get { return Name; }
            set { Name = value; }
        }*/


    }
}

