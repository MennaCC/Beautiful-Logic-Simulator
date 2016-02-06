using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decent_Custom_Logic_Simulator
{
    abstract class SingletonForm
    {
        static Form1 instance;
        static public Form1 getFormInstance()
        {
            if (instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }
    }
}
