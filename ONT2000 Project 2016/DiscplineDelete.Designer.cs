namespace ONT2000_Project_2016
{
    partial class Delete_Discpline
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
            this.txtDiscpline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(167, 195);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 7;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // txtDiscpline
            // 
            this.txtDiscpline.Location = new System.Drawing.Point(167, 107);
            this.txtDiscpline.Name = "txtDiscpline";
            this.txtDiscpline.Size = new System.Drawing.Size(100, 20);
            this.txtDiscpline.TabIndex = 6;
            this.txtDiscpline.TextChanged += new System.EventHandler(this.txtDiscpline_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Discpline";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(32, 195);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 4;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Delete_Discpline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.txtDiscpline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntAdd);
            this.Name = "Delete_Discpline";
            this.Text = "Delete_Discpline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.TextBox txtDiscpline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}