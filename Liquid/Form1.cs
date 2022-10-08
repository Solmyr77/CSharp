using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace Liquid
{
    public partial class Form1 : Form
    {
        bool save_flag = false;
        bool fault_flag = false;
        string[] out_names = { "PG", "VG", "Nikotin", "Aroma", "Total" };
        double[] out_values = new double[5];
        double[] out_value_percentages = new double[5];
        double nic_mg = 0;
        double user_vg = 0;
        double user_pg = 0;
        double user_nic = 0;
        double nic_booster = 0;
        double aroma = 0;
        double volume = 0;
        string aroma_name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            bool save_flag = false;
            bool fault_flag = false;
            string[] out_names = { "PG", "VG", "Nikotin", "Undefined", "Total" };
            double[] out_values = new double[5];
            double[] out_value_percentages = new double[5];
            double nic_mg = 0;
            double user_vg = 0;
            double user_pg = 0;
            double user_nic = 0;
            double nic_booster = 0;
            double aroma = 0;
            double volume = 0;
            string aroma_name = "";
        }

        private void error_message(string text = "")
        {
            if (text == null || text.Length == 0)
            {
                MessageBox.Show("Valami nem jo gec", "Valami nem jo gec",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(text, "Hiba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            fault_flag = false;
            try
            {
                user_vg = Convert.ToDouble(tb_user_vg.Text);
                user_pg = Convert.ToDouble(tb_user_pg.Text);
                user_nic = Convert.ToDouble(tb_user_nic.Text);
                aroma_name = tb_aroma_name.Text;

                if (tb_nic_booster.Text == null || tb_nic_booster.Text.Length == 0 || tb_nic_booster.Text == "0")
                {
                    nic_booster = 0;
                }
                else
                {
                    nic_booster = Convert.ToDouble(tb_nic_booster.Text);
                }

                if (tb_aroma.Text == null || tb_aroma.Text.Length == 0 || tb_aroma.Text == "0")
                {
                    aroma = 0;
                }
                else
                {
                    aroma = Convert.ToDouble(tb_aroma.Text);
                }

                volume = Convert.ToDouble(tb_volume.Text);

                if (user_vg + user_pg != 100)
                {
                    error_message("A VG és a PG százalék összege nem egyenlő 100%-al!");
                    reset();
                    fault_flag = true;
                }
                out_values[4] = volume;
            }
            catch (Exception)
            {
                error_message();
                reset();
                fault_flag = true;
            }

            nic_mg = Math.Round(volume * user_nic, 1);
            out_values[1] = Math.Round(volume * user_vg / 100, 1); //VG ml
            if (nic_booster == 0)
            {
                out_values[2] = 0;
            }
            else
            {
                out_values[2] = Math.Round(nic_mg / nic_booster, 1); //Nic ml
            }
            out_values[3] = Math.Round(volume * aroma / 100, 1); //Aroma ml
            out_values[0] = Math.Round(volume - out_values[1] - out_values[2] - out_values[3], 1); //Pg ml

            for (int i = 0; i < out_values.Length; i++)
            {
                out_value_percentages[i] = Math.Round(out_values[i] / volume * 100, 2);
            }

            out_names[3] = aroma_name;

            if (!fault_flag)
            {
                for (int i = 0; i < out_values.Length; i++)
                {
                    save_flag = true;
                    dgv_out.Rows.Add();
                    dgv_out.Rows[i].Cells["dgv_name"].Value = out_names[i];
                    dgv_out.Rows[i].Cells["dgv_ml"].Value = out_values[i];
                    dgv_out.Rows[i].Cells["dgv_percentage"].Value = $"{out_value_percentages[i]} %";
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!save_flag)
            {
                error_message("Először készíts egy receptet!");
                reset();
            }
            else
            {
                if (aroma_name == null || aroma_name == "")
                {
                    out_names[3] = "Undefined";
                }

                string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Kopasz Corporation/LiquidCalc/recipes.txt";
                string recipe = $"Aroma neve: {out_names[3]}\r\nPG: {out_values[0]} mL\r\nVG: {out_values[1]} mL\r\nNikotin: {out_values[2]} mL\r\n" +
                    $"Aroma: {out_values[3]} mL\r\n";
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Kopasz corporation/LiquidCalc");
                File.AppendAllText(file, recipe);
                File.AppendAllText(file, "\r\n------------------------------------------------\r\n\r\n");
            }
        }

        private void btn_recipes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
