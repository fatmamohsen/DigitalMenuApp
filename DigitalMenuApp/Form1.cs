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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           panel2.Height = foodp2.Height;
           panel2.Top = foodp2.Top;
           userControl11.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void foodp2_Click(object sender, EventArgs e)
        {
           panel2.Height = foodp2.Height;
            panel2.Top = foodp2.Top;
            userControl21.BringToFront();
        }

        private void drinksp4_Click(object sender, EventArgs e)
        {
            panel2.Height = drinksp4.Height;
            panel2.Top = drinksp4.Top;
            userControl11.BringToFront();
        }

        private void colsep5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sweetsp3_Click(object sender, EventArgs e)
        {
            panel2.Height = sweetsp3.Height;
            panel2.Top = sweetsp3.Top;
            userControl31.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
