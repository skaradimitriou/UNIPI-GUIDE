namespace UNIPI_GUIDE
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.wrongPasswords = new System.Windows.Forms.Label();
            this.confPasswordLabel = new System.Windows.Forms.Label();
            this.confPasswordInputField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordInputField = new System.Windows.Forms.TextBox();
            this.usernameInputField = new System.Windows.Forms.TextBox();
            this.divider = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.registerBackground = new System.Windows.Forms.PictureBox();
            this.aboutBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutIcon
            // 
            this.logoutIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutIcon.Location = new System.Drawing.Point(12, 12);
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.Size = new System.Drawing.Size(25, 25);
            this.logoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutIcon.TabIndex = 22;
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.wrongPasswords);
            this.mainPanel.Controls.Add(this.confPasswordLabel);
            this.mainPanel.Controls.Add(this.confPasswordInputField);
            this.mainPanel.Controls.Add(this.passwordLabel);
            this.mainPanel.Controls.Add(this.usernameLabel);
            this.mainPanel.Controls.Add(this.passwordInputField);
            this.mainPanel.Controls.Add(this.usernameInputField);
            this.mainPanel.Controls.Add(this.divider);
            this.mainPanel.Controls.Add(this.loginBtn);
            this.mainPanel.Controls.Add(this.registerTitle);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Location = new System.Drawing.Point(213, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(375, 366);
            this.mainPanel.TabIndex = 21;
            // 
            // wrongPasswords
            // 
            this.wrongPasswords.AllowDrop = true;
            this.wrongPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongPasswords.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswords.Location = new System.Drawing.Point(37, 278);
            this.wrongPasswords.Name = "wrongPasswords";
            this.wrongPasswords.Size = new System.Drawing.Size(301, 22);
            this.wrongPasswords.TabIndex = 18;
            this.wrongPasswords.Text = "Οι κωδικοί δεν ταιριάζουν";
            this.wrongPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wrongPasswords.Visible = false;
            // 
            // confPasswordLabel
            // 
            this.confPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.confPasswordLabel.Location = new System.Drawing.Point(34, 215);
            this.confPasswordLabel.Name = "confPasswordLabel";
            this.confPasswordLabel.Size = new System.Drawing.Size(111, 22);
            this.confPasswordLabel.TabIndex = 17;
            this.confPasswordLabel.Text = "Κωδικός Χρήστη";
            this.confPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confPasswordInputField
            // 
            this.confPasswordInputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.confPasswordInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confPasswordInputField.Location = new System.Drawing.Point(37, 240);
            this.confPasswordInputField.Name = "confPasswordInputField";
            this.confPasswordInputField.Size = new System.Drawing.Size(301, 26);
            this.confPasswordInputField.TabIndex = 16;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.passwordLabel.Location = new System.Drawing.Point(34, 149);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(111, 22);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Κωδικός Χρήστη";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.usernameLabel.Location = new System.Drawing.Point(34, 86);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 22);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Όνομα Χρήστη";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordInputField
            // 
            this.passwordInputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.passwordInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInputField.Location = new System.Drawing.Point(37, 174);
            this.passwordInputField.Name = "passwordInputField";
            this.passwordInputField.Size = new System.Drawing.Size(301, 26);
            this.passwordInputField.TabIndex = 10;
            // 
            // usernameInputField
            // 
            this.usernameInputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.usernameInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInputField.Location = new System.Drawing.Point(37, 111);
            this.usernameInputField.Name = "usernameInputField";
            this.usernameInputField.Size = new System.Drawing.Size(301, 26);
            this.usernameInputField.TabIndex = 9;
            // 
            // divider
            // 
            this.divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider.AutoSize = true;
            this.divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.divider.Location = new System.Drawing.Point(153, 53);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(65, 31);
            this.divider.TabIndex = 8;
            this.divider.Text = "———";
            this.divider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(37, 310);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(298, 41);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Εγγραφή Νέου Χρήστη";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerTitle
            // 
            this.registerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.registerTitle.Location = new System.Drawing.Point(14, 17);
            this.registerTitle.Name = "registerTitle";
            this.registerTitle.Size = new System.Drawing.Size(349, 33);
            this.registerTitle.TabIndex = 6;
            this.registerTitle.Text = "Εγγραφή Χρήστη";
            this.registerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Διαδραστικός Οδηγός Σπουδών";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerBackground
            // 
            this.registerBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerBackground.Location = new System.Drawing.Point(0, 0);
            this.registerBackground.Name = "registerBackground";
            this.registerBackground.Size = new System.Drawing.Size(800, 450);
            this.registerBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registerBackground.TabIndex = 20;
            this.registerBackground.TabStop = false;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.Location = new System.Drawing.Point(43, 12);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(25, 25);
            this.aboutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutBtn.TabIndex = 23;
            this.aboutBtn.TabStop = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.logoutIcon);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.registerBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI-GUIDE | Εγγραφή Νέου Χρήστη";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label confPasswordLabel;
        private System.Windows.Forms.TextBox confPasswordInputField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordInputField;
        private System.Windows.Forms.TextBox usernameInputField;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label registerTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox registerBackground;
        private System.Windows.Forms.Label wrongPasswords;
        private System.Windows.Forms.PictureBox aboutBtn;
    }
}