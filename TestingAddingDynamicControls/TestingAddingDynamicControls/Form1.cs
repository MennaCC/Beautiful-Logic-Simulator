using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace TestingAddingDynamicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TestingUserControl> buttons = new List<TestingUserControl>();
            
                TestingUserControl newButton = new TestingUserControl();
                newButton.BackColor = Color.Pink;
                buttons.Add(newButton);
                this.Controls.Add(newButton);
        }
    }
}
