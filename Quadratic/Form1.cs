using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        double c = 0;

        double result_x1 = 0;
        double result_x2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void error_message()
        {
            MessageBox.Show("Valami nem jo gec", "Valami nem jo gec",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clear()
        {
            tb_a.Text = "";
            tb_b.Text = "";
            tb_c.Text = "";
            tb_x1.Text = "";
            tb_x2.Text = "";
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(tb_a.Text);
                b = Convert.ToDouble(tb_b.Text);
                c = Convert.ToDouble(tb_c.Text);
            }

            catch (Exception)
            {
                clear();
                error_message();
            }


            try
            {
                result_x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
                result_x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;

                tb_x1.Text = Convert.ToString(Math.Round(result_x1, 3));
                tb_x2.Text = Convert.ToString(Math.Round(result_x2, 3));
            }

            catch (Exception)
            {
                clear();
                error_message();
            }
        }

        private void btn_cl_x1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Convert.ToString(Math.Round(result_x1, 3)));
        }

        private void btn_cl_x2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Convert.ToString(Math.Round(result_x2, 3)));
        }
    }
}
