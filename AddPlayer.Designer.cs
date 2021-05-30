namespace Kursov
{
    partial class AddPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbHand = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblHand = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Golos Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new player";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(162, 104);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // cmbHand
            // 
            this.cmbHand.FormattingEnabled = true;
            this.cmbHand.Items.AddRange(new object[] {
            "Left",
            "Rigth"});
            this.cmbHand.Location = new System.Drawing.Point(162, 318);
            this.cmbHand.Name = "cmbHand";
            this.cmbHand.Size = new System.Drawing.Size(121, 24);
            this.cmbHand.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(162, 209);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 22);
            this.txtAge.TabIndex = 3;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(162, 263);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(121, 22);
            this.txtRating.TabIndex = 4;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(162, 157);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 24);
            this.cmbCountry.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(37, 100);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(97, 24);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Location = new System.Drawing.Point(37, 153);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(88, 24);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge.Location = new System.Drawing.Point(37, 209);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 24);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRating.Location = new System.Drawing.Point(37, 263);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(73, 24);
            this.lblRating.TabIndex = 11;
            this.lblRating.Text = "Rating";
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHand.Location = new System.Drawing.Point(37, 314);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(61, 24);
            this.lblHand.TabIndex = 12;
            this.lblHand.Text = "Hand";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(141, 369);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 60);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 516);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.cmbHand);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPlayer";
            this.Text = "AddPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbHand;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Button btnAdd;
    }
}