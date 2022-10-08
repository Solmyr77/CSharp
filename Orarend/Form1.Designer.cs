namespace Orarend
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
            this.timetable = new System.Windows.Forms.DataGridView();
            this.numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // timetable
            // 
            this.timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numbers,
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday});
            this.timetable.Location = new System.Drawing.Point(12, 12);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(721, 390);
            this.timetable.TabIndex = 0;
            // 
            // numbers
            // 
            this.numbers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numbers.HeaderText = "";
            this.numbers.Name = "numbers";
            this.numbers.ReadOnly = true;
            this.numbers.Width = 21;
            // 
            // monday
            // 
            this.monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.monday.HeaderText = "Hétfő";
            this.monday.Name = "monday";
            this.monday.ReadOnly = true;
            this.monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.monday.Width = 39;
            // 
            // tuesday
            // 
            this.tuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tuesday.HeaderText = "Kedd";
            this.tuesday.Name = "tuesday";
            this.tuesday.ReadOnly = true;
            this.tuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tuesday.Width = 38;
            // 
            // wednesday
            // 
            this.wednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wednesday.HeaderText = "Szerda";
            this.wednesday.Name = "wednesday";
            this.wednesday.ReadOnly = true;
            this.wednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wednesday.Width = 46;
            // 
            // thursday
            // 
            this.thursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.thursday.HeaderText = "Csütörtök";
            this.thursday.Name = "thursday";
            this.thursday.ReadOnly = true;
            this.thursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.thursday.Width = 58;
            // 
            // friday
            // 
            this.friday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.friday.HeaderText = "Péntek";
            this.friday.Name = "friday";
            this.friday.ReadOnly = true;
            this.friday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.friday.Width = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 466);
            this.Controls.Add(this.timetable);
            this.Name = "Form1";
            this.Text = "Órarend";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView timetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
    }
}

