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
    public partial class Form1 : Form
    {
        string user_pin = "1234";
        int login_error_counter = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void pin_submit_Click(object sender, EventArgs e)
        {
            if (this.pin_input.Text == user_pin)
            {
                this.pin_input.Text = "";
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (this.pin_input.Text == "")
            {
                this.login_error_label.Text = "Kérem adja meg a PIN Kódot.";
            }
            else
            {
                this.pin_input.Text = "";
                login_error_counter--;
                this.login_error_label.Text = $"Helytelen PIN.\nMaradt próbálkozások: {login_error_counter}";
            }
            if (login_error_counter <= 0)
            {
                Application.Exit();
            }
        }
    }
}
