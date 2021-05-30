namespace Kursov
{
    partial class Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.btnReportByShot = new System.Windows.Forms.Button();
            this.btnReportByTournament = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblFiltr = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.chartTennisPlayers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTennisPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportByShot
            // 
            this.btnReportByShot.BackColor = System.Drawing.Color.Green;
            this.btnReportByShot.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportByShot.ForeColor = System.Drawing.Color.White;
            this.btnReportByShot.Location = new System.Drawing.Point(50, 71);
            this.btnReportByShot.Name = "btnReportByShot";
            this.btnReportByShot.Size = new System.Drawing.Size(176, 62);
            this.btnReportByShot.TabIndex = 0;
            this.btnReportByShot.Text = "Shot report";
            this.btnReportByShot.UseVisualStyleBackColor = false;
            this.btnReportByShot.Click += new System.EventHandler(this.BtnReportByShot_Click);
            // 
            // btnReportByTournament
            // 
            this.btnReportByTournament.BackColor = System.Drawing.Color.Green;
            this.btnReportByTournament.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReportByTournament.ForeColor = System.Drawing.Color.White;
            this.btnReportByTournament.Location = new System.Drawing.Point(50, 146);
            this.btnReportByTournament.Name = "btnReportByTournament";
            this.btnReportByTournament.Size = new System.Drawing.Size(176, 67);
            this.btnReportByTournament.TabIndex = 1;
            this.btnReportByTournament.Text = "Tournament report";
            this.btnReportByTournament.UseVisualStyleBackColor = false;
            this.btnReportByTournament.Click += new System.EventHandler(this.BtnReportByTournament_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.Green;
            this.btnChart.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChart.ForeColor = System.Drawing.Color.White;
            this.btnChart.Location = new System.Drawing.Point(50, 235);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(176, 78);
            this.btnChart.TabIndex = 2;
            this.btnChart.Text = "Chart tennis plyers";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.BtnChart_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Golos Text Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChoose.Location = new System.Drawing.Point(382, 9);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(347, 32);
            this.lblChoose.TabIndex = 3;
            this.lblChoose.Text = "Choose the report to form";
            this.lblChoose.Click += new System.EventHandler(this.LblChoose_Click);
            // 
            // lblFiltr
            // 
            this.lblFiltr.AutoSize = true;
            this.lblFiltr.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltr.Font = new System.Drawing.Font("Golos Text DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFiltr.Location = new System.Drawing.Point(340, 96);
            this.lblFiltr.Name = "lblFiltr";
            this.lblFiltr.Size = new System.Drawing.Size(111, 21);
            this.lblFiltr.TabIndex = 4;
            this.lblFiltr.Text = "Speed filter:";
            this.lblFiltr.Visible = false;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(457, 95);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(115, 22);
            this.txtFrom.TabIndex = 5;
            this.txtFrom.Visible = false;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(613, 95);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(116, 22);
            this.txtTo.TabIndex = 6;
            this.txtTo.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Golos Text DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(398, 61);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(53, 21);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "from:";
            this.lblFrom.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Golos Text DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(578, 61);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(32, 21);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "to:";
            this.lblTo.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 302);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.Color.Green;
            this.btnGetData.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetData.ForeColor = System.Drawing.Color.White;
            this.btnGetData.Location = new System.Drawing.Point(779, 61);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(154, 53);
            this.btnGetData.TabIndex = 10;
            this.btnGetData.Text = "Get data";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Visible = false;
            this.btnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Green;
            this.btnExport.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(50, 479);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(138, 73);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export in Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // chartTennisPlayers
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTennisPlayers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTennisPlayers.Legends.Add(legend1);
            this.chartTennisPlayers.Location = new System.Drawing.Point(271, 123);
            this.chartTennisPlayers.Name = "chartTennisPlayers";
            this.chartTennisPlayers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Player";
            this.chartTennisPlayers.Series.Add(series1);
            this.chartTennisPlayers.Size = new System.Drawing.Size(817, 429);
            this.chartTennisPlayers.TabIndex = 12;
            this.chartTennisPlayers.Text = "chart1";
            this.chartTennisPlayers.Visible = false;
            this.chartTennisPlayers.Click += new System.EventHandler(this.ChartTennisPlayers_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Golos Text DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpStart.Location = new System.Drawing.Point(457, 61);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(115, 28);
            this.dtpStart.TabIndex = 13;
            this.dtpStart.Visible = false;
            // 
            // dtpFinish
            // 
            this.dtpFinish.Font = new System.Drawing.Font("Golos Text DemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFinish.Location = new System.Drawing.Point(613, 61);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(116, 28);
            this.dtpFinish.TabIndex = 14;
            this.dtpFinish.Visible = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 600);
            this.Controls.Add(this.dtpFinish);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.chartTennisPlayers);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblFiltr);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnReportByTournament);
            this.Controls.Add(this.btnReportByShot);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTennisPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportByShot;
        private System.Windows.Forms.Button btnReportByTournament;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblFiltr;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTennisPlayers;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpFinish;
    }
}