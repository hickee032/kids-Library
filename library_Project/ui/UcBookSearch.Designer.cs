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
            this.cancelAllBookbtn = new System.Windows.Forms.Button();
            this.cancelBookbtn = new System.Windows.Forms.Button();
            this.selectBookbtn = new System.Windows.Forms.Button();
            this.selectedBookLView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.LoanBookbtn = new System.Windows.Forms.Button();
            this.searchBookTextBox = new System.Windows.Forms.TextBox();
            this.searchBookComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBookResetbtn = new System.Windows.Forms.Button();
            this.searchBookbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelAllBookbtn
            // 
            this.cancelAllBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.cancelAllBookbtn.Location = new System.Drawing.Point(820, 330);
            this.cancelAllBookbtn.Name = "cancelAllBookbtn";
            this.cancelAllBookbtn.Size = new System.Drawing.Size(109, 28);
            this.cancelAllBookbtn.TabIndex = 29;
            this.cancelAllBookbtn.Text = "모두 취소";
            this.cancelAllBookbtn.UseVisualStyleBackColor = true;
            // 
            // cancelBookbtn
            // 
            this.cancelBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.cancelBookbtn.Location = new System.Drawing.Point(694, 330);
            this.cancelBookbtn.Name = "cancelBookbtn";
            this.cancelBookbtn.Size = new System.Drawing.Size(109, 28);
            this.cancelBookbtn.TabIndex = 28;
            this.cancelBookbtn.Text = "취소";
            this.cancelBookbtn.UseVisualStyleBackColor = true;
            // 
            // selectBookbtn
            // 
            this.selectBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.selectBookbtn.Location = new System.Drawing.Point(568, 330);
            this.selectBookbtn.Name = "selectBookbtn";
            this.selectBookbtn.Size = new System.Drawing.Size(109, 28);
            this.selectBookbtn.TabIndex = 27;
            this.selectBookbtn.Text = "선택";
            this.selectBookbtn.UseVisualStyleBackColor = true;
            // 
            // selectedBookLView
            // 
            this.selectedBookLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.selectedBookLView.FullRowSelect = true;
            this.selectedBookLView.GridLines = true;
            this.selectedBookLView.HideSelection = false;
            this.selectedBookLView.Location = new System.Drawing.Point(49, 363);
            this.selectedBookLView.Name = "selectedBookLView";
            this.selectedBookLView.Size = new System.Drawing.Size(880, 173);
            this.selectedBookLView.TabIndex = 26;
            this.selectedBookLView.UseCompatibleStateImageBehavior = false;
            this.selectedBookLView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "도서번호";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "도서제목";
            this.columnHeader2.Width = 338;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "저자";
            this.columnHeader3.Width = 177;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "출판사";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "출판연도";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "카테고리";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "구분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(45, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "담은 도서 목록";
            // 
            // RecommendBookbtn
            // 
            this.RecommendBookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RecommendBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.RecommendBookbtn.Location = new System.Drawing.Point(694, 542);
            this.RecommendBookbtn.Name = "RecommendBookbtn";
            this.RecommendBookbtn.Size = new System.Drawing.Size(109, 28);
            this.RecommendBookbtn.TabIndex = 24;
            this.RecommendBookbtn.Text = "추천";
            this.RecommendBookbtn.UseVisualStyleBackColor = false;
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
            this.lvBookDiv});
            this.bookLView.FullRowSelect = true;
            this.bookLView.GridLines = true;
            this.bookLView.HideSelection = false;
            this.bookLView.Location = new System.Drawing.Point(264, 107);
            this.bookLView.Name = "bookLView";
            this.bookLView.Size = new System.Drawing.Size(665, 220);
            this.bookLView.TabIndex = 23;
            this.bookLView.UseCompatibleStateImageBehavior = false;
            this.bookLView.View = System.Windows.Forms.View.Details;
            // 
            // lvBookNum
            // 
            this.lvBookNum.Text = "도서번호";
            // 
            // lvBookName
            // 
            this.lvBookName.Text = "도서제목";
            this.lvBookName.Width = 338;
            // 
            // lvBookAuthor
            // 
            this.lvBookAuthor.Text = "저자";
            this.lvBookAuthor.Width = 177;
            // 
            // lvBookPub
            // 
            this.lvBookPub.Text = "출판사";
            this.lvBookPub.Width = 121;
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
            // 
            // LoanBookbtn
            // 
            this.LoanBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.LoanBookbtn.Location = new System.Drawing.Point(820, 542);
            this.LoanBookbtn.Name = "LoanBookbtn";
            this.LoanBookbtn.Size = new System.Drawing.Size(109, 28);
            this.LoanBookbtn.TabIndex = 22;
            this.LoanBookbtn.Text = "대여";
            this.LoanBookbtn.UseVisualStyleBackColor = true;
            // 
            // searchBookTextBox
            // 
            this.searchBookTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookTextBox.Location = new System.Drawing.Point(272, 73);
            this.searchBookTextBox.Multiline = true;
            this.searchBookTextBox.Name = "searchBookTextBox";
            this.searchBookTextBox.Size = new System.Drawing.Size(416, 28);
            this.searchBookTextBox.TabIndex = 21;
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
            this.searchBookComboBox.TabIndex = 20;
            this.searchBookComboBox.Text = "검색 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "검색항목";
            // 
            // searchBookResetbtn
            // 
            this.searchBookResetbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookResetbtn.Location = new System.Drawing.Point(820, 73);
            this.searchBookResetbtn.Name = "searchBookResetbtn";
            this.searchBookResetbtn.Size = new System.Drawing.Size(109, 28);
            this.searchBookResetbtn.TabIndex = 18;
            this.searchBookResetbtn.Text = "초기화";
            this.searchBookResetbtn.UseVisualStyleBackColor = true;
            // 
            // searchBookbtn
            // 
            this.searchBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookbtn.Location = new System.Drawing.Point(694, 73);
            this.searchBookbtn.Name = "searchBookbtn";
            this.searchBookbtn.Size = new System.Drawing.Size(109, 28);
            this.searchBookbtn.TabIndex = 17;
            this.searchBookbtn.Text = "검색";
            this.searchBookbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(356, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "도서 목록 / 검색";
            // 
            // UcBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelAllBookbtn);
            this.Controls.Add(this.cancelBookbtn);
            this.Controls.Add(this.selectBookbtn);
            this.Controls.Add(this.selectedBookLView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecommendBookbtn);
            this.Controls.Add(this.bookLView);
            this.Controls.Add(this.LoanBookbtn);
            this.Controls.Add(this.searchBookTextBox);
            this.Controls.Add(this.searchBookComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBookResetbtn);
            this.Controls.Add(this.searchBookbtn);
            this.Controls.Add(this.label1);
            this.Name = "UcBookSearch";
            this.Size = new System.Drawing.Size(974, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAllBookbtn;
        private System.Windows.Forms.Button cancelBookbtn;
        private System.Windows.Forms.Button selectBookbtn;
        private System.Windows.Forms.ListView selectedBookLView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
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
        private System.Windows.Forms.Button LoanBookbtn;
        private System.Windows.Forms.TextBox searchBookTextBox;
        private System.Windows.Forms.ComboBox searchBookComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBookResetbtn;
        private System.Windows.Forms.Button searchBookbtn;
        private System.Windows.Forms.Label label1;
    }
}
