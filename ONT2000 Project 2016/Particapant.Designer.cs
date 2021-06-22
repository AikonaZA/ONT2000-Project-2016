namespace ONT2000_Project_2016
{
    partial class Particapant
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
            this.label5 = new System.Windows.Forms.Label();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.ColParticapantCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticapantGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticapantSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticapantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParitcipantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvParticapant = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticapant)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Particapant";
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(588, 315);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 23;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(354, 315);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntUpdate.TabIndex = 22;
            this.bntUpdate.Text = "Update";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(128, 315);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 21;
            this.bntAdd.Text = "Add ";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // ColParticapantCountry
            // 
            this.ColParticapantCountry.HeaderText = "Particapant Country";
            this.ColParticapantCountry.Name = "ColParticapantCountry";
            // 
            // ColParticapantGender
            // 
            this.ColParticapantGender.HeaderText = "Particapant Gender";
            this.ColParticapantGender.Name = "ColParticapantGender";
            // 
            // ColParticapantSurname
            // 
            this.ColParticapantSurname.HeaderText = "Particapant Surname";
            this.ColParticapantSurname.Name = "ColParticapantSurname";
            // 
            // ColParticapantName
            // 
            this.ColParticapantName.HeaderText = "Particapant Name";
            this.ColParticapantName.Name = "ColParticapantName";
            // 
            // ColParitcipantId
            // 
            this.ColParitcipantId.HeaderText = "Particapant ID";
            this.ColParitcipantId.Name = "ColParitcipantId";
            this.ColParitcipantId.Visible = false;
            // 
            // dgvParticapant
            // 
            this.dgvParticapant.AllowUserToAddRows = false;
            this.dgvParticapant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParticapant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticapant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColParitcipantId,
            this.ColParticapantName,
            this.ColParticapantSurname,
            this.ColParticapantGender,
            this.ColParticapantCountry});
            this.dgvParticapant.Location = new System.Drawing.Point(33, 83);
            this.dgvParticapant.Name = "dgvParticapant";
            this.dgvParticapant.Size = new System.Drawing.Size(779, 207);
            this.dgvParticapant.TabIndex = 15;
            // 
            // Particapant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 445);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntUpdate);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.dgvParticapant);
            this.Name = "Particapant";
            this.Text = "Particapant";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticapant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticapantCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticapantGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticapantSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticapantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParitcipantId;
        private System.Windows.Forms.DataGridView dgvParticapant;
    }
}