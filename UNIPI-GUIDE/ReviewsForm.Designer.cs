namespace UNIPI_GUIDE
{
    partial class ReviewsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.newReviewBtn = new System.Windows.Forms.Label();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navAbout = new System.Windows.Forms.Label();
            this.navReviews = new System.Windows.Forms.Label();
            this.navSyllabus = new System.Windows.Forms.Label();
            this.navDepartment = new System.Windows.Forms.Label();
            this.navProfessors = new System.Windows.Forms.Label();
            this.navCalendar = new System.Windows.Forms.Label();
            this.navHome = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.returnToLogin = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.starIcon = new System.Windows.Forms.PictureBox();
            this.averageRatingTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reviewsCounter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reviewsTxt = new System.Windows.Forms.RichTextBox();
            this.topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starIcon)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Κριτικές";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topBarPanel
            // 
            this.topBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topBarPanel.BackColor = System.Drawing.Color.White;
            this.topBarPanel.Controls.Add(this.newReviewBtn);
            this.topBarPanel.Controls.Add(this.label2);
            this.topBarPanel.Location = new System.Drawing.Point(187, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(614, 40);
            this.topBarPanel.TabIndex = 7;
            // 
            // newReviewBtn
            // 
            this.newReviewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newReviewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newReviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newReviewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.newReviewBtn.Location = new System.Drawing.Point(493, 10);
            this.newReviewBtn.Name = "newReviewBtn";
            this.newReviewBtn.Size = new System.Drawing.Size(108, 20);
            this.newReviewBtn.TabIndex = 13;
            this.newReviewBtn.Text = "Νέα Κριτική";
            this.newReviewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newReviewBtn.Click += new System.EventHandler(this.newReviewBtn_Click);
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
            this.navReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.navReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navReviews.ForeColor = System.Drawing.Color.White;
            this.navReviews.Location = new System.Drawing.Point(3, 169);
            this.navReviews.Name = "navReviews";
            this.navReviews.Size = new System.Drawing.Size(184, 25);
            this.navReviews.TabIndex = 14;
            this.navReviews.Text = "Κριτικές";
            this.navReviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.navDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navDepartment.ForeColor = System.Drawing.Color.White;
            this.navDepartment.Location = new System.Drawing.Point(3, 109);
            this.navDepartment.Name = "navDepartment";
            this.navDepartment.Size = new System.Drawing.Size(184, 25);
            this.navDepartment.TabIndex = 12;
            this.navDepartment.Text = "Το Τμήμα";
            this.navDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.navDepartment.Click += new System.EventHandler(this.navDepartment_Click);
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
            this.leftPanel.TabIndex = 6;
            // 
            // returnToLogin
            // 
            this.returnToLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToLogin.ForeColor = System.Drawing.Color.White;
            this.returnToLogin.Location = new System.Drawing.Point(3, 401);
            this.returnToLogin.Name = "returnToLogin";
            this.returnToLogin.Size = new System.Drawing.Size(184, 16);
            this.returnToLogin.TabIndex = 24;
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
            this.exitBtn.Location = new System.Drawing.Point(4, 426);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(184, 16);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "Έξοδος";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.starIcon);
            this.panel2.Controls.Add(this.averageRatingTxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(207, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 98);
            this.panel2.TabIndex = 8;
            // 
            // starIcon
            // 
            this.starIcon.Location = new System.Drawing.Point(15, 46);
            this.starIcon.Name = "starIcon";
            this.starIcon.Size = new System.Drawing.Size(25, 25);
            this.starIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starIcon.TabIndex = 15;
            this.starIcon.TabStop = false;
            // 
            // averageRatingTxt
            // 
            this.averageRatingTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.averageRatingTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageRatingTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.averageRatingTxt.Location = new System.Drawing.Point(43, 32);
            this.averageRatingTxt.Name = "averageRatingTxt";
            this.averageRatingTxt.Size = new System.Drawing.Size(82, 55);
            this.averageRatingTxt.TabIndex = 14;
            this.averageRatingTxt.Text = "0.0";
            this.averageRatingTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Βαθμολογία";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.reviewsCounter);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(358, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 98);
            this.panel4.TabIndex = 17;
            // 
            // reviewsCounter
            // 
            this.reviewsCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reviewsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.reviewsCounter.Location = new System.Drawing.Point(13, 32);
            this.reviewsCounter.Name = "reviewsCounter";
            this.reviewsCounter.Size = new System.Drawing.Size(126, 55);
            this.reviewsCounter.TabIndex = 14;
            this.reviewsCounter.Text = "0";
            this.reviewsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Κριτικές";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(204, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Όλες οι κριτικές";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reviewsTxt
            // 
            this.reviewsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reviewsTxt.Location = new System.Drawing.Point(207, 204);
            this.reviewsTxt.Name = "reviewsTxt";
            this.reviewsTxt.Size = new System.Drawing.Size(574, 237);
            this.reviewsTxt.TabIndex = 19;
            this.reviewsTxt.Text = "";
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reviewsTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topBarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReviewsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI-GUIDE | Κριτικές";
            this.Activated += new System.EventHandler(this.ReviewsForm_Activated);
            this.Load += new System.EventHandler(this.ReviewsForm_Load);
            this.topBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.starIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label navAbout;
        private System.Windows.Forms.Label navReviews;
        private System.Windows.Forms.Label navSyllabus;
        private System.Windows.Forms.Label navDepartment;
        private System.Windows.Forms.Label navProfessors;
        private System.Windows.Forms.Label navCalendar;
        private System.Windows.Forms.Label navHome;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label newReviewBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox starIcon;
        private System.Windows.Forms.Label averageRatingTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label reviewsCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox reviewsTxt;
        private System.Windows.Forms.Label returnToLogin;
        private System.Windows.Forms.Label exitBtn;
    }
}