namespace Kursov
{
    partial class ForAnalitics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForAnalitics));
            this.Start_Table = new System.Windows.Forms.DataGridView();
            this.Matches = new System.Windows.Forms.DataGridView();
            this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennis_Players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress_Match = new System.Windows.Forms.DataGridView();
            this.Shot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennis_Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Game_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.Tournament_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_Match)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Table
            // 
            this.Start_Table.AllowUserToDeleteRows = false;
            this.Start_Table.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Golos Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Start_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Start_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Start_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tournament_Name,
            this.Country,
            this.Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Golos Text DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Start_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Start_Table.GridColor = System.Drawing.Color.Yellow;
            this.Start_Table.Location = new System.Drawing.Point(12, 12);
            this.Start_Table.Name = "Start_Table";
            this.Start_Table.ReadOnly = true;
            this.Start_Table.RowTemplate.Height = 24;
            this.Start_Table.Size = new System.Drawing.Size(503, 388);
            this.Start_Table.TabIndex = 1;
            this.Start_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Start_Table_CellClick_1);
            // 
            // Matches
            // 
            this.Matches.AllowUserToDeleteRows = false;
            this.Matches.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Golos Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Matches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Matches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stage,
            this.Score,
            this.Tennis_Players});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Golos Text DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Matches.DefaultCellStyle = dataGridViewCellStyle4;
            this.Matches.GridColor = System.Drawing.Color.Yellow;
            this.Matches.Location = new System.Drawing.Point(532, 12);
            this.Matches.Name = "Matches";
            this.Matches.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Golos Text Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Matches.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Matches.RowTemplate.Height = 24;
            this.Matches.Size = new System.Drawing.Size(468, 388);
            this.Matches.TabIndex = 2;
            this.Matches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Matches_CellClick);
            // 
            // Stage
            // 
            this.Stage.HeaderText = "Match Stage";
            this.Stage.Name = "Stage";
            this.Stage.ReadOnly = true;
            this.Stage.Width = 150;
            // 
            // Score
            // 
            this.Score.HeaderText = "Match Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Tennis_Players
            // 
            this.Tennis_Players.HeaderText = "Tennis Players";
            this.Tennis_Players.Name = "Tennis_Players";
            this.Tennis_Players.ReadOnly = true;
            this.Tennis_Players.Width = 150;
            // 
            // Progress_Match
            // 
            this.Progress_Match.AllowUserToDeleteRows = false;
            this.Progress_Match.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Golos Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Progress_Match.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Progress_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Progress_Match.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shot,
            this.Tennis_Player,
            this.Time,
            this.Game_Score});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Golos Text DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Progress_Match.DefaultCellStyle = dataGridViewCellStyle7;
            this.Progress_Match.GridColor = System.Drawing.Color.Yellow;
            this.Progress_Match.Location = new System.Drawing.Point(1006, 12);
            this.Progress_Match.Name = "Progress_Match";
            this.Progress_Match.ReadOnly = true;
            this.Progress_Match.RowTemplate.Height = 24;
            this.Progress_Match.Size = new System.Drawing.Size(464, 388);
            this.Progress_Match.TabIndex = 3;
            this.Progress_Match.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Progress_Match_CellClick);
            // 
            // Shot
            // 
            this.Shot.HeaderText = "Shot";
            this.Shot.Name = "Shot";
            this.Shot.ReadOnly = true;
            // 
            // Tennis_Player
            // 
            this.Tennis_Player.HeaderText = "Tennis Player";
            this.Tennis_Player.Name = "Tennis_Player";
            this.Tennis_Player.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Game_Score
            // 
            this.Game_Score.HeaderText = "Game Score";
            this.Game_Score.Name = "Game_Score";
            this.Game_Score.ReadOnly = true;
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.Green;
            this.btnStatistic.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Location = new System.Drawing.Point(12, 439);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(208, 67);
            this.btnStatistic.TabIndex = 4;
            this.btnStatistic.Text = "Reports";
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.BtnStatistic_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.BackColor = System.Drawing.Color.Green;
            this.btnSupport.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSupport.ForeColor = System.Drawing.Color.White;
            this.btnSupport.Location = new System.Drawing.Point(1116, 439);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(208, 67);
            this.btnSupport.TabIndex = 5;
            this.btnSupport.Text = "Support";
            this.btnSupport.UseVisualStyleBackColor = false;
            this.btnSupport.Click += new System.EventHandler(this.BtnSupport_Click);
            // 
            // Tournament_Name
            // 
            this.Tournament_Name.HeaderText = "Tournaments";
            this.Tournament_Name.Name = "Tournament_Name";
            this.Tournament_Name.ReadOnly = true;
            this.Tournament_Name.Width = 180;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 230;
            // 
            // ForAnalitics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 672);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.Progress_Match);
            this.Controls.Add(this.Matches);
            this.Controls.Add(this.Start_Table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForAnalitics";
            this.Text = "ForAnalitics";
            ((System.ComponentModel.ISupportInitialize)(this.Start_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_Match)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Start_Table;
        private System.Windows.Forms.DataGridView Matches;
        private System.Windows.Forms.DataGridView Progress_Match;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennis_Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game_Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennis_Players;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tournament_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}