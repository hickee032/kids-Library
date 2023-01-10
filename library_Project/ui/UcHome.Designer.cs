namespace Team1_Project.ui {
    partial class UcHome {
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHomeBC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.postChange = new System.Windows.Forms.Timer(this.components);
            this.picLibStory = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picBook2 = new System.Windows.Forms.PictureBox();
            this.picBook1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbHomeBan1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibStory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeBan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLibStory);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelVideo);
            this.panel1.Controls.Add(this.btnMap);
            this.panel1.Controls.Add(this.panelHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 600);
            this.panel1.TabIndex = 0;
            // 
            // panelVideo
            // 
            this.panelVideo.Location = new System.Drawing.Point(300, 76);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(381, 243);
            this.panelVideo.TabIndex = 4;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Transparent;
            this.panelHome.Controls.Add(this.pictureBox4);
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Controls.Add(this.panel2);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.pictureBox2);
            this.panelHome.Controls.Add(this.pbHomeBan1);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(987, 600);
            this.panelHome.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(61, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "도서관 이야기";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.picBook2);
            this.panel2.Controls.Add(this.picBook1);
            this.panel2.Controls.Add(this.labelHomeBC);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(299, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 249);
            this.panel2.TabIndex = 9;
            // 
            // labelHomeBC
            // 
            this.labelHomeBC.AutoSize = true;
            this.labelHomeBC.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelHomeBC.Location = new System.Drawing.Point(42, 11);
            this.labelHomeBC.Name = "labelHomeBC";
            this.labelHomeBC.Size = new System.Drawing.Size(130, 23);
            this.labelHomeBC.TabIndex = 10;
            this.labelHomeBC.Text = "사서의 추천책";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(341, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "이 달의 추천책";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(738, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 모집중 강좌";
            // 
            // postChange
            // 
            this.postChange.Tick += new System.EventHandler(this.postChange_Tick);
            // 
            // picLibStory
            // 
            this.picLibStory.BackgroundImage = global::Team1_Project.Properties.Resources.libStory12;
            this.picLibStory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLibStory.Location = new System.Drawing.Point(16, 76);
            this.picLibStory.Name = "picLibStory";
            this.picLibStory.Size = new System.Drawing.Size(277, 501);
            this.picLibStory.TabIndex = 11;
            this.picLibStory.TabStop = false;
            this.picLibStory.Click += new System.EventHandler(this.picLibStory_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Team1_Project.Properties.Resources.Icon_youtube;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(827, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Transparent;
            this.btnMap.BackgroundImage = global::Team1_Project.Properties.Resources.icon_map;
            this.btnMap.FlatAppearance.BorderSize = 0;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Location = new System.Drawing.Point(906, 513);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(64, 64);
            this.btnMap.TabIndex = 3;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Team1_Project.Properties.Resources.icon_book;
            this.pictureBox4.Location = new System.Drawing.Point(16, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // picBook2
            // 
            this.picBook2.BackColor = System.Drawing.Color.White;
            this.picBook2.Location = new System.Drawing.Point(207, 54);
            this.picBook2.Name = "picBook2";
            this.picBook2.Size = new System.Drawing.Size(142, 172);
            this.picBook2.TabIndex = 12;
            this.picBook2.TabStop = false;
            // 
            // picBook1
            // 
            this.picBook1.BackColor = System.Drawing.Color.White;
            this.picBook1.Location = new System.Drawing.Point(28, 54);
            this.picBook1.Name = "picBook1";
            this.picBook1.Size = new System.Drawing.Size(142, 172);
            this.picBook1.TabIndex = 11;
            this.picBook1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Team1_Project.Properties.Resources.pic_pook;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Team1_Project.Properties.Resources.pic_reko;
            this.pictureBox2.Location = new System.Drawing.Point(299, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pbHomeBan1
            // 
            this.pbHomeBan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHomeBan1.Location = new System.Drawing.Point(693, 76);
            this.pbHomeBan1.Name = "pbHomeBan1";
            this.pbHomeBan1.Size = new System.Drawing.Size(277, 417);
            this.pbHomeBan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomeBan1.TabIndex = 0;
            this.pbHomeBan1.TabStop = false;
            this.pbHomeBan1.Click += new System.EventHandler(this.pbHomeBan1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Team1_Project.Properties.Resources.pic_lesson;
            this.pictureBox1.Location = new System.Drawing.Point(693, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UcHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(987, 600);
            this.Load += new System.EventHandler(this.UcHome_Load);
            this.panel1.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibStory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomeBan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbHomeBan1;
        private System.Windows.Forms.Timer postChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHomeBC;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picBook2;
        private System.Windows.Forms.PictureBox picBook1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picLibStory;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
    }
}
