using OUR_LogicSimulator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decent_Custom_Logic_Simulator.FrontEnd
{
    public partial class Gate_Front : customControl
    {
        public Gate_Front(string gateType)
        {
            InitializeComponent();
            this.gateType = gateType;           
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            createGateDueToType(pe);
        }

        #region Private Attributes
        private string gateType = null;
        #endregion

        private void createGateDueToType(PaintEventArgs e)
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
            g.Draw(e);

        }
        private void rectangleShape4_MouseClick(object sender, MouseEventArgs e)
        {
            this.generateNode(rectangleShape4, this.Location, e);
        }
}
}
