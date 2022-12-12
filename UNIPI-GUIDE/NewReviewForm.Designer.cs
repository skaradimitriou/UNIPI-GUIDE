namespace UNIPI_GUIDE
{
    partial class NewReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReviewForm));
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
            this.reviewsTxt = new System.Windows.Forms.RichTextBox();
            this.submitReviewBtn = new System.Windows.Forms.Button();
            this.ratingTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tooManyCharsTxt = new System.Windows.Forms.Label();
            this.rateInputError = new System.Windows.Forms.Label();
            this.reviewCharCounterTxt = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            this.topBarPanel.SuspendLayout();
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
            this.leftPanel.TabIndex = 8;
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
            this.returnToLogin.TabIndex = 20;
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
            this.exitBtn.TabIndex = 19;
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
            this.topBarPanel.TabIndex = 9;
            // 
            // formTitle
            // 
            this.formTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.formTitle.Location = new System.Drawing.Point(16, 9);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(578, 20);
            this.formTitle.TabIndex = 12;
            this.formTitle.Text = "Νέα Κριτική";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reviewsTxt
            // 
            this.reviewsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reviewsTxt.Location = new System.Drawing.Point(207, 117);
            this.reviewsTxt.Name = "reviewsTxt";
            this.reviewsTxt.Size = new System.Drawing.Size(574, 105);
            this.reviewsTxt.TabIndex = 20;
            this.reviewsTxt.Text = "";
            this.reviewsTxt.TextChanged += new System.EventHandler(this.reviewsTxt_TextChanged);
            // 
            // submitReviewBtn
            // 
            this.submitReviewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitReviewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.submitReviewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitReviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitReviewBtn.ForeColor = System.Drawing.Color.White;
            this.submitReviewBtn.Location = new System.Drawing.Point(413, 369);
            this.submitReviewBtn.Name = "submitReviewBtn";
            this.submitReviewBtn.Size = new System.Drawing.Size(173, 41);
            this.submitReviewBtn.TabIndex = 21;
            this.submitReviewBtn.Text = "Υποβολή Κριτικής";
            this.submitReviewBtn.UseVisualStyleBackColor = false;
            this.submitReviewBtn.Click += new System.EventHandler(this.submitReviewBtn_Click);
            // 
            // ratingTxt
            // 
            this.ratingTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingTxt.Location = new System.Drawing.Point(435, 309);
            this.ratingTxt.Name = "ratingTxt";
            this.ratingTxt.Size = new System.Drawing.Size(117, 25);
            this.ratingTxt.TabIndex = 22;
            this.ratingTxt.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(431, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Βαθμολογία";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(516, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "(1-5)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(206, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Γράψτε την κριτική σας για το Πανεπιστήμιο και τις υπηρεσίες του";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(206, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "(μέχρι 300 χαρακτήρες)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tooManyCharsTxt
            // 
            this.tooManyCharsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tooManyCharsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooManyCharsTxt.ForeColor = System.Drawing.Color.Red;
            this.tooManyCharsTxt.Location = new System.Drawing.Point(205, 236);
            this.tooManyCharsTxt.Name = "tooManyCharsTxt";
            this.tooManyCharsTxt.Size = new System.Drawing.Size(431, 20);
            this.tooManyCharsTxt.TabIndex = 28;
            this.tooManyCharsTxt.Text = "Ξεπεράσατε το όριο των 200 χαρακτήρων. Παρακαλώ μειώστε το κείμενο σας.";
            this.tooManyCharsTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooManyCharsTxt.Visible = false;
            // 
            // rateInputError
            // 
            this.rateInputError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rateInputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateInputError.ForeColor = System.Drawing.Color.Red;
            this.rateInputError.Location = new System.Drawing.Point(361, 340);
            this.rateInputError.Name = "rateInputError";
            this.rateInputError.Size = new System.Drawing.Size(282, 20);
            this.rateInputError.TabIndex = 29;
            this.rateInputError.Text = "Αποδεκτές τιμές μόνο ακέραιες τιμές απο 1 μέχρι 5";
            this.rateInputError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rateInputError.Visible = false;
            // 
            // reviewCharCounterTxt
            // 
            this.reviewCharCounterTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reviewCharCounterTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewCharCounterTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.reviewCharCounterTxt.Location = new System.Drawing.Point(642, 92);
            this.reviewCharCounterTxt.Name = "reviewCharCounterTxt";
            this.reviewCharCounterTxt.Size = new System.Drawing.Size(139, 20);
            this.reviewCharCounterTxt.TabIndex = 30;
            this.reviewCharCounterTxt.Text = "0/300";
            this.reviewCharCounterTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reviewCharCounterTxt);
            this.Controls.Add(this.rateInputError);
            this.Controls.Add(this.tooManyCharsTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ratingTxt);
            this.Controls.Add(this.submitReviewBtn);
            this.Controls.Add(this.reviewsTxt);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topBarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI-GUIDE | Νέα Κριτική";
            this.Load += new System.EventHandler(this.NewReviewForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            this.topBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
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
        private System.Windows.Forms.RichTextBox reviewsTxt;
        private System.Windows.Forms.Button submitReviewBtn;
        private System.Windows.Forms.RichTextBox ratingTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tooManyCharsTxt;
        private System.Windows.Forms.Label rateInputError;
        private System.Windows.Forms.Label reviewCharCounterTxt;
        private System.Windows.Forms.Label returnToLogin;
        private System.Windows.Forms.Label exitBtn;
    }
}