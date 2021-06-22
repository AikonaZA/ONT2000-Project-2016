namespace ONT2000_Project_2016
{
    partial class Add_Team
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
            this.txtTeamId = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtTeamNames = new System.Windows.Forms.RichTextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team ID";
            // 
            // txtTeamId
            // 
            this.txtTeamId.Location = new System.Drawing.Point(169, 42);
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.Size = new System.Drawing.Size(261, 20);
            this.txtTeamId.TabIndex = 1;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(169, 97);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(261, 20);
            this.txtTeamName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(169, 143);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(261, 21);
            this.cmbCountry.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Team Names";
            // 
            // rtxtTeamNames
            // 
            this.rtxtTeamNames.Location = new System.Drawing.Point(169, 195);
            this.rtxtTeamNames.Name = "rtxtTeamNames";
            this.rtxtTeamNames.Size = new System.Drawing.Size(261, 114);
            this.rtxtTeamNames.TabIndex = 7;
            this.rtxtTeamNames.Text = "";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(81, 324);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 8;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(285, 324);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 9;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            // 
            // Add_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 370);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.rtxtTeamNames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamId);
            this.Controls.Add(this.label1);
            this.Name = "Add_Team";
            this.Text = "Add_Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamId;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtTeamNames;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntCancel;
    }
}