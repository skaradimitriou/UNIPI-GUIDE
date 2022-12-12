namespace UNIPI_GUIDE
{
    partial class IntroForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.main_panel = new System.Windows.Forms.Panel();
            this.logoutIcon = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.unipiLogo = new System.Windows.Forms.PictureBox();
            this.divider = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.unipiTitle = new System.Windows.Forms.Label();
            this.unipiSubTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundImg = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutBtn = new System.Windows.Forms.PictureBox();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unipiLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.AutoSize = true;
            this.main_panel.Controls.Add(this.aboutBtn);
            this.main_panel.Controls.Add(this.logoutIcon);
            this.main_panel.Controls.Add(this.mainPanel);
            this.main_panel.Controls.Add(this.backgroundImg);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(800, 450);
            this.main_panel.TabIndex = 2;
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
            this.logoutIcon.TabIndex = 20;
            this.logoutIcon.TabStop = false;
            this.logoutIcon.Click += new System.EventHandler(this.logoutIcon_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.unipiLogo);
            this.mainPanel.Controls.Add(this.divider);
            this.mainPanel.Controls.Add(this.startBtn);
            this.mainPanel.Controls.Add(this.unipiTitle);
            this.mainPanel.Controls.Add(this.unipiSubTitle);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Location = new System.Drawing.Point(199, 56);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(375, 346);
            this.mainPanel.TabIndex = 1;
            // 
            // unipiLogo
            // 
            this.unipiLogo.Location = new System.Drawing.Point(157, 27);
            this.unipiLogo.Name = "unipiLogo";
            this.unipiLogo.Size = new System.Drawing.Size(66, 77);
            this.unipiLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unipiLogo.TabIndex = 9;
            this.unipiLogo.TabStop = false;
            // 
            // divider
            // 
            this.divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider.AutoSize = true;
            this.divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(120)))), ((int)(((byte)(38)))));
            this.divider.Location = new System.Drawing.Point(148, 172);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(82, 31);
            this.divider.TabIndex = 8;
            this.divider.Text = "————";
            this.divider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(138, 281);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(105, 41);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Έναρξη  >";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.MouseLeave += new System.EventHandler(this.startBtn_MouseLeave);
            this.startBtn.MouseHover += new System.EventHandler(this.startBtn_MouseHover);
            // 
            // unipiTitle
            // 
            this.unipiTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unipiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.unipiTitle.Location = new System.Drawing.Point(13, 131);
            this.unipiTitle.Name = "unipiTitle";
            this.unipiTitle.Size = new System.Drawing.Size(349, 33);
            this.unipiTitle.TabIndex = 6;
            this.unipiTitle.Text = "Πανεπιστήμιο Πειραιώς";
            this.unipiTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unipiSubTitle
            // 
            this.unipiSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unipiSubTitle.AutoSize = true;
            this.unipiSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unipiSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.unipiSubTitle.Location = new System.Drawing.Point(73, 216);
            this.unipiSubTitle.Name = "unipiSubTitle";
            this.unipiSubTitle.Size = new System.Drawing.Size(234, 20);
            this.unipiSubTitle.TabIndex = 5;
            this.unipiSubTitle.Text = "Διαδραστικός Οδηγός Σπουδών";
            this.unipiSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // backgroundImg
            // 
            this.backgroundImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundImg.Location = new System.Drawing.Point(0, 0);
            this.backgroundImg.Name = "backgroundImg";
            this.backgroundImg.Size = new System.Drawing.Size(800, 450);
            this.backgroundImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundImg.TabIndex = 0;
            this.backgroundImg.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.aboutBtn.TabIndex = 21;
            this.aboutBtn.TabStop = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI-GUIDE | Καλώς Ήρθατε!";
            this.Load += new System.EventHandler(this.IntroForm_Load);
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoutIcon)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unipiLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboutBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox backgroundImg;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label unipiTitle;
        private System.Windows.Forms.Label unipiSubTitle;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.PictureBox unipiLogo;
        private System.Windows.Forms.PictureBox logoutIcon;
        private System.Windows.Forms.PictureBox aboutBtn;
    }
}

