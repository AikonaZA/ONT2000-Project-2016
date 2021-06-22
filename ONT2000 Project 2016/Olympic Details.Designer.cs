namespace ONT2000_Project_2016
{
    partial class Olympic_Details
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
            this.DGVOlympicDetails = new System.Windows.Forms.DataGridView();
            this.ColCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntChange = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOlympicDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVOlympicDetails
            // 
            this.DGVOlympicDetails.AllowUserToAddRows = false;
            this.DGVOlympicDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOlympicDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOlympicDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCountry,
            this.ColYear});
            this.DGVOlympicDetails.Location = new System.Drawing.Point(80, 42);
            this.DGVOlympicDetails.Name = "DGVOlympicDetails";
            this.DGVOlympicDetails.Size = new System.Drawing.Size(413, 150);
            this.DGVOlympicDetails.TabIndex = 0;
            // 
            // ColCountry
            // 
            this.ColCountry.HeaderText = "Country";
            this.ColCountry.Name = "ColCountry";
            // 
            // ColYear
            // 
            this.ColYear.HeaderText = "Year";
            this.ColYear.Name = "ColYear";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(80, 221);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 1;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntChange
            // 
            this.bntChange.Location = new System.Drawing.Point(248, 221);
            this.bntChange.Name = "bntChange";
            this.bntChange.Size = new System.Drawing.Size(75, 23);
            this.bntChange.TabIndex = 2;
            this.bntChange.Text = "Change";
            this.bntChange.UseVisualStyleBackColor = true;
            this.bntChange.Click += new System.EventHandler(this.bntChange_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(418, 221);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 3;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntHome
            // 
            this.bntHome.Location = new System.Drawing.Point(248, 268);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(75, 23);
            this.bntHome.TabIndex = 4;
            this.bntHome.Text = "Home";
            this.bntHome.UseVisualStyleBackColor = true;
            // 
            // Olympic_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 303);
            this.Controls.Add(this.bntHome);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntChange);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.DGVOlympicDetails);
            this.Name = "Olympic_Details";
            this.Text = "Olympic_Details";
            ((System.ComponentModel.ISupportInitialize)(this.DGVOlympicDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVOlympicDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColYear;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntChange;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntHome;
    }
}