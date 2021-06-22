namespace ONT2000_Project_2016
{
    partial class Change_Country
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.txtCoutryID = new System.Windows.Forms.TextBox();
            this.bntExit = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Country Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Coutry ID";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(270, 127);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 9;
            // 
            // txtCoutryID
            // 
            this.txtCoutryID.Location = new System.Drawing.Point(270, 78);
            this.txtCoutryID.Name = "txtCoutryID";
            this.txtCoutryID.Size = new System.Drawing.Size(100, 20);
            this.txtCoutryID.TabIndex = 8;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(270, 188);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 23);
            this.bntExit.TabIndex = 7;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(122, 188);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 6;
            this.bntAdd.Text = "Change";
            this.bntAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Country";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(270, 18);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbCountry.TabIndex = 13;
            // 
            // Change_Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 243);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.txtCoutryID);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntAdd);
            this.Name = "Change_Country";
            this.Text = "Change_Country";
            this.Load += new System.EventHandler(this.Change_Country_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.TextBox txtCoutryID;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCountry;
    }
}