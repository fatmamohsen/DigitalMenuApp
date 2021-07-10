using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void order1_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }

        private void order2_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }

        private void order3_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }
    }
}
