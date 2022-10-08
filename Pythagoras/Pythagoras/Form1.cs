using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pythagoras
{
    public partial class Form1 : Form
    {
        string side_a;
        string side_b;
        string side_c;

        double side_a_value;
        double side_b_value;
        double side_c_value;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static double get_result(double val_1, double val_2)
        {
            Console.WriteLine(val_1);
            return Math.Round(Math.Sqrt(Math.Pow(val_1, 2) + Math.Pow(val_2, 2)), 3);
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            if (side_a_tb.Text == "" || side_a_tb.Text == "0")
            {
                side_a_tb.Text = Convert.ToString(get_result(side_b_value, side_c_value));
            }

            else
            {
                side_a_value = Convert.ToDouble(side_a_tb.Text);
            }

            if (side_b_tb.Text == "" || side_b_tb.Text == "0")
            {
                side_b_tb.Text = Convert.ToString(get_result(side_a_value, side_c_value));
            }

            else
            {
                side_b_value = Convert.ToDouble(side_b_tb.Text);
            }

            if (side_c_tb.Text == "" || side_c_tb.Text == "0")
            {
                side_c_tb.Text = Convert.ToString(get_result(side_a_value, side_b_value));
            }

            else
            {
                side_c_value = Convert.ToDouble(side_c_tb.Text);
            }
        }
    }
}
