using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace Liquid
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Refresh();
            string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Kopasz corporation/LiquidCalc/recipes.txt";
            tb_recipes.Text = File.ReadAllText(file);
        }

        private void btn_finalize_Click(object sender, EventArgs e)
        {
            string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Kopasz corporation/LiquidCalc/recipes.txt";
            File.WriteAllText(file, tb_recipes.Text);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
