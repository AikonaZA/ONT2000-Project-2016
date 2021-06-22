namespace ONT2000_Project_2016
{
    partial class Home
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
            this.bntOlympic = new System.Windows.Forms.Button();
            this.bntDiscpline = new System.Windows.Forms.Button();
            this.bntEvent = new System.Windows.Forms.Button();
            this.bntTeam = new System.Windows.Forms.Button();
            this.bntCountry = new System.Windows.Forms.Button();
            this.bntParticipant = new System.Windows.Forms.Button();
            this.bntMedalWinners = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntOlympic
            // 
            this.bntOlympic.Location = new System.Drawing.Point(92, 196);
            this.bntOlympic.Name = "bntOlympic";
            this.bntOlympic.Size = new System.Drawing.Size(75, 23);
            this.bntOlympic.TabIndex = 0;
            this.bntOlympic.Text = "Olympic";
            this.bntOlympic.UseVisualStyleBackColor = true;
            this.bntOlympic.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntDiscpline
            // 
            this.bntDiscpline.Location = new System.Drawing.Point(197, 245);
            this.bntDiscpline.Name = "bntDiscpline";
            this.bntDiscpline.Size = new System.Drawing.Size(75, 23);
            this.bntDiscpline.TabIndex = 1;
            this.bntDiscpline.Text = "Discpline";
            this.bntDiscpline.UseVisualStyleBackColor = true;
            this.bntDiscpline.Click += new System.EventHandler(this.bntDiscpline_Click);
            // 
            // bntEvent
            // 
            this.bntEvent.Location = new System.Drawing.Point(197, 294);
            this.bntEvent.Name = "bntEvent";
            this.bntEvent.Size = new System.Drawing.Size(75, 23);
            this.bntEvent.TabIndex = 2;
            this.bntEvent.Text = "Event";
            this.bntEvent.UseVisualStyleBackColor = true;
            this.bntEvent.Click += new System.EventHandler(this.bntEvent_Click);
            // 
            // bntTeam
            // 
            this.bntTeam.Location = new System.Drawing.Point(92, 294);
            this.bntTeam.Name = "bntTeam";
            this.bntTeam.Size = new System.Drawing.Size(75, 23);
            this.bntTeam.TabIndex = 3;
            this.bntTeam.Text = "Team";
            this.bntTeam.UseVisualStyleBackColor = true;
            this.bntTeam.Click += new System.EventHandler(this.bntTeam_Click);
            // 
            // bntCountry
            // 
            this.bntCountry.Location = new System.Drawing.Point(92, 245);
            this.bntCountry.Name = "bntCountry";
            this.bntCountry.Size = new System.Drawing.Size(75, 23);
            this.bntCountry.TabIndex = 4;
            this.bntCountry.Text = "Country";
            this.bntCountry.UseVisualStyleBackColor = true;
            this.bntCountry.Click += new System.EventHandler(this.bntCountry_Click);
            // 
            // bntParticipant
            // 
            this.bntParticipant.Location = new System.Drawing.Point(197, 196);
            this.bntParticipant.Name = "bntParticipant";
            this.bntParticipant.Size = new System.Drawing.Size(75, 23);
            this.bntParticipant.TabIndex = 5;
            this.bntParticipant.Text = "Particapant";
            this.bntParticipant.UseVisualStyleBackColor = true;
            this.bntParticipant.Click += new System.EventHandler(this.button6_Click);
            // 
            // bntMedalWinners
            // 
            this.bntMedalWinners.Location = new System.Drawing.Point(110, 335);
            this.bntMedalWinners.Name = "bntMedalWinners";
            this.bntMedalWinners.Size = new System.Drawing.Size(128, 23);
            this.bntMedalWinners.TabIndex = 6;
            this.bntMedalWinners.Text = "Medal Winners";
            this.bntMedalWinners.UseVisualStyleBackColor = true;
            this.bntMedalWinners.Click += new System.EventHandler(this.bntMedalWinners_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 412);
            this.Controls.Add(this.bntMedalWinners);
            this.Controls.Add(this.bntParticipant);
            this.Controls.Add(this.bntCountry);
            this.Controls.Add(this.bntTeam);
            this.Controls.Add(this.bntEvent);
            this.Controls.Add(this.bntDiscpline);
            this.Controls.Add(this.bntOlympic);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntOlympic;
        private System.Windows.Forms.Button bntDiscpline;
        private System.Windows.Forms.Button bntEvent;
        private System.Windows.Forms.Button bntTeam;
        private System.Windows.Forms.Button bntCountry;
        private System.Windows.Forms.Button bntParticipant;
        private System.Windows.Forms.Button bntMedalWinners;
    }
}