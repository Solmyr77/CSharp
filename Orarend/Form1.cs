using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Orarend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] orak = new string[8, 5];

            using (var reader = new StreamReader("orarend.csv", Encoding.UTF8))
            {
                for (int i = 0; i < 34; i++)
                {
                    string[] curr_line = reader.ReadLine().Split(';');

                    int curr_day = Convert.ToInt32(curr_line[0]);
                    int periodnumber = Convert.ToInt32(curr_line[1]);
                    string period = curr_line[2];

                    Console.Write(periodnumber);
                    Console.Write(" ");
                    Console.WriteLine(curr_day);
                    orak[periodnumber, curr_day] = period;
                }
            }
        }
    }
}