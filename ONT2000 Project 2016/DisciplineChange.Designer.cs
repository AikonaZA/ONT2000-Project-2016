namespace ONT2000_Project_2016
{
    partial class Change_Discipline
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
            this.bntCancel = new System.Windows.Forms.Button();
            this.txtDiscplineID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntChange = new System.Windows.Forms.Button();
            this.cmbDiscpline = new System.Windows.Forms.ComboBox();
            this.txtDiscplineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(165, 169);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 7;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            // 
            // txtDiscplineID
            // 
            this.txtDiscplineID.Location = new System.Drawing.Point(165, 81);
            this.txtDiscplineID.Name = "txtDiscplineID";
            this.txtDiscplineID.Size = new System.Drawing.Size(100, 20);
            this.txtDiscplineID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Discpline ID";
            // 
            // bntChange
            // 
            this.bntChange.Location = new System.Drawing.Point(30, 169);
            this.bntChange.Name = "bntChange";
            this.bntChange.Size = new System.Drawing.Size(75, 23);
            this.bntChange.TabIndex = 4;
            this.bntChange.Text = "Change";
            this.bntChange.UseVisualStyleBackColor = true;
            this.bntChange.Click += new System.EventHandler(this.bntChange_Click);
            // 
            // cmbDiscpline
            // 
            this.cmbDiscpline.FormattingEnabled = true;
            this.cmbDiscpline.Location = new System.Drawing.Point(151, 12);
            this.cmbDiscpline.Name = "cmbDiscpline";
            this.cmbDiscpline.Size = new System.Drawing.Size(121, 21);
            this.cmbDiscpline.TabIndex = 8;
            // 
            // txtDiscplineName
            // 
            this.txtDiscplineName.Location = new System.Drawing.Point(165, 119);
            this.txtDiscplineName.Name = "txtDiscplineName";
            this.txtDiscplineName.Size = new System.Drawing.Size(100, 20);
            this.txtDiscplineName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Discpline Name";
            // 
            // Change_Discpline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtDiscplineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDiscpline);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.txtDiscplineID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntChange);
            this.Name = "Change_Discpline";
            this.Text = "Change_Discpline";
            this.Load += new System.EventHandler(this.Change_Discpline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.TextBox txtDiscplineID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntChange;
        private System.Windows.Forms.ComboBox cmbDiscpline;
        private System.Windows.Forms.TextBox txtDiscplineName;
        private System.Windows.Forms.Label label2;
    }
}