﻿using System;
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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void order7_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }

        private void order8_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }

        private void order9_Click(object sender, EventArgs e)
        {
            inputform f1 = new inputform();
            f1.ShowDialog();
        }
    }
}
