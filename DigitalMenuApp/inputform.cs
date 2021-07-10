using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class inputform : Form
    {
        order o1 = new order();
        public inputform()
        {
            InitializeComponent();
        }

        private void inputform_Load(object sender, EventArgs e)
        {
            sizebox.Items.Add("Small");
            sizebox.Items.Add("Medium");
            sizebox.Items.Add("Large");
        }

        private void sizebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sizebox.Items.Add("Small");
            sizebox.Items.Add("Medium");
            sizebox.Items.Add("Large");
            o1.Size = sizebox.Text;
        }
       
        private void codebox_TextChanged(object sender, EventArgs e)
        {
            o1.Code = int.Parse(codebox.Text);
        }

        private void numberbox_TextChanged(object sender, EventArgs e)
        {
            o1.Number = int.Parse(numberbox.Text);
        }

        private void okp_Click(object sender, EventArgs e)
        {
            linkedlist l1 = new linkedlist();
            l1.add(o1);
            this.Close();
        }

        private void cancelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
