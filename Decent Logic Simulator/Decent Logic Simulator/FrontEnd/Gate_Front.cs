using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUR_LogicSimulator;

namespace Decent_Logic_Simulator.FrontEnd
{
    public partial class Gate_Front : DecentUserControl
    {
        public Gate_Front(string gateType)
        {
            InitializeComponent();
            this.gateType = gateType;
        }

        //private void OurUserControl_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
        //    {
        //         OurLocation = e.Location;
        //    }
            
        //}

        public Point getLoaction()
        {
            return this.Location;
        }

        #region Private Attributes
        private string gateType = null;
        #endregion

        private void createGateDueToType(object sender, PaintEventArgs e)
        {

            //switch can be replaced by a one line of code using runtime Creation ((gotta GOOGLE it))
            Gate g;
            switch (gateType)
            {
                case "OR":
                    g = new OR();
                    break;
                case "NOT":
                    g = new NOT();
                    break;
                case "AND":
                    g = new AND();
                    break;
                case "NAND":
                    g = new NAND();
                    break;

                default:
                    g = null;
                    break;
            }
            g.Draw(sender, e);

        }

    }
}
