namespace Kursov
{
    partial class ShotShowDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShotShowDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPutRate = new System.Windows.Forms.Label();
            this.lblPutSpeed = new System.Windows.Forms.Label();
            this.lblPutType = new System.Windows.Forms.Label();
            this.lblSpeedRate = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPutRate);
            this.panel1.Controls.Add(this.lblPutSpeed);
            this.panel1.Controls.Add(this.lblPutType);
            this.panel1.Controls.Add(this.lblSpeedRate);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 227);
            this.panel1.TabIndex = 0;
            // 
            // lblPutRate
            // 
            this.lblPutRate.AutoSize = true;
            this.lblPutRate.Location = new System.Drawing.Point(130, 154);
            this.lblPutRate.Name = "lblPutRate";
            this.lblPutRate.Size = new System.Drawing.Size(0, 17);
            this.lblPutRate.TabIndex = 6;
            // 
            // lblPutSpeed
            // 
            this.lblPutSpeed.AutoSize = true;
            this.lblPutSpeed.Location = new System.Drawing.Point(130, 112);
            this.lblPutSpeed.Name = "lblPutSpeed";
            this.lblPutSpeed.Size = new System.Drawing.Size(0, 17);
            this.lblPutSpeed.TabIndex = 5;
            // 
            // lblPutType
            // 
            this.lblPutType.AutoSize = true;
            this.lblPutType.Location = new System.Drawing.Point(130, 70);
            this.lblPutType.Name = "lblPutType";
            this.lblPutType.Size = new System.Drawing.Size(0, 17);
            this.lblPutType.TabIndex = 4;
            // 
            // lblSpeedRate
            // 
            this.lblSpeedRate.AutoSize = true;
            this.lblSpeedRate.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeedRate.Location = new System.Drawing.Point(20, 177);
            this.lblSpeedRate.Name = "lblSpeedRate";
            this.lblSpeedRate.Size = new System.Drawing.Size(103, 24);
            this.lblSpeedRate.TabIndex = 3;
            this.lblSpeedRate.Text = "Spin rate:";
            this.lblSpeedRate.Click += new System.EventHandler(this.LblSpeedRate_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed.Location = new System.Drawing.Point(20, 130);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(125, 24);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Speed shot:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(20, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(112, 24);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type shot:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Golos Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(110, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(245, 48);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // ShotShowDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 251);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShotShowDialog";
            this.Text = "ShotShowDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPutRate;
        private System.Windows.Forms.Label lblPutSpeed;
        private System.Windows.Forms.Label lblPutType;
        private System.Windows.Forms.Label lblSpeedRate;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
    }
}