namespace Kursov
{
    partial class ChangePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePlayer));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHand = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbHand = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(215, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 60);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Change";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHand.Location = new System.Drawing.Point(108, 367);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(61, 24);
            this.lblHand.TabIndex = 24;
            this.lblHand.Text = "Hand";
            this.lblHand.Visible = false;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRating.Location = new System.Drawing.Point(108, 333);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(73, 24);
            this.lblRating.TabIndex = 23;
            this.lblRating.Text = "Rating";
            this.lblRating.Visible = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge.Location = new System.Drawing.Point(108, 292);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 24);
            this.lblAge.TabIndex = 22;
            this.lblAge.Text = "Age";
            this.lblAge.Visible = false;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Location = new System.Drawing.Point(106, 252);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(88, 24);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "Country";
            this.lblCountry.Visible = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(108, 202);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(97, 24);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "Surname";
            this.lblSurname.Visible = false;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(235, 252);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 24);
            this.cmbCountry.TabIndex = 19;
            this.cmbCountry.Visible = false;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(235, 337);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(121, 22);
            this.txtRating.TabIndex = 18;
            this.txtRating.Visible = false;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(235, 296);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 22);
            this.txtAge.TabIndex = 17;
            this.txtAge.Visible = false;
            // 
            // cmbHand
            // 
            this.cmbHand.FormattingEnabled = true;
            this.cmbHand.Items.AddRange(new object[] {
            "Left",
            "Rigth"});
            this.cmbHand.Location = new System.Drawing.Point(235, 382);
            this.cmbHand.Name = "cmbHand";
            this.cmbHand.Size = new System.Drawing.Size(121, 24);
            this.cmbHand.TabIndex = 16;
            this.cmbHand.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(235, 206);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 22);
            this.txtSurname.TabIndex = 15;
            this.txtSurname.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Golos Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "Change player";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(108, 155);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 24);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(235, 159);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 22);
            this.txtId.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(391, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ChangePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePlayer";
            this.Text = "ChangePlayer";
            this.Load += new System.EventHandler(this.ChangePlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbHand;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
    }
}