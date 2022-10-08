namespace ATM
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
            this.pin_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pin_submit = new System.Windows.Forms.Button();
            this.login_error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pin_input
            // 
            this.pin_input.Location = new System.Drawing.Point(162, 134);
            this.pin_input.Name = "pin_input";
            this.pin_input.Size = new System.Drawing.Size(261, 20);
            this.pin_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kérem adja meg a PIN kódját";
            // 
            // pin_submit
            // 
            this.pin_submit.Font = new System.Drawing.Font("Leelawadee", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_submit.Location = new System.Drawing.Point(162, 176);
            this.pin_submit.Name = "pin_submit";
            this.pin_submit.Size = new System.Drawing.Size(261, 89);
            this.pin_submit.TabIndex = 2;
            this.pin_submit.Text = "Belépés";
            this.pin_submit.UseVisualStyleBackColor = true;
            this.pin_submit.Click += new System.EventHandler(this.pin_submit_Click);
            // 
            // login_error_label
            // 
            this.login_error_label.AutoSize = true;
            this.login_error_label.Font = new System.Drawing.Font("Leelawadee", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_error_label.Location = new System.Drawing.Point(135, 23);
            this.login_error_label.Name = "login_error_label";
            this.login_error_label.Size = new System.Drawing.Size(0, 32);
            this.login_error_label.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 319);
            this.Controls.Add(this.login_error_label);
            this.Controls.Add(this.pin_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pin_input);
            this.Name = "Form1";
            this.Text = "Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pin_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pin_submit;
        private System.Windows.Forms.Label login_error_label;
    }
}

