namespace Quadratic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_calculate = new System.Windows.Forms.Button();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_x1 = new System.Windows.Forms.TextBox();
            this.tb_x2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cl_x1 = new System.Windows.Forms.Button();
            this.btn_cl_x2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.ForeColor = System.Drawing.Color.Black;
            this.btn_calculate.Location = new System.Drawing.Point(224, 74);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(100, 23);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(12, 26);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 20);
            this.tb_a.TabIndex = 1;
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(224, 26);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(100, 20);
            this.tb_c.TabIndex = 2;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(118, 26);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(100, 20);
            this.tb_b.TabIndex = 3;
            // 
            // tb_x1
            // 
            this.tb_x1.Location = new System.Drawing.Point(12, 76);
            this.tb_x1.Name = "tb_x1";
            this.tb_x1.ReadOnly = true;
            this.tb_x1.Size = new System.Drawing.Size(100, 20);
            this.tb_x1.TabIndex = 4;
            // 
            // tb_x2
            // 
            this.tb_x2.Location = new System.Drawing.Point(118, 76);
            this.tb_x2.Name = "tb_x2";
            this.tb_x2.ReadOnly = true;
            this.tb_x2.Size = new System.Drawing.Size(100, 20);
            this.tb_x2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "X2:";
            // 
            // btn_cl_x1
            // 
            this.btn_cl_x1.ForeColor = System.Drawing.Color.Black;
            this.btn_cl_x1.Location = new System.Drawing.Point(12, 102);
            this.btn_cl_x1.Name = "btn_cl_x1";
            this.btn_cl_x1.Size = new System.Drawing.Size(100, 23);
            this.btn_cl_x1.TabIndex = 11;
            this.btn_cl_x1.Text = "Copy";
            this.btn_cl_x1.UseVisualStyleBackColor = true;
            this.btn_cl_x1.Click += new System.EventHandler(this.btn_cl_x1_Click);
            // 
            // btn_cl_x2
            // 
            this.btn_cl_x2.ForeColor = System.Drawing.Color.Black;
            this.btn_cl_x2.Location = new System.Drawing.Point(118, 102);
            this.btn_cl_x2.Name = "btn_cl_x2";
            this.btn_cl_x2.Size = new System.Drawing.Size(100, 23);
            this.btn_cl_x2.TabIndex = 12;
            this.btn_cl_x2.Text = "Copy";
            this.btn_cl_x2.UseVisualStyleBackColor = true;
            this.btn_cl_x2.Click += new System.EventHandler(this.btn_cl_x2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 140);
            this.Controls.Add(this.btn_cl_x2);
            this.Controls.Add(this.btn_cl_x1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_x2);
            this.Controls.Add(this.tb_x1);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_c);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.btn_calculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quadratic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_x1;
        private System.Windows.Forms.TextBox tb_x2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cl_x1;
        private System.Windows.Forms.Button btn_cl_x2;
    }
}

