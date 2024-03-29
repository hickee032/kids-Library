﻿namespace Team1_Project {
    partial class FormMain {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.non1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReBook = new System.Windows.Forms.Button();
            this.btnLesson = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxSlider = new System.Windows.Forms.CheckBox();
            this.timerSliding = new System.Windows.Forms.Timer(this.components);
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picLibStory = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Label();
            this.myProfile = new System.Windows.Forms.Label();
            this.labelLogName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLibStory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.non1);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.btnSearch);
            this.panelSideMenu.Controls.Add(this.btnReBook);
            this.panelSideMenu.Controls.Add(this.btnLesson);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.cbxSlider);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 60);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(264, 600);
            this.panelSideMenu.TabIndex = 0;
            // 
            // non1
            // 
            this.non1.AutoSize = true;
            this.non1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.non1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.non1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.non1.Enabled = false;
            this.non1.FlatAppearance.BorderSize = 0;
            this.non1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.non1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.non1.Location = new System.Drawing.Point(0, 125);
            this.non1.Name = "non1";
            this.non1.Size = new System.Drawing.Size(264, 155);
            this.non1.TabIndex = 7;
            this.non1.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHome.Location = new System.Drawing.Point(0, 64);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(264, 64);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "메인";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearch.Location = new System.Drawing.Point(0, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(264, 64);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "책 검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReBook
            // 
            this.btnReBook.AutoSize = true;
            this.btnReBook.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnReBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReBook.FlatAppearance.BorderSize = 0;
            this.btnReBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReBook.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReBook.ForeColor = System.Drawing.Color.DarkRed;
            this.btnReBook.Location = new System.Drawing.Point(0, 344);
            this.btnReBook.Name = "btnReBook";
            this.btnReBook.Size = new System.Drawing.Size(264, 64);
            this.btnReBook.TabIndex = 3;
            this.btnReBook.Text = "책 반납";
            this.btnReBook.UseVisualStyleBackColor = false;
            this.btnReBook.Click += new System.EventHandler(this.btnReBook_Click);
            // 
            // btnLesson
            // 
            this.btnLesson.AutoSize = true;
            this.btnLesson.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLesson.FlatAppearance.BorderSize = 0;
            this.btnLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLesson.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLesson.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLesson.Location = new System.Drawing.Point(0, 408);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(264, 64);
            this.btnLesson.TabIndex = 4;
            this.btnLesson.Text = "교실";
            this.btnLesson.UseVisualStyleBackColor = false;
            this.btnLesson.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.AutoSize = true;
            this.btnMedia.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMedia.Location = new System.Drawing.Point(0, 472);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(264, 64);
            this.btnMedia.TabIndex = 5;
            this.btnMedia.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(0, 536);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(264, 64);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxSlider
            // 
            this.cbxSlider.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxSlider.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbxSlider.BackgroundImage = global::Team1_Project.Properties.Resources.icon_backward;
            this.cbxSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbxSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxSlider.FlatAppearance.BorderSize = 0;
            this.cbxSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSlider.Location = new System.Drawing.Point(0, 0);
            this.cbxSlider.Name = "cbxSlider";
            this.cbxSlider.Size = new System.Drawing.Size(264, 64);
            this.cbxSlider.TabIndex = 1;
            this.cbxSlider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxSlider.UseVisualStyleBackColor = false;
            this.cbxSlider.CheckedChanged += new System.EventHandler(this.checkBoxHide_CheckedChanged);
            // 
            // timerSliding
            // 
            this.timerSliding.Tick += new System.EventHandler(this.timerSliding_Tick);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelCenter.Location = new System.Drawing.Point(270, 60);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1008, 600);
            this.panelCenter.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picLibStory);
            this.panel1.Location = new System.Drawing.Point(63, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 597);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Team1_Project.Properties.Resources.char_dadogi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 193);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Team1_Project.Properties.Resources.icon_book;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(12, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(57, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "도서관 이야기";
            // 
            // picLibStory
            // 
            this.picLibStory.BackgroundImage = global::Team1_Project.Properties.Resources.libStory12;
            this.picLibStory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLibStory.Location = new System.Drawing.Point(0, 50);
            this.picLibStory.Name = "picLibStory";
            this.picLibStory.Size = new System.Drawing.Size(200, 319);
            this.picLibStory.TabIndex = 12;
            this.picLibStory.TabStop = false;
            this.picLibStory.Click += new System.EventHandler(this.picLibStory_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(1103, 7);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Padding = new System.Windows.Forms.Padding(25, 11, 25, 11);
            this.btnLogIn.Size = new System.Drawing.Size(131, 37);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "로그인";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // myProfile
            // 
            this.myProfile.AutoSize = true;
            this.myProfile.BackColor = System.Drawing.Color.Coral;
            this.myProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myProfile.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.myProfile.Location = new System.Drawing.Point(989, 7);
            this.myProfile.Name = "myProfile";
            this.myProfile.Padding = new System.Windows.Forms.Padding(25, 11, 25, 11);
            this.myProfile.Size = new System.Drawing.Size(97, 37);
            this.myProfile.TabIndex = 5;
            this.myProfile.Text = "내 정보";
            this.myProfile.Click += new System.EventHandler(this.myProfile_Click);
            // 
            // labelLogName
            // 
            this.labelLogName.AutoSize = true;
            this.labelLogName.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLogName.Location = new System.Drawing.Point(764, 15);
            this.labelLogName.Name = "labelLogName";
            this.labelLogName.Size = new System.Drawing.Size(88, 19);
            this.labelLogName.TabIndex = 6;
            this.labelLogName.Text = "로그인 속성";
            this.labelLogName.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelLogName);
            this.panel2.Controls.Add(this.btnMainExit);
            this.panel2.Controls.Add(this.myProfile);
            this.panel2.Controls.Add(this.btnLogIn);
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 50);
            this.panel2.TabIndex = 7;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTitle.Location = new System.Drawing.Point(62, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 24);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "title";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Team1_Project.Properties.Resources.icon_title;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnMainExit
            // 
            this.btnMainExit.BackgroundImage = global::Team1_Project.Properties.Resources.icon_cancel;
            this.btnMainExit.FlatAppearance.BorderSize = 0;
            this.btnMainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainExit.Location = new System.Drawing.Point(1245, 8);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(32, 32);
            this.btnMainExit.TabIndex = 3;
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 680);
            this.ControlBox = false;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "홈";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLibStory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        public System.Windows.Forms.CheckBox cbxSlider;
        private System.Windows.Forms.Timer timerSliding;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReBook;
        private System.Windows.Forms.Button btnLesson;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button btnMainExit;
        public System.Windows.Forms.Label btnLogIn;
        public System.Windows.Forms.Label myProfile;
        public System.Windows.Forms.Label labelLogName;
        private System.Windows.Forms.Button non1;
        private System.Windows.Forms.PictureBox picLibStory;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label labelTitle;
    }
}

