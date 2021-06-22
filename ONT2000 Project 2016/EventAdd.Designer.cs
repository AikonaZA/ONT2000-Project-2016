namespace ONT2000_Project_2016
{
    partial class Add_Event
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
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSadiumEvents = new System.Windows.Forms.TextBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDiscpline = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnAddIndviEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(162, 96);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(200, 20);
            this.txtEvent.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Event";
            // 
            // txtSadiumEvents
            // 
            this.txtSadiumEvents.Location = new System.Drawing.Point(162, 193);
            this.txtSadiumEvents.Name = "txtSadiumEvents";
            this.txtSadiumEvents.Size = new System.Drawing.Size(100, 20);
            this.txtSadiumEvents.TabIndex = 71;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(162, 160);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 70;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(162, 125);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 68;
            // 
            // cmbDiscpline
            // 
            this.cmbDiscpline.FormattingEnabled = true;
            this.cmbDiscpline.Location = new System.Drawing.Point(162, 57);
            this.cmbDiscpline.Name = "cmbDiscpline";
            this.cmbDiscpline.Size = new System.Drawing.Size(121, 21);
            this.cmbDiscpline.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Stadium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Discpline";
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(287, 241);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 78;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddIndviEvent
            // 
            this.btnAddIndviEvent.Location = new System.Drawing.Point(52, 241);
            this.btnAddIndviEvent.Name = "btnAddIndviEvent";
            this.btnAddIndviEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddIndviEvent.TabIndex = 77;
            this.btnAddIndviEvent.Text = "Add";
            this.btnAddIndviEvent.UseVisualStyleBackColor = true;
            this.btnAddIndviEvent.Click += new System.EventHandler(this.btnAddIndviEvent_Click);
            // 
            // Add_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 287);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.btnAddIndviEvent);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSadiumEvents);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.cmbDiscpline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Add_Event";
            this.Text = "Add_Event";
            this.Load += new System.EventHandler(this.Add_Event_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSadiumEvents;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.ComboBox cmbDiscpline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnAddIndviEvent;
    }
}