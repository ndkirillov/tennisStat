namespace Kursov
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.Start_Table = new System.Windows.Forms.DataGridView();
            this.Tournament_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matches = new System.Windows.Forms.DataGridView();
            this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennis_Players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_Start = new System.Windows.Forms.Button();
            this.Register_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matches)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Table
            // 
            this.Start_Table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Start_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Start_Table.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Golos Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Start_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Start_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Start_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tournament_Name,
            this.Country,
            this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Start_Table.DefaultCellStyle = dataGridViewCellStyle3;
            this.Start_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Start_Table.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Start_Table.Location = new System.Drawing.Point(11, 10);
            this.Start_Table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_Table.Name = "Start_Table";
            this.Start_Table.ReadOnly = true;
            this.Start_Table.RowTemplate.Height = 24;
            this.Start_Table.Size = new System.Drawing.Size(537, 307);
            this.Start_Table.TabIndex = 0;
            this.Start_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Start_Table_CellClick);
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
            this.Country.Width = 230;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 280;
            // 
            // Matches
            // 
            this.Matches.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Matches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Matches.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Golos Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Matches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Matches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stage,
            this.Score,
            this.Tennis_Players});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Matches.DefaultCellStyle = dataGridViewCellStyle6;
            this.Matches.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Matches.Location = new System.Drawing.Point(556, 10);
            this.Matches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Matches.Name = "Matches";
            this.Matches.ReadOnly = true;
            this.Matches.RowTemplate.Height = 24;
            this.Matches.Size = new System.Drawing.Size(556, 307);
            this.Matches.TabIndex = 1;
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
            this.Score.Width = 150;
            // 
            // Tennis_Players
            // 
            this.Tennis_Players.HeaderText = "Tennis Players";
            this.Tennis_Players.Name = "Tennis_Players";
            this.Tennis_Players.ReadOnly = true;
            this.Tennis_Players.Width = 200;
            // 
            // Login_Start
            // 
            this.Login_Start.BackColor = System.Drawing.Color.Green;
            this.Login_Start.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_Start.ForeColor = System.Drawing.Color.White;
            this.Login_Start.Location = new System.Drawing.Point(340, 341);
            this.Login_Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_Start.Name = "Login_Start";
            this.Login_Start.Size = new System.Drawing.Size(331, 53);
            this.Login_Start.TabIndex = 2;
            this.Login_Start.Text = "Log in for more...";
            this.Login_Start.UseVisualStyleBackColor = false;
            // 
            // Register_Start
            // 
            this.Register_Start.BackColor = System.Drawing.Color.Green;
            this.Register_Start.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register_Start.ForeColor = System.Drawing.Color.White;
            this.Register_Start.Location = new System.Drawing.Point(340, 407);
            this.Register_Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register_Start.Name = "Register_Start";
            this.Register_Start.Size = new System.Drawing.Size(331, 50);
            this.Register_Start.TabIndex = 3;
            this.Register_Start.Text = "Register";
            this.Register_Start.UseVisualStyleBackColor = false;
            this.Register_Start.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 491);
            this.Controls.Add(this.Register_Start);
            this.Controls.Add(this.Login_Start);
            this.Controls.Add(this.Matches);
            this.Controls.Add(this.Start_Table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.Start_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Start_Table;
        private System.Windows.Forms.DataGridView Matches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tournament_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennis_Players;
        private System.Windows.Forms.Button Login_Start;
        private System.Windows.Forms.Button Register_Start;
    }
}