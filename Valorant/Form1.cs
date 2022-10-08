﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valorant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 300;

            for (int i = 0; i <= 300; i++)
            {
                Thread.Sleep(3);
                progressBar1.Value = i;
            }

            MessageBox.Show("Sikeresen letörölted a valorantot", "Valorant",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
