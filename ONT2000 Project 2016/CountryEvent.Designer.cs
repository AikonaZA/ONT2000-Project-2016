namespace ONT2000_Project_2016
{
    partial class CountryEvent
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
            this.DGVCoutryList = new System.Windows.Forms.DataGridView();
            this.ColCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEventNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEventDespc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticapantOrTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCountryList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoutryList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCoutryList
            // 
            this.DGVCoutryList.AllowUserToAddRows = false;
            this.DGVCoutryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCoutryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCoutryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCountry,
            this.ColEventNo,
            this.ColEventDespc,
            this.ColParticapantOrTeam});
            this.DGVCoutryList.Location = new System.Drawing.Point(21, 81);
            this.DGVCoutryList.Name = "DGVCoutryList";
            this.DGVCoutryList.Size = new System.Drawing.Size(813, 153);
            this.DGVCoutryList.TabIndex = 17;
            // 
            // ColCountry
            // 
            this.ColCountry.HeaderText = "Country";
            this.ColCountry.Name = "ColCountry";
            // 
            // ColEventNo
            // 
            this.ColEventNo.HeaderText = "Event No";
            this.ColEventNo.Name = "ColEventNo";
            // 
            // ColEventDespc
            // 
            this.ColEventDespc.HeaderText = "Event Description";
            this.ColEventDespc.Name = "ColEventDespc";
            // 
            // ColParticapantOrTeam
            // 
            this.ColParticapantOrTeam.HeaderText = "Participant name or Team name";
            this.ColParticapantOrTeam.Name = "ColParticapantOrTeam";
            // 
            // cmbEvent
            // 
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(336, 302);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(123, 21);
            this.cmbEvent.TabIndex = 20;
            this.cmbEvent.SelectedIndexChanged += new System.EventHandler(this.cmbEvent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Event";
            // 
            // cmbCountryList
            // 
            this.cmbCountryList.FormattingEnabled = true;
            this.cmbCountryList.Location = new System.Drawing.Point(336, 251);
            this.cmbCountryList.Name = "cmbCountryList";
            this.cmbCountryList.Size = new System.Drawing.Size(123, 21);
            this.cmbCountryList.TabIndex = 16;
            this.cmbCountryList.SelectedIndexChanged += new System.EventHandler(this.cmbCountryList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Country ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Events for Country";
            // 
            // CountryEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 339);
            this.Controls.Add(this.DGVCoutryList);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCountryList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CountryEvent";
            this.Text = "CountryEvent";
            this.Load += new System.EventHandler(this.CountryEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoutryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCoutryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEventNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEventDespc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticapantOrTeam;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCountryList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}