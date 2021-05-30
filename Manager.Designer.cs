namespace Kursov
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.Start_Table = new System.Windows.Forms.DataGridView();
            this.Tournament_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matches = new System.Windows.Forms.DataGridView();
            this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennis_Players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress_Match = new System.Windows.Forms.DataGridView();
            this.Shot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennis_Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Game_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_Match)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Table
            // 
            this.Start_Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Golos Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.Start_Table.Location = new System.Drawing.Point(32, 18);
            this.Start_Table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_Table.Name = "Start_Table";
            this.Start_Table.RowTemplate.Height = 24;
            this.Start_Table.Size = new System.Drawing.Size(287, 315);
            this.Start_Table.TabIndex = 2;
            this.Start_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Start_Table_CellClick);
            // 
            // Tournament_Name
            // 
            this.Tournament_Name.HeaderText = "Tournaments";
            this.Tournament_Name.Name = "Tournament_Name";
            this.Tournament_Name.Width = 130;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.Width = 130;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 200;
            // 
            // Matches
            // 
            this.Matches.AllowUserToDeleteRows = false;
            this.Matches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Golos Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.Matches.Location = new System.Drawing.Point(362, 18);
            this.Matches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.Matches.Size = new System.Drawing.Size(351, 315);
            this.Matches.TabIndex = 3;
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
            this.Progress_Match.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Golos Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.Progress_Match.Location = new System.Drawing.Point(726, 18);
            this.Progress_Match.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Progress_Match.Name = "Progress_Match";
            this.Progress_Match.ReadOnly = true;
            this.Progress_Match.RowTemplate.Height = 24;
            this.Progress_Match.Size = new System.Drawing.Size(341, 315);
            this.Progress_Match.TabIndex = 4;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(32, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Tennis Player";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(362, 380);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Profile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(32, 433);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "Change Tennis Player Information";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 548);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Progress_Match);
            this.Controls.Add(this.Matches);
            this.Controls.Add(this.Start_Table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Manager";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.Start_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Progress_Match)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Start_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tournament_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridView Matches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennis_Players;
        private System.Windows.Forms.DataGridView Progress_Match;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennis_Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game_Score;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}