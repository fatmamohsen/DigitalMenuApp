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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void order4_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }

        private void order5_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }

        private void order6_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }
    }
}
