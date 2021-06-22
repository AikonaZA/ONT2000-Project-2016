namespace ONT2000_Project_2016
{
    partial class Add_Participant
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
            this.cmbParticapantCountry = new System.Windows.Forms.ComboBox();
            this.cmbParticapantGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParticapantSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParticapantName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParticapantID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbParticapantCountry
            // 
            this.cmbParticapantCountry.FormattingEnabled = true;
            this.cmbParticapantCountry.Location = new System.Drawing.Point(144, 210);
            this.cmbParticapantCountry.Name = "cmbParticapantCountry";
            this.cmbParticapantCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbParticapantCountry.TabIndex = 38;
            // 
            // cmbParticapantGender
            // 
            this.cmbParticapantGender.FormattingEnabled = true;
            this.cmbParticapantGender.Location = new System.Drawing.Point(144, 150);
            this.cmbParticapantGender.Name = "cmbParticapantGender";
            this.cmbParticapantGender.Size = new System.Drawing.Size(121, 21);
            this.cmbParticapantGender.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Particapant Coutry";
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(190, 268);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 35;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(30, 268);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 33;
            this.bntAdd.Text = "Add ";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Particapant Gender";
            // 
            // txtParticapantSurname
            // 
            this.txtParticapantSurname.Location = new System.Drawing.Point(148, 105);
            this.txtParticapantSurname.Name = "txtParticapantSurname";
            this.txtParticapantSurname.Size = new System.Drawing.Size(117, 20);
            this.txtParticapantSurname.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Particapant Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Particapant Name";
            // 
            // txtParticapantName
            // 
            this.txtParticapantName.Location = new System.Drawing.Point(144, 63);
            this.txtParticapantName.Name = "txtParticapantName";
            this.txtParticapantName.Size = new System.Drawing.Size(121, 20);
            this.txtParticapantName.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Particapant ID";
            // 
            // txtParticapantID
            // 
            this.txtParticapantID.Location = new System.Drawing.Point(144, 20);
            this.txtParticapantID.Name = "txtParticapantID";
            this.txtParticapantID.Size = new System.Drawing.Size(121, 20);
            this.txtParticapantID.TabIndex = 40;
            // 
            // Add_Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtParticapantID);
            this.Controls.Add(this.cmbParticapantCountry);
            this.Controls.Add(this.cmbParticapantGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParticapantSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParticapantName);
            this.Name = "Add_Participant";
            this.Text = "Add_Participant";
            this.Load += new System.EventHandler(this.Add_Participant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParticapantCountry;
        private System.Windows.Forms.ComboBox cmbParticapantGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParticapantSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParticapantName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParticapantID;
    }
}