namespace ONT2000_Project_2016
{
    partial class Team
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
            this.DGVTeam1 = new System.Windows.Forms.DataGridView();
            this.ColTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeamName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeamCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntChange = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            this.cmbTeamName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTeam1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTeam1
            // 
            this.DGVTeam1.AllowUserToAddRows = false;
            this.DGVTeam1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTeam1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTeam1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTeamName,
            this.ColTeamName1,
            this.ColTeamCountry,
            this.ColTeamID});
            this.DGVTeam1.Location = new System.Drawing.Point(40, 70);
            this.DGVTeam1.Name = "DGVTeam1";
            this.DGVTeam1.Size = new System.Drawing.Size(450, 150);
            this.DGVTeam1.TabIndex = 0;
            // 
            // ColTeamName
            // 
            this.ColTeamName.HeaderText = "Team Name";
            this.ColTeamName.Name = "ColTeamName";
            // 
            // ColTeamName1
            // 
            this.ColTeamName1.HeaderText = "Team Name";
            this.ColTeamName1.Name = "ColTeamName1";
            // 
            // ColTeamCountry
            // 
            this.ColTeamCountry.HeaderText = "Team Country";
            this.ColTeamCountry.Name = "ColTeamCountry";
            // 
            // ColTeamID
            // 
            this.ColTeamID.HeaderText = "Team ID";
            this.ColTeamID.Name = "ColTeamID";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(71, 260);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 1;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntChange
            // 
            this.bntChange.Location = new System.Drawing.Point(223, 260);
            this.bntChange.Name = "bntChange";
            this.bntChange.Size = new System.Drawing.Size(75, 23);
            this.bntChange.TabIndex = 2;
            this.bntChange.Text = "Change";
            this.bntChange.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(368, 260);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 3;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // bntHome
            // 
            this.bntHome.Location = new System.Drawing.Point(223, 307);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(75, 23);
            this.bntHome.TabIndex = 4;
            this.bntHome.Text = "Home";
            this.bntHome.UseVisualStyleBackColor = true;
            // 
            // cmbTeamName
            // 
            this.cmbTeamName.FormattingEnabled = true;
            this.cmbTeamName.Location = new System.Drawing.Point(369, 25);
            this.cmbTeamName.Name = "cmbTeamName";
            this.cmbTeamName.Size = new System.Drawing.Size(121, 21);
            this.cmbTeamName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Team Name";
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTeamName);
            this.Controls.Add(this.bntHome);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntChange);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.DGVTeam1);
            this.Name = "Team";
            this.Text = "Team";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTeam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTeam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeamName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeamCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeamID;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntChange;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.ComboBox cmbTeamName;
        private System.Windows.Forms.Label label1;
    }
}