using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form2 : Form
    {
        int available_value = 127500;
        int deposit_value = 0;
        int withdraw_value = 0;

        public Form2()
        {
            InitializeComponent();
            this.available_label.Text = $"{available_value.ToString()} Ft";
        }

        void error_message()
        {
            MessageBox.Show("Helytelen érték", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deposit_button_Click(object sender, EventArgs e)
        {
            try
            {
                deposit_value = Convert.ToInt32(deposit_input.Text);
            }

            catch
            {
                error_message();
                return;
            }

            if (deposit_value <= 0)
            {
                error_message();
                return;
            }

            else
            {
                available_value += deposit_value;
                available_label.Text = $"{available_value.ToString()} Ft";
            }
        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
            if (available_value <= 0 || available_value < withdraw_value)
            {
                MessageBox.Show("Nincs elég fedezet", "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                withdraw_value = Convert.ToInt32(withdraw_input.Text);
            }

            catch
            {
                error_message();
                return;
            }

            if (withdraw_value <= 0)
            {
                error_message();
                return;
            }

            else
            {
                available_value -= withdraw_value;
                if (available_value < 0)
                {
                    MessageBox.Show("Nincs elég fedezet", "Hiba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                available_label.Text = $"{available_value.ToString()} Ft";
            }
        }
    }
}
