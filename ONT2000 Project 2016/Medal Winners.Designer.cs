namespace ONT2000_Project_2016
{
    partial class Medal_Winners
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
            this.DGVMedalwinners = new System.Windows.Forms.DataGridView();
            this.ColDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntChange = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedalwinners)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMedalwinners
            // 
            this.DGVMedalwinners.AllowUserToAddRows = false;
            this.DGVMedalwinners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMedalwinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedalwinners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDiscipline,
            this.ColEvent,
            this.ColParticipant,
            this.ColMedal,
            this.ColMedalNo});
            this.DGVMedalwinners.Location = new System.Drawing.Point(32, 12);
            this.DGVMedalwinners.Name = "DGVMedalwinners";
            this.DGVMedalwinners.Size = new System.Drawing.Size(549, 150);
            this.DGVMedalwinners.TabIndex = 0;
            // 
            // ColDiscipline
            // 
            this.ColDiscipline.HeaderText = "Discipline";
            this.ColDiscipline.Name = "ColDiscipline";
            // 
            // ColEvent
            // 
            this.ColEvent.HeaderText = "Event";
            this.ColEvent.Name = "ColEvent";
            // 
            // ColParticipant
            // 
            this.ColParticipant.HeaderText = "Participant";
            this.ColParticipant.Name = "ColParticipant";
            // 
            // ColMedal
            // 
            this.ColMedal.HeaderText = "Medal";
            this.ColMedal.Name = "ColMedal";
            // 
            // ColMedalNo
            // 
            this.ColMedalNo.HeaderText = "Medal No";
            this.ColMedalNo.Name = "ColMedalNo";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(41, 194);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 1;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntChange
            // 
            this.bntChange.Location = new System.Drawing.Point(251, 194);
            this.bntChange.Name = "bntChange";
            this.bntChange.Size = new System.Drawing.Size(75, 23);
            this.bntChange.TabIndex = 2;
            this.bntChange.Text = "Change";
            this.bntChange.UseVisualStyleBackColor = true;
            this.bntChange.Click += new System.EventHandler(this.bntChange_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(434, 194);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 3;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // Medal_Winners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 267);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntChange);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.DGVMedalwinners);
            this.Name = "Medal_Winners";
            this.Text = "Medal_Winners";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedalwinners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMedalwinners;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedalNo;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntChange;
        private System.Windows.Forms.Button bntDelete;
    }
}