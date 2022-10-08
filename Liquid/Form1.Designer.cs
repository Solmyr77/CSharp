using System.Drawing;

namespace Liquid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_user_vg = new System.Windows.Forms.TextBox();
            this.tb_user_nic = new System.Windows.Forms.TextBox();
            this.tb_user_pg = new System.Windows.Forms.TextBox();
            this.tb_nic_booster = new System.Windows.Forms.TextBox();
            this.tb_aroma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.tb_volume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_out = new System.Windows.Forms.DataGridView();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ml = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_aroma_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_recipes = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_user_vg
            // 
            this.tb_user_vg.Location = new System.Drawing.Point(12, 29);
            this.tb_user_vg.Name = "tb_user_vg";
            this.tb_user_vg.Size = new System.Drawing.Size(100, 23);
            this.tb_user_vg.TabIndex = 0;
            this.tb_user_vg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_user_nic
            // 
            this.tb_user_nic.Location = new System.Drawing.Point(12, 143);
            this.tb_user_nic.Name = "tb_user_nic";
            this.tb_user_nic.Size = new System.Drawing.Size(100, 23);
            this.tb_user_nic.TabIndex = 2;
            this.tb_user_nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_user_pg
            // 
            this.tb_user_pg.Location = new System.Drawing.Point(12, 85);
            this.tb_user_pg.Name = "tb_user_pg";
            this.tb_user_pg.Size = new System.Drawing.Size(100, 23);
            this.tb_user_pg.TabIndex = 1;
            this.tb_user_pg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_nic_booster
            // 
            this.tb_nic_booster.Location = new System.Drawing.Point(12, 198);
            this.tb_nic_booster.Name = "tb_nic_booster";
            this.tb_nic_booster.Size = new System.Drawing.Size(100, 23);
            this.tb_nic_booster.TabIndex = 3;
            this.tb_nic_booster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_aroma
            // 
            this.tb_aroma.Location = new System.Drawing.Point(12, 256);
            this.tb_aroma.Name = "tb_aroma";
            this.tb_aroma.Size = new System.Drawing.Size(100, 23);
            this.tb_aroma.TabIndex = 4;
            this.tb_aroma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "PG Százalék";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "VG Százalék";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nikotin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nikotin booster";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aroma százalék";
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(69)))));
            this.btn_calculate.FlatAppearance.BorderSize = 0;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculate.Font = new System.Drawing.Font("Century Gothic", 24.25F);
            this.btn_calculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.btn_calculate.Location = new System.Drawing.Point(12, 400);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(171, 79);
            this.btn_calculate.TabIndex = 7;
            this.btn_calculate.Text = "Számol";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // tb_volume
            // 
            this.tb_volume.Location = new System.Drawing.Point(12, 362);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(100, 23);
            this.tb_volume.TabIndex = 6;
            this.tb_volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hány mL liquidet akarsz?";
            // 
            // dgv_out
            // 
            this.dgv_out.AllowUserToAddRows = false;
            this.dgv_out.AllowUserToDeleteRows = false;
            this.dgv_out.AllowUserToResizeColumns = false;
            this.dgv_out.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_out.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_out.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_out.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_out.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_name,
            this.dgv_ml,
            this.dgv_percentage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_out.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_out.Location = new System.Drawing.Point(22, 22);
            this.dgv_out.Name = "dgv_out";
            this.dgv_out.ReadOnly = true;
            this.dgv_out.RowHeadersWidth = 20;
            this.dgv_out.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_out.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_out.Size = new System.Drawing.Size(323, 136);
            this.dgv_out.TabIndex = 10;
            // 
            // dgv_name
            // 
            this.dgv_name.HeaderText = "Anyag";
            this.dgv_name.Name = "dgv_name";
            this.dgv_name.ReadOnly = true;
            this.dgv_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgv_ml
            // 
            this.dgv_ml.HeaderText = "mL";
            this.dgv_ml.Name = "dgv_ml";
            this.dgv_ml.ReadOnly = true;
            this.dgv_ml.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgv_percentage
            // 
            this.dgv_percentage.HeaderText = "Százalék";
            this.dgv_percentage.Name = "dgv_percentage";
            this.dgv_percentage.ReadOnly = true;
            this.dgv_percentage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = global::Liquid.Properties.Resources.ejuice_clipart;
            this.pictureBox1.Location = new System.Drawing.Point(-58, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tb_aroma_name);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btn_calculate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tb_volume);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 498);
            this.panel1.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Aroma neve";
            // 
            // tb_aroma_name
            // 
            this.tb_aroma_name.Location = new System.Drawing.Point(12, 316);
            this.tb_aroma_name.Name = "tb_aroma_name";
            this.tb_aroma_name.Size = new System.Drawing.Size(100, 23);
            this.tb_aroma_name.TabIndex = 5;
            this.tb_aroma_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label14.Location = new System.Drawing.Point(116, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "mL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label13.Location = new System.Drawing.Point(118, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "mg/mL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.label12.Location = new System.Drawing.Point(118, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "mg/mL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Helvetica Rounded", 12F);
            this.label11.Location = new System.Drawing.Point(118, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Helvetica Rounded", 12F);
            this.label10.Location = new System.Drawing.Point(118, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Helvetica Rounded", 12F);
            this.label9.Location = new System.Drawing.Point(118, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btn_recipes);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.dgv_out);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(207, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 495);
            this.panel2.TabIndex = 15;
            // 
            // btn_recipes
            // 
            this.btn_recipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(69)))));
            this.btn_recipes.FlatAppearance.BorderSize = 0;
            this.btn_recipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recipes.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btn_recipes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.btn_recipes.Location = new System.Drawing.Point(249, 164);
            this.btn_recipes.Name = "btn_recipes";
            this.btn_recipes.Size = new System.Drawing.Size(96, 28);
            this.btn_recipes.TabIndex = 14;
            this.btn_recipes.Text = "Receptek";
            this.btn_recipes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_recipes.UseVisualStyleBackColor = false;
            this.btn_recipes.Click += new System.EventHandler(this.btn_recipes_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(69)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.btn_save.Location = new System.Drawing.Point(22, 164);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 28);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Mentés";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_aroma);
            this.Controls.Add(this.tb_nic_booster);
            this.Controls.Add(this.tb_user_pg);
            this.Controls.Add(this.tb_user_nic);
            this.Controls.Add(this.tb_user_vg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Liquid Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user_vg;
        private System.Windows.Forms.TextBox tb_user_nic;
        private System.Windows.Forms.TextBox tb_user_pg;
        private System.Windows.Forms.TextBox tb_nic_booster;
        private System.Windows.Forms.TextBox tb_aroma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox tb_volume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_out;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ml;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_percentage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_aroma_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_recipes;
    }
}

