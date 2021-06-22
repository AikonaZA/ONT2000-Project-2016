namespace ONT2000_Project_2016
{
    partial class Delete_Country
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
            this.bntExit = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoutryID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(223, 172);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 23);
            this.bntExit.TabIndex = 7;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(75, 172);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 6;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coutry ID";
            // 
            // txtCoutryID
            // 
            this.txtCoutryID.Location = new System.Drawing.Point(226, 111);
            this.txtCoutryID.Name = "txtCoutryID";
            this.txtCoutryID.Size = new System.Drawing.Size(100, 20);
            this.txtCoutryID.TabIndex = 8;
            // 
            // Delete_Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoutryID);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntDelete);
            this.Name = "Delete_Country";
            this.Text = "Delete_Country";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoutryID;
    }
}