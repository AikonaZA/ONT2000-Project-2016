namespace ONT2000_Project_2016
{
    partial class Add_Discipline
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisciplineName = new System.Windows.Forms.TextBox();
            this.bntCancel = new System.Windows.Forms.Button();
            this.txtDisciplineID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(51, 167);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 0;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discpline Name";
            // 
            // txtDiscpineName
            // 
            this.txtDisciplineName.Location = new System.Drawing.Point(186, 82);
            this.txtDisciplineName.Name = "txtDiscpineName";
            this.txtDisciplineName.Size = new System.Drawing.Size(100, 20);
            this.txtDisciplineName.TabIndex = 2;
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(186, 167);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 3;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            // 
            // txtDiscplineID
            // 
            this.txtDisciplineID.Location = new System.Drawing.Point(186, 39);
            this.txtDisciplineID.Name = "txtDiscplineID";
            this.txtDisciplineID.Size = new System.Drawing.Size(100, 20);
            this.txtDisciplineID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discpline ID";
            // 
            // Add_Discpline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 229);
            this.Controls.Add(this.txtDisciplineID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.txtDisciplineName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntAdd);
            this.Name = "Add_Discpline";
            this.Text = "Add_Discpline";
            this.Load += new System.EventHandler(this.Add_Discpline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDisciplineName;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.TextBox txtDisciplineID;
        private System.Windows.Forms.Label label2;
    }
}