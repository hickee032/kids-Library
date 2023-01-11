namespace Team1_Project {
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
            this.btnLogIn = new System.Windows.Forms.Label();
            this.myProfile = new System.Windows.Forms.Label();
            this.labelLogName = new System.Windows.Forms.Label();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.non1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.non1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.non1.Enabled = false;
            this.non1.FlatAppearance.BorderSize = 0;
            this.non1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.non1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.non1.Location = new System.Drawing.Point(0, 134);
            this.non1.Name = "non1";
            this.non1.Size = new System.Drawing.Size(264, 146);
            this.non1.TabIndex = 7;
            this.non1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.Location = new System.Drawing.Point(0, 64);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(264, 64);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "메인";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(0, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(264, 64);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "책 검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReBook
            // 
            this.btnReBook.AutoSize = true;
            this.btnReBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReBook.FlatAppearance.BorderSize = 0;
            this.btnReBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReBook.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReBook.Location = new System.Drawing.Point(0, 344);
            this.btnReBook.Name = "btnReBook";
            this.btnReBook.Size = new System.Drawing.Size(264, 64);
            this.btnReBook.TabIndex = 3;
            this.btnReBook.Text = "책 반납";
            this.btnReBook.UseVisualStyleBackColor = true;
            // 
            // btnLesson
            // 
            this.btnLesson.AutoSize = true;
            this.btnLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLesson.FlatAppearance.BorderSize = 0;
            this.btnLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLesson.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLesson.Location = new System.Drawing.Point(0, 408);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(264, 64);
            this.btnLesson.TabIndex = 4;
            this.btnLesson.Text = "교실";
            this.btnLesson.UseVisualStyleBackColor = true;
            this.btnLesson.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.AutoSize = true;
            this.btnMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMedia.Location = new System.Drawing.Point(0, 472);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(264, 64);
            this.btnMedia.TabIndex = 5;
            this.btnMedia.Text = "영상관";
            this.btnMedia.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(0, 536);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(264, 64);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxSlider
            // 
            this.cbxSlider.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxSlider.BackColor = System.Drawing.Color.Transparent;
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
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Location = new System.Drawing.Point(291, 60);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(987, 600);
            this.panelCenter.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Team1_Project.Properties.Resources.bord_Pink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 211);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(1103, 12);
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
            this.myProfile.BackColor = System.Drawing.Color.DarkTurquoise;
            this.myProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myProfile.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.myProfile.Location = new System.Drawing.Point(1000, 12);
            this.myProfile.Name = "myProfile";
            this.myProfile.Padding = new System.Windows.Forms.Padding(25, 11, 25, 11);
            this.myProfile.Size = new System.Drawing.Size(97, 37);
            this.myProfile.TabIndex = 5;
            this.myProfile.Text = "내 정보";
            // 
            // labelLogName
            // 
            this.labelLogName.AutoSize = true;
            this.labelLogName.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelLogName.Location = new System.Drawing.Point(813, 23);
            this.labelLogName.Name = "labelLogName";
            this.labelLogName.Size = new System.Drawing.Size(43, 15);
            this.labelLogName.TabIndex = 6;
            this.labelLogName.Text = "label1";
            this.labelLogName.Visible = false;
            // 
            // btnMainExit
            // 
            this.btnMainExit.BackgroundImage = global::Team1_Project.Properties.Resources.icon_cancel;
            this.btnMainExit.FlatAppearance.BorderSize = 0;
            this.btnMainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainExit.Location = new System.Drawing.Point(1246, 12);
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
            this.Controls.Add(this.labelLogName);
            this.Controls.Add(this.myProfile);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 20, 20);
            this.Text = "홈";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label myProfile;
        public System.Windows.Forms.Label labelLogName;
        private System.Windows.Forms.Button non1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

