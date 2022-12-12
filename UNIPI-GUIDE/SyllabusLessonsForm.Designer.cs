namespace UNIPI_GUIDE
{
    partial class SyllabusLessonsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyllabusLessonsForm));
            this.leftPanel = new System.Windows.Forms.Panel();
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
            this.saveBtn = new System.Windows.Forms.Label();
            this.saveIcon = new System.Windows.Forms.PictureBox();
            this.formTitle = new System.Windows.Forms.Label();
            this.lessons = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lessonsTable = new System.Windows.Forms.DataGridView();
            this.returnToLogin = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            this.topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsTable)).BeginInit();
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
            this.leftPanel.TabIndex = 10;
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
            this.navReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
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
            this.navSyllabus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            this.navSyllabus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navSyllabus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navSyllabus.ForeColor = System.Drawing.Color.White;
            this.navSyllabus.Location = new System.Drawing.Point(3, 139);
            this.navSyllabus.Name = "navSyllabus";
            this.navSyllabus.Size = new System.Drawing.Size(184, 25);
            this.navSyllabus.TabIndex = 13;
            this.navSyllabus.Text = "Πρόγραμμα Σπουδών";
            this.navSyllabus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.topBarPanel.Controls.Add(this.saveBtn);
            this.topBarPanel.Controls.Add(this.saveIcon);
            this.topBarPanel.Controls.Add(this.formTitle);
            this.topBarPanel.Location = new System.Drawing.Point(187, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(614, 40);
            this.topBarPanel.TabIndex = 11;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.saveBtn.Location = new System.Drawing.Point(508, 11);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 20);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Αποθήκευση";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // saveIcon
            // 
            this.saveIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveIcon.Location = new System.Drawing.Point(474, 7);
            this.saveIcon.Name = "saveIcon";
            this.saveIcon.Size = new System.Drawing.Size(25, 25);
            this.saveIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveIcon.TabIndex = 18;
            this.saveIcon.TabStop = false;
            this.saveIcon.Click += new System.EventHandler(this.saveIcon_Click_1);
            // 
            // formTitle
            // 
            this.formTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.formTitle.Location = new System.Drawing.Point(16, 9);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(371, 20);
            this.formTitle.TabIndex = 12;
            this.formTitle.Text = "Πρόγραμμα Σπουδών";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lessons
            // 
            this.lessons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lessons.Location = new System.Drawing.Point(207, 58);
            this.lessons.Name = "lessons";
            this.lessons.Size = new System.Drawing.Size(574, 280);
            this.lessons.TabIndex = 15;
            this.lessons.Text = "";
            // 
            // lessonsTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lessonsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lessonsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lessonsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.lessonsTable.BackgroundColor = System.Drawing.Color.DarkGray;
            this.lessonsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lessonsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lessonsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lessonsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.lessonsTable.EnableHeadersVisualStyles = false;
            this.lessonsTable.Location = new System.Drawing.Point(207, 56);
            this.lessonsTable.Name = "lessonsTable";
            this.lessonsTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lessonsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lessonsTable.Size = new System.Drawing.Size(581, 382);
            this.lessonsTable.TabIndex = 16;
            this.lessonsTable.TabStop = false;
            // 
            // returnToLogin
            // 
            this.returnToLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToLogin.ForeColor = System.Drawing.Color.White;
            this.returnToLogin.Location = new System.Drawing.Point(2, 400);
            this.returnToLogin.Name = "returnToLogin";
            this.returnToLogin.Size = new System.Drawing.Size(184, 16);
            this.returnToLogin.TabIndex = 28;
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
            this.exitBtn.Location = new System.Drawing.Point(3, 425);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(184, 16);
            this.exitBtn.TabIndex = 27;
            this.exitBtn.Text = "Έξοδος";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // SyllabusLessonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lessonsTable);
            this.Controls.Add(this.lessons);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topBarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SyllabusLessonsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI-GUIDE | Μαθήματα Εξαμήνου";
            this.Load += new System.EventHandler(this.SyllabusLessonsForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            this.topBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saveIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsTable)).EndInit();
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
        private System.Windows.Forms.RichTextBox lessons;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label saveBtn;
        private System.Windows.Forms.PictureBox saveIcon;
        private System.Windows.Forms.DataGridView lessonsTable;
        private System.Windows.Forms.Label returnToLogin;
        private System.Windows.Forms.Label exitBtn;
    }
}