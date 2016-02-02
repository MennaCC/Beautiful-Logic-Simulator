using OUR_LogicSimulator.FrontEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator
{
    public partial class FormFrontEnd : Form
    {
        public FormFrontEnd()
        {
          
            InitializeComponent();

        }
        
        private void buttonGate_Click(object sender, EventArgs e)
        {
            //<summary>
                //// creates Gate_front object that creates a Gate object of type suitable to the name of the button
                //// for example a button Named "OR" will create an OR gate and call its draw function
                //// also that class is responsible for handling interactions with the gate object from the front end.
            //</summary>
            Gate_Front newGate = new Gate_Front(ActiveControl.Name.ToString());
            this.Controls.Add(newGate);

        }

        private void LED_Click(object sender, EventArgs e)
        {

        }

        private void Switch_Click(object sender, EventArgs e)
        {
            Input_front s = new Input_front();
            this.Controls.Add(s);
        }

        private void ourUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void FormFrontEnd_Load(object sender, EventArgs e)
        {

        }
    }
}

