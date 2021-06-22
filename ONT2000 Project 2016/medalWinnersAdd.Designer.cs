namespace ONT2000_Project_2016
{
    partial class Add_medal_Winners
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
            this.txtMedalNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMedal = new System.Windows.Forms.ComboBox();
            this.cmbParticipant = new System.Windows.Forms.ComboBox();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.cmbDiscipline = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMedalNo
            // 
            this.txtMedalNo.Location = new System.Drawing.Point(118, 188);
            this.txtMedalNo.Name = "txtMedalNo";
            this.txtMedalNo.Size = new System.Drawing.Size(100, 20);
            this.txtMedalNo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Medal No";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Award Medal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbMedal
            // 
            this.cmbMedal.FormattingEnabled = true;
            this.cmbMedal.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Bronze"});
            this.cmbMedal.Location = new System.Drawing.Point(118, 156);
            this.cmbMedal.Name = "cmbMedal";
            this.cmbMedal.Size = new System.Drawing.Size(121, 21);
            this.cmbMedal.TabIndex = 20;
            // 
            // cmbParticipant
            // 
            this.cmbParticipant.FormattingEnabled = true;
            this.cmbParticipant.Location = new System.Drawing.Point(118, 128);
            this.cmbParticipant.Name = "cmbParticipant";
            this.cmbParticipant.Size = new System.Drawing.Size(121, 21);
            this.cmbParticipant.TabIndex = 19;
            // 
            // cmbEvent
            // 
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(118, 97);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(121, 21);
            this.cmbEvent.TabIndex = 18;
            // 
            // cmbDiscipline
            // 
            this.cmbDiscipline.FormattingEnabled = true;
            this.cmbDiscipline.Location = new System.Drawing.Point(118, 66);
            this.cmbDiscipline.Name = "cmbDiscipline";
            this.cmbDiscipline.Size = new System.Drawing.Size(121, 21);
            this.cmbDiscipline.TabIndex = 17;
            this.cmbDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmbDiscipline_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Medal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Participant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Discipline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Event Medal Winners";
            // 
            // Add_medal_Winners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 283);
            this.Controls.Add(this.txtMedalNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbMedal);
            this.Controls.Add(this.cmbParticipant);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.cmbDiscipline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_medal_Winners";
            this.Text = "Add_medal_Winners";
            this.Load += new System.EventHandler(this.Add_medal_Winners_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedalNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbMedal;
        private System.Windows.Forms.ComboBox cmbParticipant;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.ComboBox cmbDiscipline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}