namespace ONT2000_Project_2016
{
    partial class Country
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
            this.DGVCountry = new System.Windows.Forms.DataGridView();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntChange = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCountry
            // 
            this.DGVCountry.AllowUserToAddRows = false;
            this.DGVCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCountry});
            this.DGVCountry.Location = new System.Drawing.Point(41, 50);
            this.DGVCountry.Name = "DGVCountry";
            this.DGVCountry.Size = new System.Drawing.Size(433, 156);
            this.DGVCountry.TabIndex = 0;
            // 
            // colCountry
            // 
            this.colCountry.HeaderText = "Country";
            this.colCountry.Name = "colCountry";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(41, 236);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 0;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntChange
            // 
            this.bntChange.Location = new System.Drawing.Point(199, 236);
            this.bntChange.Name = "bntChange";
            this.bntChange.Size = new System.Drawing.Size(75, 23);
            this.bntChange.TabIndex = 2;
            this.bntChange.Text = "Change";
            this.bntChange.UseVisualStyleBackColor = true;
            this.bntChange.Click += new System.EventHandler(this.bntChange_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(373, 236);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 3;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 290);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntChange);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.DGVCountry);
            this.Name = "Country";
            this.Text = "Country";
            this.Load += new System.EventHandler(this.Country_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntChange;
        private System.Windows.Forms.Button bntDelete;
    }
}