namespace UNIPI_GUIDE
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginBackground = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.PictureBox();
            this.wrongCredentials = new System.Windows.Forms.Label();
            this.loginAsGuestBtn = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordInputField = new System.Windows.Forms.TextBox();
            this.usernameInputField = new System.Windows.Forms.TextBox();
            this.divider = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.aboutBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBackground
            // 
            this.loginBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBackground.Location = new System.Drawing.Point(0, 0);
            this.loginBackground.Name = "loginBackground";
            this.loginBackground.Size = new System.Drawing.Size(800, 450);
            this.loginBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginBackground.TabIndex = 0;
            this.loginBackground.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.registerBtn);
            this.mainPanel.Controls.Add(this.showPassword);
            this.mainPanel.Controls.Add(this.wrongCredentials);
            this.mainPanel.Controls.Add(this.loginAsGuestBtn);
            this.mainPanel.Controls.Add(this.passwordLabel);
            this.mainPanel.Controls.Add(this.usernameLabel);
            this.mainPanel.Controls.Add(this.passwordInputField);
            this.mainPanel.Controls.Add(this.usernameInputField);
            this.mainPanel.Controls.Add(this.divider);
            this.mainPanel.Controls.Add(this.loginBtn);
            this.mainPanel.Controls.Add(this.loginTitle);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Location = new System.Drawing.Point(213, 52);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(375, 366);
            this.mainPanel.TabIndex = 2;
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBtn.BackColor = System.Drawing.Color.White;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.registerBtn.Location = new System.Drawing.Point(190, 267);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(148, 41);
            this.registerBtn.TabIndex = 16;
            this.registerBtn.Text = "Εγγραφή";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // showPassword
            // 
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.Location = new System.Drawing.Point(314, 192);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(15, 17);
            this.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassword.TabIndex = 15;
            this.showPassword.TabStop = false;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // wrongCredentials
            // 
            this.wrongCredentials.AllowDrop = true;
            this.wrongCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongCredentials.ForeColor = System.Drawing.Color.Red;
            this.wrongCredentials.Location = new System.Drawing.Point(37, 225);
            this.wrongCredentials.Name = "wrongCredentials";
            this.wrongCredentials.Size = new System.Drawing.Size(301, 22);
            this.wrongCredentials.TabIndex = 14;
            this.wrongCredentials.Text = "Τα στοιχεία που εισάγατε είναι λανθασμένα.";
            this.wrongCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wrongCredentials.Visible = false;
            // 
            // loginAsGuestBtn
            // 
            this.loginAsGuestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAsGuestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsGuestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loginAsGuestBtn.Location = new System.Drawing.Point(34, 320);
            this.loginAsGuestBtn.Name = "loginAsGuestBtn";
            this.loginAsGuestBtn.Size = new System.Drawing.Size(304, 22);
            this.loginAsGuestBtn.TabIndex = 13;
            this.loginAsGuestBtn.Text = "Σύνδεση ως επισκέπτης";
            this.loginAsGuestBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginAsGuestBtn.Click += new System.EventHandler(this.loginAsGuestBtn_Click);
            this.loginAsGuestBtn.MouseLeave += new System.EventHandler(this.loginAsGuestBtn_MouseLeave);
            this.loginAsGuestBtn.MouseHover += new System.EventHandler(this.loginAsGuestBtn_MouseHover);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.passwordLabel.Location = new System.Drawing.Point(34, 163);
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
            this.usernameLabel.Location = new System.Drawing.Point(34, 100);
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
            this.passwordInputField.Location = new System.Drawing.Point(37, 188);
            this.passwordInputField.Name = "passwordInputField";
            this.passwordInputField.Size = new System.Drawing.Size(301, 26);
            this.passwordInputField.TabIndex = 10;
            // 
            // usernameInputField
            // 
            this.usernameInputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.usernameInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInputField.Location = new System.Drawing.Point(37, 125);
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
            this.divider.Location = new System.Drawing.Point(153, 58);
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
            this.loginBtn.Location = new System.Drawing.Point(40, 267);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(148, 41);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Σύνδεση";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginTitle
            // 
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loginTitle.Location = new System.Drawing.Point(14, 18);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(349, 33);
            this.loginTitle.TabIndex = 6;
            this.loginTitle.Text = "Σύνδεση Χρήστη";
            this.loginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // logoutIcon
            // 
            this.logoutIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutIcon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutIcon.Location = new System.Drawing.Point(12, 12);
            this.logoutIcon.Name = "logoutIcon";
            this.logoutIcon.Size = new System.Drawing.Size(25, 25);
            this.logoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutIcon.TabIndex = 19;
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
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
            this.aboutBtn.TabIndex = 22;
            this.aboutBtn.TabStop = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.logoutIcon);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.loginBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI-GUIDE | Σύνδεση Χρήστη";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loginBackground;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox passwordInputField;
        private System.Windows.Forms.TextBox usernameInputField;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label loginAsGuestBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label wrongCredentials;
        private System.Windows.Forms.PictureBox showPassword;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.PictureBox aboutBtn;
    }
}