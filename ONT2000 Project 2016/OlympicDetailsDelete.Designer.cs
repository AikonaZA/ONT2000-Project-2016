namespace ONT2000_Project_2016
{
    partial class Delete_Olympic_Details
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
            this.cmbOlympic = new System.Windows.Forms.ComboBox();
            this.bntCancel = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOlympic
            // 
            this.cmbOlympic.FormattingEnabled = true;
            this.cmbOlympic.Location = new System.Drawing.Point(125, 23);
            this.cmbOlympic.Name = "cmbOlympic";
            this.cmbOlympic.Size = new System.Drawing.Size(121, 21);
            this.cmbOlympic.TabIndex = 19;
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(171, 214);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 18;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(42, 214);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 17;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(146, 136);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 16;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(146, 87);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Country";
            // 
            // Delete_Olympic_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbOlympic);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete_Olympic_Details";
            this.Text = "Delete_Olympic_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOlympic;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}