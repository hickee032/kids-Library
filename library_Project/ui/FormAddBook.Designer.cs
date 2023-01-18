namespace Team1_Project.ui {
    partial class FormAddBook {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbDiv = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.tbBpub = new System.Windows.Forms.TextBox();
            this.tbBaut = new System.Windows.Forms.TextBox();
            this.tbBname = new System.Windows.Forms.TextBox();
            this.tbBnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.picview = new System.Windows.Forms.PictureBox();
            this.initImg = new System.Windows.Forms.Button();
            this.saveImg = new System.Windows.Forms.Button();
            this.btnReWrite = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLecAddTitle = new System.Windows.Forms.Label();
            this.openFileImg = new System.Windows.Forms.OpenFileDialog();
            this.tbBnob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDiv
            // 
            this.cbDiv.FormattingEnabled = true;
            this.cbDiv.Items.AddRange(new object[] {
            "유아",
            "초등저학년",
            "초등고학년",
            "청소년"});
            this.cbDiv.Location = new System.Drawing.Point(156, 333);
            this.cbDiv.Name = "cbDiv";
            this.cbDiv.Size = new System.Drawing.Size(121, 20);
            this.cbDiv.TabIndex = 46;
            this.cbDiv.Text = "선택";
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Items.AddRange(new object[] {
            "총류",
            "철학",
            "종교",
            "사회과학",
            "자연과학",
            "기술과학",
            "예술",
            "언어(어학)",
            "문학",
            "역사"});
            this.cbCat.Location = new System.Drawing.Point(156, 285);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(121, 20);
            this.cbCat.TabIndex = 45;
            this.cbCat.Text = "선택";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(156, 245);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 20);
            this.cbYear.TabIndex = 42;
            // 
            // tbBpub
            // 
            this.tbBpub.Location = new System.Drawing.Point(156, 189);
            this.tbBpub.Name = "tbBpub";
            this.tbBpub.Size = new System.Drawing.Size(123, 21);
            this.tbBpub.TabIndex = 39;
            // 
            // tbBaut
            // 
            this.tbBaut.Location = new System.Drawing.Point(156, 143);
            this.tbBaut.Name = "tbBaut";
            this.tbBaut.Size = new System.Drawing.Size(123, 21);
            this.tbBaut.TabIndex = 38;
            // 
            // tbBname
            // 
            this.tbBname.Location = new System.Drawing.Point(156, 101);
            this.tbBname.Name = "tbBname";
            this.tbBname.Size = new System.Drawing.Size(123, 21);
            this.tbBname.TabIndex = 37;
            // 
            // tbBnum
            // 
            this.tbBnum.Location = new System.Drawing.Point(156, 52);
            this.tbBnum.Name = "tbBnum";
            this.tbBnum.Size = new System.Drawing.Size(123, 21);
            this.tbBnum.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(33, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "구분";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(33, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "카테고리";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(33, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "출판연도";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(33, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "출판사";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(33, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "저자명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(33, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "도서명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(33, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "도서 번호";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.tbBnob);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picview);
            this.panel1.Controls.Add(this.initImg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.saveImg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbDiv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbCat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.tbBnum);
            this.panel1.Controls.Add(this.btnReWrite);
            this.panel1.Controls.Add(this.tbBname);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.tbBaut);
            this.panel1.Controls.Add(this.tbBpub);
            this.panel1.Location = new System.Drawing.Point(-1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 498);
            this.panel1.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Team1_Project.Properties.Resources.icon_addC;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(378, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picview
            // 
            this.picview.BackgroundImage = global::Team1_Project.Properties.Resources.pic_needPoster;
            this.picview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picview.Location = new System.Drawing.Point(364, 52);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(190, 247);
            this.picview.TabIndex = 47;
            this.picview.TabStop = false;
            // 
            // initImg
            // 
            this.initImg.BackgroundImage = global::Team1_Project.Properties.Resources.icon_minus;
            this.initImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.initImg.FlatAppearance.BorderSize = 0;
            this.initImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initImg.Location = new System.Drawing.Point(517, 304);
            this.initImg.Name = "initImg";
            this.initImg.Size = new System.Drawing.Size(37, 37);
            this.initImg.TabIndex = 49;
            this.initImg.UseVisualStyleBackColor = true;
            // 
            // saveImg
            // 
            this.saveImg.BackgroundImage = global::Team1_Project.Properties.Resources.icon_plus;
            this.saveImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveImg.FlatAppearance.BorderSize = 0;
            this.saveImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveImg.Location = new System.Drawing.Point(474, 304);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(37, 37);
            this.saveImg.TabIndex = 48;
            this.saveImg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveImg.UseVisualStyleBackColor = true;
            this.saveImg.Click += new System.EventHandler(this.addImg_Click);
            // 
            // btnReWrite
            // 
            this.btnReWrite.BackgroundImage = global::Team1_Project.Properties.Resources.icon_addRe;
            this.btnReWrite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReWrite.FlatAppearance.BorderSize = 0;
            this.btnReWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReWrite.Location = new System.Drawing.Point(248, 438);
            this.btnReWrite.Name = "btnReWrite";
            this.btnReWrite.Size = new System.Drawing.Size(107, 42);
            this.btnReWrite.TabIndex = 41;
            this.btnReWrite.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackgroundImage = global::Team1_Project.Properties.Resources.icon_addN;
            this.btnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Location = new System.Drawing.Point(115, 438);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(107, 42);
            this.btnAddBook.TabIndex = 40;
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.labelLecAddTitle);
            this.panel2.Location = new System.Drawing.Point(-1, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 45);
            this.panel2.TabIndex = 51;
            // 
            // labelLecAddTitle
            // 
            this.labelLecAddTitle.AutoSize = true;
            this.labelLecAddTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLecAddTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLecAddTitle.Location = new System.Drawing.Point(23, 11);
            this.labelLecAddTitle.Name = "labelLecAddTitle";
            this.labelLecAddTitle.Size = new System.Drawing.Size(96, 24);
            this.labelLecAddTitle.TabIndex = 9;
            this.labelLecAddTitle.Text = "도서 등록";
            // 
            // openFileImg
            // 
            this.openFileImg.FileName = "openFileDialog1";
            // 
            // tbBnob
            // 
            this.tbBnob.Location = new System.Drawing.Point(156, 381);
            this.tbBnob.Name = "tbBnob";
            this.tbBnob.Size = new System.Drawing.Size(123, 21);
            this.tbBnob.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(39, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "추가 장서수";
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddBook";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button initImg;
        private System.Windows.Forms.Button saveImg;
        private System.Windows.Forms.PictureBox picview;
        private System.Windows.Forms.ComboBox cbDiv;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnReWrite;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox tbBpub;
        private System.Windows.Forms.TextBox tbBaut;
        private System.Windows.Forms.TextBox tbBname;
        private System.Windows.Forms.TextBox tbBnum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label labelLecAddTitle;
        private System.Windows.Forms.OpenFileDialog openFileImg;
        private System.Windows.Forms.TextBox tbBnob;
        private System.Windows.Forms.Label label2;
    }
}