namespace SortingStudents
{
    partial class FormSorting
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
            this.BtnSortStudents = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSortStudents
            // 
            this.BtnSortStudents.Location = new System.Drawing.Point(12, 34);
            this.BtnSortStudents.Name = "BtnSortStudents";
            this.BtnSortStudents.Size = new System.Drawing.Size(173, 62);
            this.BtnSortStudents.TabIndex = 0;
            this.BtnSortStudents.Text = "Sort Students";
            this.BtnSortStudents.UseVisualStyleBackColor = true;
            this.BtnSortStudents.Click += new System.EventHandler(this.BtnSortStudents_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(191, 34);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResult.Size = new System.Drawing.Size(508, 348);
            this.TxtResult.TabIndex = 1;
            // 
            // FormSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnSortStudents);
            this.Name = "FormSorting";
            this.Text = "Sorting Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSortStudents;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

