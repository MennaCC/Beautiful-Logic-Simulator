using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gates_test
{
    public partial class not_button : UserControl
    {
        public not_button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UserControl1> buttons = new List<UserControl1>();

            UserControl1 newButton = new UserControl1();
            buttons.Add(newButton);
            this.Controls.Add(newButton);
        }

        private void name(object sender, EventArgs e)
        {

        }
    }
}
