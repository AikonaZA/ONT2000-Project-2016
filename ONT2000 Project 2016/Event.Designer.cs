namespace ONT2000_Project_2016
{
    partial class Event
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
            this.bntDelete = new System.Windows.Forms.Button();
            this.ColEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.Button();
            this.btnAddIndviEvent = new System.Windows.Forms.Button();
            this.ColStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDisplineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.ColStadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(342, 316);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 67;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // ColEndDate
            // 
            this.ColEndDate.HeaderText = "End Date";
            this.ColEndDate.Name = "ColEndDate";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(217, 316);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 62;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnAddIndviEvent
            // 
            this.btnAddIndviEvent.Location = new System.Drawing.Point(107, 316);
            this.btnAddIndviEvent.Name = "btnAddIndviEvent";
            this.btnAddIndviEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddIndviEvent.TabIndex = 60;
            this.btnAddIndviEvent.Text = "Add";
            this.btnAddIndviEvent.UseVisualStyleBackColor = true;
            this.btnAddIndviEvent.Click += new System.EventHandler(this.btnAddIndviEvent_Click);
            // 
            // ColStartDate
            // 
            this.ColStartDate.HeaderText = "Start date";
            this.ColStartDate.Name = "ColStartDate";
            // 
            // ColEvent
            // 
            this.ColEvent.HeaderText = "Event";
            this.ColEvent.Name = "ColEvent";
            // 
            // ColDisplineName
            // 
            this.ColDisplineName.HeaderText = "Displine Name";
            this.ColDisplineName.Name = "ColDisplineName";
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDisplineName,
            this.ColEvent,
            this.ColStartDate,
            this.ColEndDate,
            this.ColStadium});
            this.dgvEvents.Location = new System.Drawing.Point(12, 78);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(537, 209);
            this.dgvEvents.TabIndex = 55;
            // 
            // ColStadium
            // 
            this.ColStadium.HeaderText = "Stadium";
            this.ColStadium.Name = "ColStadium";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(205, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 34);
            this.label14.TabIndex = 53;
            this.label14.Text = "Events";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-184, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(428, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 68;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 361);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.btnAddIndviEvent);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Name = "Event";
            this.Text = "Event";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndDate;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button btnAddIndviEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDisplineName;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStadium;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}