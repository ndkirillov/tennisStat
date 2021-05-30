namespace Kursov
{
    partial class Form_Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label_Top = new System.Windows.Forms.Label();
            this.jTextbox_Email = new JTextBox.JTextBox();
            this.jTextbox_Password = new JTextBox.JTextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.btn_login = new FlatButton.JFlatButton();
            this.lblForget = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.PanelTop;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.White;
            this.PanelTop.Controls.Add(this.label_Top);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Font = new System.Drawing.Font("Geometr415 Blk BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 122);
            this.PanelTop.TabIndex = 0;
            // 
            // label_Top
            // 
            this.label_Top.AutoSize = true;
            this.label_Top.Font = new System.Drawing.Font("Golos Text Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Top.Location = new System.Drawing.Point(96, 43);
            this.label_Top.Name = "label_Top";
            this.label_Top.Size = new System.Drawing.Size(603, 48);
            this.label_Top.TabIndex = 0;
            this.label_Top.Text = "LOG IN FOR KEYTENNIS.PRO";
            // 
            // jTextbox_Email
            // 
            this.jTextbox_Email.AutoSize = true;
            this.jTextbox_Email.BorderColor = System.Drawing.Color.LightGray;
            this.jTextbox_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jTextbox_Email.Hint = "";
            this.jTextbox_Email.IsPassword = false;
            this.jTextbox_Email.Length = 0;
            this.jTextbox_Email.Location = new System.Drawing.Point(215, 193);
            this.jTextbox_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jTextbox_Email.Name = "jTextbox_Email";
            this.jTextbox_Email.OnFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.jTextbox_Email.OnlyChar = false;
            this.jTextbox_Email.OnlyNumber = false;
            this.jTextbox_Email.Size = new System.Drawing.Size(336, 48);
            this.jTextbox_Email.TabIndex = 1;
            this.jTextbox_Email.TextValue = "";
            this.jTextbox_Email.Load += new System.EventHandler(this.JTextBox1_Load);
            // 
            // jTextbox_Password
            // 
            this.jTextbox_Password.AutoSize = true;
            this.jTextbox_Password.BorderColor = System.Drawing.Color.LightGray;
            this.jTextbox_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jTextbox_Password.Hint = "";
            this.jTextbox_Password.IsPassword = false;
            this.jTextbox_Password.Length = 0;
            this.jTextbox_Password.Location = new System.Drawing.Point(215, 293);
            this.jTextbox_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jTextbox_Password.Name = "jTextbox_Password";
            this.jTextbox_Password.OnFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.jTextbox_Password.OnlyChar = false;
            this.jTextbox_Password.OnlyNumber = false;
            this.jTextbox_Password.Size = new System.Drawing.Size(336, 48);
            this.jTextbox_Password.TabIndex = 2;
            this.jTextbox_Password.TextValue = "";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Golos Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Email.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_Email.Location = new System.Drawing.Point(220, 165);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(73, 24);
            this.label_Email.TabIndex = 3;
            this.label_Email.Text = "EMAIL";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Golos Text DemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_Password.Location = new System.Drawing.Point(220, 265);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(125, 24);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "PASSWORD";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Green;
            this.btn_login.BackgroundColor = System.Drawing.Color.Green;
            this.btn_login.ButtonText = "LOGIN";
            this.btn_login.CausesValidation = false;
            this.btn_login.ErrorImageLeft = null;
            this.btn_login.ErrorImageRight = null;
            this.btn_login.FocusBackground = System.Drawing.Color.Empty;
            this.btn_login.FocusFontColor = System.Drawing.Color.Empty;
            this.btn_login.ForeColors = System.Drawing.Color.White;
            this.btn_login.HoverBackground = System.Drawing.Color.Empty;
            this.btn_login.HoverFontColor = System.Drawing.Color.Empty;
            this.btn_login.ImageLeft = null;
            this.btn_login.ImageRight = null;
            this.btn_login.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(215, 379);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btn_login.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btn_login.RightPictureColor = System.Drawing.Color.Transparent;
            this.btn_login.Size = new System.Drawing.Size(336, 53);
            this.btn_login.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btn_login.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btn_login.TabIndex = 5;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.Font = new System.Drawing.Font("Golos Text Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForget.Location = new System.Drawing.Point(303, 450);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(172, 21);
            this.lblForget.TabIndex = 6;
            this.lblForget.Text = "Forgot password?";
            this.lblForget.Click += new System.EventHandler(this.LblForget_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.lblForget);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.jTextbox_Password);
            this.Controls.Add(this.jTextbox_Email);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.Text = "LOG IN";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label label_Top;
        private JTextBox.JTextBox jTextbox_Email;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Email;
        private JTextBox.JTextBox jTextbox_Password;
        private FlatButton.JFlatButton btn_login;
        private System.Windows.Forms.Label lblForget;
    }
}

