namespace UNIPI_GUIDE
{
    partial class ServicesInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesInfoForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.returnToLogin = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navAbout = new System.Windows.Forms.Label();
            this.navReviews = new System.Windows.Forms.Label();
            this.navSyllabus = new System.Windows.Forms.Label();
            this.navDepartment = new System.Windows.Forms.Label();
            this.navProfessors = new System.Windows.Forms.Label();
            this.navCalendar = new System.Windows.Forms.Label();
            this.navHome = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoTxt = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Label();
            this.saveIcon = new System.Windows.Forms.PictureBox();
            this.serviceInfoImg = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            this.topBarPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceInfoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.leftPanel.Controls.Add(this.returnToLogin);
            this.leftPanel.Controls.Add(this.exitBtn);
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.Add(this.usernameTxt);
            this.leftPanel.Controls.Add(this.userImg);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(190, 450);
            this.leftPanel.TabIndex = 17;
            // 
            // returnToLogin
            // 
            this.returnToLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToLogin.ForeColor = System.Drawing.Color.White;
            this.returnToLogin.Location = new System.Drawing.Point(3, 403);
            this.returnToLogin.Name = "returnToLogin";
            this.returnToLogin.Size = new System.Drawing.Size(184, 16);
            this.returnToLogin.TabIndex = 18;
            this.returnToLogin.Text = "Αποσύνδεση";
            this.returnToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnToLogin.Click += new System.EventHandler(this.returnToLogin_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(4, 428);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(184, 16);
            this.exitBtn.TabIndex = 17;
            this.exitBtn.Text = "Έξοδος";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.navAbout);
            this.panel1.Controls.Add(this.navReviews);
            this.panel1.Controls.Add(this.navSyllabus);
            this.panel1.Controls.Add(this.navDepartment);
            this.panel1.Controls.Add(this.navProfessors);
            this.panel1.Controls.Add(this.navCalendar);
            this.panel1.Controls.Add(this.navHome);
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 228);
            this.panel1.TabIndex = 11;
            // 
            // navAbout
            // 
            this.navAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navAbout.ForeColor = System.Drawing.Color.White;
            this.navAbout.Location = new System.Drawing.Point(0, 199);
            this.navAbout.Name = "navAbout";
            this.navAbout.Size = new System.Drawing.Size(190, 25);
            this.navAbout.TabIndex = 15;
            this.navAbout.Text = "Σχετικά με την εφαρμογή";
            this.navAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.navAbout.Click += new System.EventHandler(this.navAbout_Click);
            // 
            // navReviews
            // 
            this.navReviews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navReviews.ForeColor = System.Drawing.Color.White;
            this.navReviews.Location = new System.Drawing.Point(3, 169);
            this.navReviews.Name = "navReviews";
            this.navReviews.Size = new System.Drawing.Size(184, 25);
            this.navReviews.TabIndex = 14;
            this.navReviews.Text = "Κριτικές";
            this.navReviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.navReviews.Click += new System.EventHandler(this.navReviews_Click);
            // 
            // navSyllabus
            // 
            this.navSyllabus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navSyllabus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navSyllabus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSyllabus.ForeColor = System.Drawing.Color.White;
            this.navSyllabus.Location = new System.Drawing.Point(3, 139);
            this.navSyllabus.Name = "navSyllabus";
            this.navSyllabus.Size = new System.Drawing.Size(184, 25);
            this.navSyllabus.TabIndex = 13;
            this.navSyllabus.Text = "Πρόγραμμα Σπουδών";
            this.navSyllabus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.navSyllabus.Click += new System.EventHandler(this.navSyllabus_Click);
            // 
            // navDepartment
            // 
            this.navDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.navDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDepartment.ForeColor = System.Drawing.Color.White;
            this.navDepartment.Location = new System.Drawing.Point(3, 109);
            this.navDepartment.Name = "navDepartment";
            this.navDepartment.Size = new System.Drawing.Size(184, 25);
            this.navDepartment.TabIndex = 12;
            this.navDepartment.Text = "Το Τμήμα";
            this.navDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navProfessors
            // 
            this.navProfessors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navProfessors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navProfessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navProfessors.ForeColor = System.Drawing.Color.White;
            this.navProfessors.Location = new System.Drawing.Point(0, 79);
            this.navProfessors.Name = "navProfessors";
            this.navProfessors.Size = new System.Drawing.Size(190, 25);
            this.navProfessors.TabIndex = 11;
            this.navProfessors.Text = "Καθηγητές";
            this.navProfessors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.navProfessors.Click += new System.EventHandler(this.navProfessors_Click);
            // 
            // navCalendar
            // 
            this.navCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.navCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCalendar.ForeColor = System.Drawing.Color.White;
            this.navCalendar.Location = new System.Drawing.Point(0, 49);
            this.navCalendar.Name = "navCalendar";
            this.navCalendar.Size = new System.Drawing.Size(190, 25);
            this.navCalendar.TabIndex = 10;
            this.navCalendar.Text = "Ημερολόγιο";
            this.navCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.navCalendar.Click += new System.EventHandler(this.navCalendar_Click);
            // 
            // navHome
            // 
            this.navHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.navHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navHome.ForeColor = System.Drawing.Color.White;
            this.navHome.Location = new System.Drawing.Point(0, 21);
            this.navHome.Name = "navHome";
            this.navHome.Size = new System.Drawing.Size(190, 25);
            this.navHome.TabIndex = 9;
            this.navHome.Text = "Αρχική";
            this.navHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.navHome.Click += new System.EventHandler(this.navHome_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.White;
            this.usernameTxt.Location = new System.Drawing.Point(5, 111);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(176, 20);
            this.usernameTxt.TabIndex = 10;
            this.usernameTxt.Text = "username";
            this.usernameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userImg
            // 
            this.userImg.Location = new System.Drawing.Point(52, 23);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(78, 74);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 1;
            this.userImg.TabStop = false;
            // 
            // topBarPanel
            // 
            this.topBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topBarPanel.BackColor = System.Drawing.Color.White;
            this.topBarPanel.Controls.Add(this.formTitle);
            this.topBarPanel.Location = new System.Drawing.Point(187, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(614, 40);
            this.topBarPanel.TabIndex = 18;
            // 
            // formTitle
            // 
            this.formTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.formTitle.Location = new System.Drawing.Point(16, 9);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(530, 20);
            this.formTitle.TabIndex = 12;
            this.formTitle.Text = "Υπηρεσίες";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.infoTxt);
            this.panel2.Location = new System.Drawing.Point(207, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 214);
            this.panel2.TabIndex = 24;
            // 
            // infoTxt
            // 
            this.infoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTxt.Location = new System.Drawing.Point(14, 14);
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(546, 189);
            this.infoTxt.TabIndex = 13;
            this.infoTxt.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.saveBtn.Location = new System.Drawing.Point(696, 417);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 20);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Αποθήκευση";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveIcon
            // 
            this.saveIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveIcon.Location = new System.Drawing.Point(662, 413);
            this.saveIcon.Name = "saveIcon";
            this.saveIcon.Size = new System.Drawing.Size(25, 25);
            this.saveIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveIcon.TabIndex = 22;
            this.saveIcon.TabStop = false;
            this.saveIcon.Click += new System.EventHandler(this.saveIcon_Click);
            // 
            // serviceInfoImg
            // 
            this.serviceInfoImg.Location = new System.Drawing.Point(207, 46);
            this.serviceInfoImg.Name = "serviceInfoImg";
            this.serviceInfoImg.Size = new System.Drawing.Size(145, 133);
            this.serviceInfoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.serviceInfoImg.TabIndex = 25;
            this.serviceInfoImg.TabStop = false;
            // 
            // ServicesInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serviceInfoImg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.saveIcon);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topBarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServicesInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI-GUIDE | Πληροφορίες Υπηρεσίας";
            this.Load += new System.EventHandler(this.ServicesInfoForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            this.topBarPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saveIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceInfoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label returnToLogin;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label navAbout;
        private System.Windows.Forms.Label navReviews;
        private System.Windows.Forms.Label navSyllabus;
        private System.Windows.Forms.Label navDepartment;
        private System.Windows.Forms.Label navProfessors;
        private System.Windows.Forms.Label navCalendar;
        private System.Windows.Forms.Label navHome;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox infoTxt;
        private System.Windows.Forms.Label saveBtn;
        private System.Windows.Forms.PictureBox saveIcon;
        private System.Windows.Forms.PictureBox serviceInfoImg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}