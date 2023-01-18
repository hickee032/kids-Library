namespace Team1_Project.ui {
    partial class UcBookSearch {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBookSearch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picview = new System.Windows.Forms.PictureBox();
            this.cancelAllBookbtn = new System.Windows.Forms.Button();
            this.cancelBookbtn = new System.Windows.Forms.Button();
            this.selectBookbtn = new System.Windows.Forms.Button();
            this.selectedBookLView = new System.Windows.Forms.ListView();
            this.SelectLvBookNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookAurthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookPub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookCat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookDiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookNOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookCatNOBOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.RecommendBookbtn = new System.Windows.Forms.Button();
            this.bookLView = new System.Windows.Forms.ListView();
            this.lvBookNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookPub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookCat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookDiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookNOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookNOBOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorrowBookbtn = new System.Windows.Forms.Button();
            this.searchBookTextBox = new System.Windows.Forms.TextBox();
            this.searchBookComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBookResetbtn = new System.Windows.Forms.Button();
            this.searchBookbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picview);
            this.panel1.Controls.Add(this.cancelAllBookbtn);
            this.panel1.Controls.Add(this.cancelBookbtn);
            this.panel1.Controls.Add(this.selectBookbtn);
            this.panel1.Controls.Add(this.selectedBookLView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RecommendBookbtn);
            this.panel1.Controls.Add(this.bookLView);
            this.panel1.Controls.Add(this.BorrowBookbtn);
            this.panel1.Controls.Add(this.searchBookTextBox);
            this.panel1.Controls.Add(this.searchBookComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchBookResetbtn);
            this.panel1.Controls.Add(this.searchBookbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 600);
            this.panel1.TabIndex = 0;
            // 
            // picview
            // 
            this.picview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picview.BackgroundImage")));
            this.picview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picview.Location = new System.Drawing.Point(49, 107);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(178, 220);
            this.picview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picview.TabIndex = 31;
            this.picview.TabStop = false;
            // 
            // cancelAllBookbtn
            // 
            this.cancelAllBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.cancelAllBookbtn.Location = new System.Drawing.Point(820, 330);
            this.cancelAllBookbtn.Name = "cancelAllBookbtn";
            this.cancelAllBookbtn.Size = new System.Drawing.Size(109, 28);
            this.cancelAllBookbtn.TabIndex = 30;
            this.cancelAllBookbtn.Text = "비우기";
            this.cancelAllBookbtn.UseVisualStyleBackColor = true;
            this.cancelAllBookbtn.Click += new System.EventHandler(this.cancelAllBookbtn_Click);
            // 
            // cancelBookbtn
            // 
            this.cancelBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.cancelBookbtn.Location = new System.Drawing.Point(694, 330);
            this.cancelBookbtn.Name = "cancelBookbtn";
            this.cancelBookbtn.Size = new System.Drawing.Size(109, 28);
            this.cancelBookbtn.TabIndex = 29;
            this.cancelBookbtn.Text = "취소";
            this.cancelBookbtn.UseVisualStyleBackColor = true;
            this.cancelBookbtn.Click += new System.EventHandler(this.cancelBookbtn_Click);
            // 
            // selectBookbtn
            // 
            this.selectBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.selectBookbtn.Location = new System.Drawing.Point(568, 330);
            this.selectBookbtn.Name = "selectBookbtn";
            this.selectBookbtn.Size = new System.Drawing.Size(109, 28);
            this.selectBookbtn.TabIndex = 28;
            this.selectBookbtn.Text = "선택";
            this.selectBookbtn.UseVisualStyleBackColor = true;
            this.selectBookbtn.Click += new System.EventHandler(this.selectBookbtn_Click);
            // 
            // selectedBookLView
            // 
            this.selectedBookLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SelectLvBookNum,
            this.SelectLvBookName,
            this.SelectLvBookAurthor,
            this.SelectLvBookPub,
            this.SelectLvBookYear,
            this.SelectLvBookCat,
            this.SelectLvBookDiv,
            this.SelectLvBookNOB,
            this.SelectLvBookCatNOBOB});
            this.selectedBookLView.FullRowSelect = true;
            this.selectedBookLView.GridLines = true;
            this.selectedBookLView.HideSelection = false;
            this.selectedBookLView.Location = new System.Drawing.Point(49, 363);
            this.selectedBookLView.Name = "selectedBookLView";
            this.selectedBookLView.Size = new System.Drawing.Size(880, 173);
            this.selectedBookLView.TabIndex = 27;
            this.selectedBookLView.UseCompatibleStateImageBehavior = false;
            this.selectedBookLView.View = System.Windows.Forms.View.Details;
            // 
            // SelectLvBookNum
            // 
            this.SelectLvBookNum.Text = "도서번호";
            // 
            // SelectLvBookName
            // 
            this.SelectLvBookName.Text = "도서제목";
            this.SelectLvBookName.Width = 240;
            // 
            // SelectLvBookAurthor
            // 
            this.SelectLvBookAurthor.Text = "저자";
            this.SelectLvBookAurthor.Width = 160;
            // 
            // SelectLvBookPub
            // 
            this.SelectLvBookPub.Text = "출판사";
            this.SelectLvBookPub.Width = 100;
            // 
            // SelectLvBookYear
            // 
            this.SelectLvBookYear.Text = "출판연도";
            // 
            // SelectLvBookCat
            // 
            this.SelectLvBookCat.Text = "카테고리";
            // 
            // SelectLvBookDiv
            // 
            this.SelectLvBookDiv.Text = "구분";
            this.SelectLvBookDiv.Width = 50;
            // 
            // SelectLvBookNOB
            // 
            this.SelectLvBookNOB.Text = "장서수";
            this.SelectLvBookNOB.Width = 50;
            // 
            // SelectLvBookCatNOBOB
            // 
            this.SelectLvBookCatNOBOB.Text = "대여중인장서수";
            this.SelectLvBookCatNOBOB.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(45, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "담은 도서 목록";
            // 
            // RecommendBookbtn
            // 
            this.RecommendBookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RecommendBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.RecommendBookbtn.Location = new System.Drawing.Point(694, 542);
            this.RecommendBookbtn.Name = "RecommendBookbtn";
            this.RecommendBookbtn.Size = new System.Drawing.Size(109, 28);
            this.RecommendBookbtn.TabIndex = 25;
            this.RecommendBookbtn.Text = "추천";
            this.RecommendBookbtn.UseVisualStyleBackColor = false;
            this.RecommendBookbtn.Click += new System.EventHandler(this.RecommendBookbtn_Click);
            // 
            // bookLView
            // 
            this.bookLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvBookNum,
            this.lvBookName,
            this.lvBookAuthor,
            this.lvBookPub,
            this.lvBookYear,
            this.lvBookCat,
            this.lvBookDiv,
            this.lvBookNOB,
            this.lvBookNOBOB});
            this.bookLView.FullRowSelect = true;
            this.bookLView.GridLines = true;
            this.bookLView.HideSelection = false;
            this.bookLView.Location = new System.Drawing.Point(233, 107);
            this.bookLView.Name = "bookLView";
            this.bookLView.Size = new System.Drawing.Size(696, 220);
            this.bookLView.TabIndex = 24;
            this.bookLView.UseCompatibleStateImageBehavior = false;
            this.bookLView.View = System.Windows.Forms.View.Details;
            this.bookLView.SelectedIndexChanged += new System.EventHandler(this.bookLView_SelectedIndexChanged);
            // 
            // lvBookNum
            // 
            this.lvBookNum.Text = "도서번호";
            // 
            // lvBookName
            // 
            this.lvBookName.Text = "도서제목";
            this.lvBookName.Width = 160;
            // 
            // lvBookAuthor
            // 
            this.lvBookAuthor.Text = "저자";
            this.lvBookAuthor.Width = 100;
            // 
            // lvBookPub
            // 
            this.lvBookPub.Text = "출판사";
            // 
            // lvBookYear
            // 
            this.lvBookYear.Text = "출판연도";
            // 
            // lvBookCat
            // 
            this.lvBookCat.Text = "카테고리";
            // 
            // lvBookDiv
            // 
            this.lvBookDiv.Text = "구분";
            this.lvBookDiv.Width = 50;
            // 
            // lvBookNOB
            // 
            this.lvBookNOB.Text = "장서수";
            this.lvBookNOB.Width = 50;
            // 
            // lvBookNOBOB
            // 
            this.lvBookNOBOB.Text = "대여중인장서수";
            this.lvBookNOBOB.Width = 100;
            // 
            // BorrowBookbtn
            // 
            this.BorrowBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.BorrowBookbtn.Location = new System.Drawing.Point(820, 542);
            this.BorrowBookbtn.Name = "BorrowBookbtn";
            this.BorrowBookbtn.Size = new System.Drawing.Size(109, 28);
            this.BorrowBookbtn.TabIndex = 23;
            this.BorrowBookbtn.Text = "대출";
            this.BorrowBookbtn.UseVisualStyleBackColor = true;
            this.BorrowBookbtn.Click += new System.EventHandler(this.BorrowBookbtn_Click);
            // 
            // searchBookTextBox
            // 
            this.searchBookTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookTextBox.Location = new System.Drawing.Point(272, 73);
            this.searchBookTextBox.Multiline = true;
            this.searchBookTextBox.Name = "searchBookTextBox";
            this.searchBookTextBox.Size = new System.Drawing.Size(416, 28);
            this.searchBookTextBox.TabIndex = 22;
            // 
            // searchBookComboBox
            // 
            this.searchBookComboBox.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookComboBox.FormattingEnabled = true;
            this.searchBookComboBox.Items.AddRange(new object[] {
            "도서번호",
            "도서제목",
            "저자",
            "카테고리",
            "구분"});
            this.searchBookComboBox.Location = new System.Drawing.Point(140, 73);
            this.searchBookComboBox.Name = "searchBookComboBox";
            this.searchBookComboBox.Size = new System.Drawing.Size(126, 28);
            this.searchBookComboBox.TabIndex = 21;
            this.searchBookComboBox.Text = "검색 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "검색항목";
            // 
            // searchBookResetbtn
            // 
            this.searchBookResetbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookResetbtn.Location = new System.Drawing.Point(820, 73);
            this.searchBookResetbtn.Name = "searchBookResetbtn";
            this.searchBookResetbtn.Size = new System.Drawing.Size(109, 28);
            this.searchBookResetbtn.TabIndex = 19;
            this.searchBookResetbtn.Text = "초기화";
            this.searchBookResetbtn.UseVisualStyleBackColor = true;
            this.searchBookResetbtn.Click += new System.EventHandler(this.searchBookResetbtn_Click);
            // 
            // searchBookbtn
            // 
            this.searchBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookbtn.Location = new System.Drawing.Point(694, 73);
            this.searchBookbtn.Name = "searchBookbtn";
            this.searchBookbtn.Size = new System.Drawing.Size(109, 28);
            this.searchBookbtn.TabIndex = 18;
            this.searchBookbtn.Text = "검색";
            this.searchBookbtn.UseVisualStyleBackColor = true;
            this.searchBookbtn.Click += new System.EventHandler(this.searchBookbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(304, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "도서 검색 / 대출 / 추천";
            // 
            // UcBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcBookSearch";
            this.Size = new System.Drawing.Size(974, 600);
            this.Load += new System.EventHandler(this.UcBookSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picview;
        private System.Windows.Forms.Button cancelAllBookbtn;
        private System.Windows.Forms.Button cancelBookbtn;
        private System.Windows.Forms.Button selectBookbtn;
        private System.Windows.Forms.ListView selectedBookLView;
        private System.Windows.Forms.ColumnHeader SelectLvBookNum;
        private System.Windows.Forms.ColumnHeader SelectLvBookName;
        private System.Windows.Forms.ColumnHeader SelectLvBookAurthor;
        private System.Windows.Forms.ColumnHeader SelectLvBookPub;
        private System.Windows.Forms.ColumnHeader SelectLvBookYear;
        private System.Windows.Forms.ColumnHeader SelectLvBookCat;
        private System.Windows.Forms.ColumnHeader SelectLvBookDiv;
        private System.Windows.Forms.ColumnHeader SelectLvBookNOB;
        private System.Windows.Forms.ColumnHeader SelectLvBookCatNOBOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RecommendBookbtn;
        private System.Windows.Forms.ListView bookLView;
        private System.Windows.Forms.ColumnHeader lvBookNum;
        private System.Windows.Forms.ColumnHeader lvBookName;
        private System.Windows.Forms.ColumnHeader lvBookAuthor;
        private System.Windows.Forms.ColumnHeader lvBookPub;
        private System.Windows.Forms.ColumnHeader lvBookYear;
        private System.Windows.Forms.ColumnHeader lvBookCat;
        private System.Windows.Forms.ColumnHeader lvBookDiv;
        private System.Windows.Forms.ColumnHeader lvBookNOB;
        private System.Windows.Forms.ColumnHeader lvBookNOBOB;
        private System.Windows.Forms.Button BorrowBookbtn;
        private System.Windows.Forms.TextBox searchBookTextBox;
        private System.Windows.Forms.ComboBox searchBookComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBookResetbtn;
        private System.Windows.Forms.Button searchBookbtn;
        private System.Windows.Forms.Label label1;
    }
}
