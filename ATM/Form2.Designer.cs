namespace ATM
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.available_label = new System.Windows.Forms.Label();
            this.deposit_button = new System.Windows.Forms.Button();
            this.withdraw_button = new System.Windows.Forms.Button();
            this.withdraw_input = new System.Windows.Forms.TextBox();
            this.deposit_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elérhető egyenleg:";
            // 
            // available_label
            // 
            this.available_label.AutoSize = true;
            this.available_label.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_label.Location = new System.Drawing.Point(146, 107);
            this.available_label.Name = "available_label";
            this.available_label.Size = new System.Drawing.Size(0, 40);
            this.available_label.TabIndex = 1;
            // 
            // deposit_button
            // 
            this.deposit_button.Location = new System.Drawing.Point(39, 212);
            this.deposit_button.Name = "deposit_button";
            this.deposit_button.Size = new System.Drawing.Size(154, 70);
            this.deposit_button.TabIndex = 2;
            this.deposit_button.Text = "Deposit";
            this.deposit_button.UseVisualStyleBackColor = true;
            this.deposit_button.Click += new System.EventHandler(this.deposit_button_Click);
            // 
            // withdraw_button
            // 
            this.withdraw_button.Location = new System.Drawing.Point(327, 212);
            this.withdraw_button.Name = "withdraw_button";
            this.withdraw_button.Size = new System.Drawing.Size(154, 70);
            this.withdraw_button.TabIndex = 3;
            this.withdraw_button.Text = "Withdraw";
            this.withdraw_button.UseVisualStyleBackColor = true;
            this.withdraw_button.Click += new System.EventHandler(this.withdraw_button_Click);
            // 
            // withdraw_input
            // 
            this.withdraw_input.Location = new System.Drawing.Point(327, 288);
            this.withdraw_input.Name = "withdraw_input";
            this.withdraw_input.Size = new System.Drawing.Size(154, 20);
            this.withdraw_input.TabIndex = 4;
            // 
            // deposit_input
            // 
            this.deposit_input.Location = new System.Drawing.Point(39, 288);
            this.deposit_input.Name = "deposit_input";
            this.deposit_input.Size = new System.Drawing.Size(154, 20);
            this.deposit_input.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.deposit_input);
            this.Controls.Add(this.withdraw_input);
            this.Controls.Add(this.withdraw_button);
            this.Controls.Add(this.deposit_button);
            this.Controls.Add(this.available_label);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label available_label;
        private System.Windows.Forms.Button deposit_button;
        private System.Windows.Forms.Button withdraw_button;
        private System.Windows.Forms.TextBox withdraw_input;
        private System.Windows.Forms.TextBox deposit_input;
    }
}