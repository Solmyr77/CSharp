using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculus
{
    public partial class Form1 : Form
    {
        double curr_add_reg;
        double curr_sub_reg;
        double curr_mul_reg;
        double curr_div_reg;
        string operator_reg;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            tb_display.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            tb_display.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            tb_display.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            tb_display.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            tb_display.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            tb_display.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            tb_display.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            tb_display.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            tb_display.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            tb_display.Text += "9";
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            tb_display.Text += ",";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            tb_display.Text = "";
            double curr_add_reg;
            double curr_sub_reg;
            double curr_mul_reg;
            double curr_div_reg;
            string operator_reg;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                operator_reg = "add";
                curr_add_reg = Convert.ToDouble(tb_display.Text);
                tb_display.Text = "";
            }
            catch
            {
                { }
            }
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            try
            {
                operator_reg = "subtract";
                curr_sub_reg = Convert.ToDouble(tb_display.Text);
                tb_display.Text = "";
            }
            catch
            {
                { }
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            try
            {
                operator_reg = "multiply";
                curr_mul_reg = Convert.ToDouble(tb_display.Text);
                tb_display.Text = "";
            }
            catch
            {
                { }
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            try
            {
                operator_reg = "divide";
                curr_div_reg = Convert.ToDouble(tb_display.Text);
                tb_display.Text = "";
            }
            catch
            {

            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if (operator_reg == "add")
            {
                try
                {
                    tb_display.Text.Replace(",", ".");
                    curr_add_reg += Convert.ToDouble(tb_display.Text);
                    tb_display.Text = Convert.ToString(curr_add_reg);
                }
                catch
                {
                    {
                    }
                }
            }

            else if (operator_reg == "subtract")
            {
                try
                {
                    tb_display.Text.Replace(",", ".");
                    curr_sub_reg -= Convert.ToDouble(tb_display.Text);
                    tb_display.Text = Convert.ToString(curr_sub_reg);
                }
                catch
                {
                    { }
                }
            }

            else if (operator_reg == "multiply")
            {
                try
                {
                    tb_display.Text.Replace(",", ".");
                    curr_mul_reg *= Convert.ToDouble(tb_display.Text);
                    tb_display.Text = Convert.ToString(Math.Round(curr_mul_reg, 15));
                }
                catch
                {
                    { }
                }
            }

            else if (operator_reg == "divide")
            {
                try
                {
                    tb_display.Text.Replace(",", ".");
                    curr_div_reg /= Convert.ToDouble(tb_display.Text);
                    tb_display.Text = Convert.ToString(Math.Round(curr_div_reg, 15));
                }
                catch
                {
                    { }
                }
            }
        }
    }
}
