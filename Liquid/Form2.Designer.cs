namespace Liquid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tb_recipes = new System.Windows.Forms.TextBox();
            this.btn_finalize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_recipes
            // 
            this.tb_recipes.Location = new System.Drawing.Point(0, 0);
            this.tb_recipes.Multiline = true;
            this.tb_recipes.Name = "tb_recipes";
            this.tb_recipes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_recipes.Size = new System.Drawing.Size(426, 375);
            this.tb_recipes.TabIndex = 0;
            this.tb_recipes.WordWrap = false;
            // 
            // btn_finalize
            // 
            this.btn_finalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(69)))));
            this.btn_finalize.FlatAppearance.BorderSize = 0;
            this.btn_finalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalize.Font = new System.Drawing.Font("Century Gothic", 24.25F);
            this.btn_finalize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.btn_finalize.Location = new System.Drawing.Point(10, 381);
            this.btn_finalize.Name = "btn_finalize";
            this.btn_finalize.Size = new System.Drawing.Size(200, 60);
            this.btn_finalize.TabIndex = 1;
            this.btn_finalize.Text = "Mentés";
            this.btn_finalize.UseVisualStyleBackColor = false;
            this.btn_finalize.Click += new System.EventHandler(this.btn_finalize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(69)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 24.25F);
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.btn_close.Location = new System.Drawing.Point(216, 381);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(200, 60);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Vissza";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(424, 448);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_finalize);
            this.Controls.Add(this.tb_recipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Receptek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_recipes;
        private System.Windows.Forms.Button btn_finalize;
        private System.Windows.Forms.Button btn_close;
    }
}