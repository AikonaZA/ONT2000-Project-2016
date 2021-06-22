namespace ONT2000_Project_2016
{
    partial class CountryAdd
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
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.txtCoutryID = new System.Windows.Forms.TextBox();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(33, 146);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 0;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(181, 146);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 23);
            this.bntExit.TabIndex = 1;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            // 
            // txtCoutryID
            // 
            this.txtCoutryID.Location = new System.Drawing.Point(181, 36);
            this.txtCoutryID.Name = "txtCoutryID";
            this.txtCoutryID.Size = new System.Drawing.Size(100, 20);
            this.txtCoutryID.TabIndex = 2;
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(181, 85);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coutry ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Country Name";
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.txtCoutryID);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntAdd);
            this.Name = "AddCountry";
            this.Text = "AddCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.TextBox txtCoutryID;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}