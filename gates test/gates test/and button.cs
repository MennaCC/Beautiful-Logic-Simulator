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
    public partial class and_button : UserControl
    {
        public and_button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UserControl2> buttons1 = new List<UserControl2>();

            UserControl2 newButton = new UserControl2();
            buttons1.Add(newButton);
            this.Controls.Add(newButton);
        }
    }
}
