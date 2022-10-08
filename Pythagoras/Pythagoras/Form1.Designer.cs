namespace Pythagoras
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
            this.calculate_btn = new System.Windows.Forms.Button();
            this.side_a_tb = new System.Windows.Forms.TextBox();
            this.side_b_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.side_c_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculate_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculate_btn.Location = new System.Drawing.Point(214, 32);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(100, 20);
            this.calculate_btn.TabIndex = 0;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // side_a_tb
            // 
            this.side_a_tb.Location = new System.Drawing.Point(60, 6);
            this.side_a_tb.Name = "side_a_tb";
            this.side_a_tb.Size = new System.Drawing.Size(100, 20);
            this.side_a_tb.TabIndex = 1;
            // 
            // side_b_tb
            // 
            this.side_b_tb.Location = new System.Drawing.Point(214, 6);
            this.side_b_tb.Name = "side_b_tb";
            this.side_b_tb.Size = new System.Drawing.Size(100, 20);
            this.side_b_tb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B oldal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "A oldal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "C oldal:";
            // 
            // side_c_tb
            // 
            this.side_c_tb.Location = new System.Drawing.Point(368, 6);
            this.side_c_tb.Name = "side_c_tb";
            this.side_c_tb.Size = new System.Drawing.Size(100, 20);
            this.side_c_tb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(477, 61);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.side_c_tb);
            this.Controls.Add(this.side_b_tb);
            this.Controls.Add(this.side_a_tb);
            this.Controls.Add(this.calculate_btn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pythagoras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.TextBox side_a_tb;
        private System.Windows.Forms.TextBox side_b_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox side_c_tb;
    }
}

