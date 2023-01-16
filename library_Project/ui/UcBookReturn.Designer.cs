namespace Team1_Project.ui {
    partial class UcBookReturn {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBookReturn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedDCBookLView = new System.Windows.Forms.ListView();
            this.SelectLvBookNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvBookAurthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvDaechulDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvDaechulReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLvDaechulNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picview = new System.Windows.Forms.PictureBox();
            this.cancelAllDCBookbtn = new System.Windows.Forms.Button();
            this.cancelDCBookbtn = new System.Windows.Forms.Button();
            this.selectDCBookbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.daechulBookLView = new System.Windows.Forms.ListView();
            this.lvBookNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDaechulDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDaechulReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDaechulNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnDCBookbtn = new System.Windows.Forms.Button();
            this.searchBookTextBox = new System.Windows.Forms.TextBox();
            this.searchBookComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchDCBookResetbtn = new System.Windows.Forms.Button();
            this.searchDCBookbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectedDCBookLView);
            this.panel1.Controls.Add(this.picview);
            this.panel1.Controls.Add(this.cancelAllDCBookbtn);
            this.panel1.Controls.Add(this.cancelDCBookbtn);
            this.panel1.Controls.Add(this.selectDCBookbtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.daechulBookLView);
            this.panel1.Controls.Add(this.ReturnDCBookbtn);
            this.panel1.Controls.Add(this.searchBookTextBox);
            this.panel1.Controls.Add(this.searchBookComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchDCBookResetbtn);
            this.panel1.Controls.Add(this.searchDCBookbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 600);
            this.panel1.TabIndex = 0;
            // 
            // selectedDCBookLView
            // 
            this.selectedDCBookLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SelectLvBookNum,
            this.SelectLvBookName,
            this.SelectLvBookAurthor,
            this.SelectLvDaechulDate,
            this.SelectLvDaechulReturnDate,
            this.SelectLvDaechulNum});
            this.selectedDCBookLView.FullRowSelect = true;
            this.selectedDCBookLView.GridLines = true;
            this.selectedDCBookLView.HideSelection = false;
            this.selectedDCBookLView.Location = new System.Drawing.Point(49, 364);
            this.selectedDCBookLView.Name = "selectedDCBookLView";
            this.selectedDCBookLView.Size = new System.Drawing.Size(880, 172);
            this.selectedDCBookLView.TabIndex = 46;
            this.selectedDCBookLView.UseCompatibleStateImageBehavior = false;
            this.selectedDCBookLView.View = System.Windows.Forms.View.Details;
            // 
            // SelectLvBookNum
            // 
            this.SelectLvBookNum.Text = "도서번호";
            // 
            // SelectLvBookName
            // 
            this.SelectLvBookName.Text = "도서제목";
            this.SelectLvBookName.Width = 326;
            // 
            // SelectLvBookAurthor
            // 
            this.SelectLvBookAurthor.Text = "저자";
            this.SelectLvBookAurthor.Width = 190;
            // 
            // SelectLvDaechulDate
            // 
            this.SelectLvDaechulDate.Text = "대출일";
            this.SelectLvDaechulDate.Width = 120;
            // 
            // SelectLvDaechulReturnDate
            // 
            this.SelectLvDaechulReturnDate.Text = "반납예정일";
            this.SelectLvDaechulReturnDate.Width = 120;
            // 
            // SelectLvDaechulNum
            // 
            this.SelectLvDaechulNum.Text = "대출번호";
            // 
            // picview
            // 
            this.picview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picview.BackgroundImage")));
            this.picview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picview.Location = new System.Drawing.Point(49, 107);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(178, 220);
            this.picview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picview.TabIndex = 45;
            this.picview.TabStop = false;
            // 
            // cancelAllDCBookbtn
            // 
            this.cancelAllDCBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.cancelAllDCBookbtn.Location = new System.Drawing.Point(820, 330);
            this.cancelAllDCBookbtn.Name = "cancelAllDCBookbtn";
            this.cancelAllDCBookbtn.Size = new System.Drawing.Size(109, 28);
            this.cancelAllDCBookbtn.TabIndex = 44;
            this.cancelAllDCBookbtn.Text = "비우기";
            this.cancelAllDCBookbtn.UseVisualStyleBackColor = true;
            this.cancelAllDCBookbtn.Click += new System.EventHandler(this.cancelAllDCBookbtn_Click);
            // 
            // cancelDCBookbtn
            // 
            this.cancelDCBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.cancelDCBookbtn.Location = new System.Drawing.Point(694, 330);
            this.cancelDCBookbtn.Name = "cancelDCBookbtn";
            this.cancelDCBookbtn.Size = new System.Drawing.Size(109, 28);
            this.cancelDCBookbtn.TabIndex = 43;
            this.cancelDCBookbtn.Text = "취소";
            this.cancelDCBookbtn.UseVisualStyleBackColor = true;
            this.cancelDCBookbtn.Click += new System.EventHandler(this.cancelDCBookbtn_Click);
            // 
            // selectDCBookbtn
            // 
            this.selectDCBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.selectDCBookbtn.Location = new System.Drawing.Point(568, 330);
            this.selectDCBookbtn.Name = "selectDCBookbtn";
            this.selectDCBookbtn.Size = new System.Drawing.Size(109, 28);
            this.selectDCBookbtn.TabIndex = 42;
            this.selectDCBookbtn.Text = "선택";
            this.selectDCBookbtn.UseVisualStyleBackColor = true;
            this.selectDCBookbtn.Click += new System.EventHandler(this.selectDCBookbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(45, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "담은 도서 목록";
            // 
            // daechulBookLView
            // 
            this.daechulBookLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvBookNum,
            this.lvBookName,
            this.lvBookAuthor,
            this.lvDaechulDate,
            this.lvDaechulReturnDate,
            this.lvDaechulNum});
            this.daechulBookLView.FullRowSelect = true;
            this.daechulBookLView.GridLines = true;
            this.daechulBookLView.HideSelection = false;
            this.daechulBookLView.Location = new System.Drawing.Point(233, 107);
            this.daechulBookLView.Name = "daechulBookLView";
            this.daechulBookLView.Size = new System.Drawing.Size(696, 220);
            this.daechulBookLView.TabIndex = 40;
            this.daechulBookLView.UseCompatibleStateImageBehavior = false;
            this.daechulBookLView.View = System.Windows.Forms.View.Details;
            this.daechulBookLView.SelectedIndexChanged += new System.EventHandler(this.daechulBookLView_SelectedIndexChanged);
            // 
            // lvBookNum
            // 
            this.lvBookNum.Text = "도서번호";
            // 
            // lvBookName
            // 
            this.lvBookName.Text = "도서제목";
            this.lvBookName.Width = 202;
            // 
            // lvBookAuthor
            // 
            this.lvBookAuthor.Text = "저자";
            this.lvBookAuthor.Width = 130;
            // 
            // lvDaechulDate
            // 
            this.lvDaechulDate.Text = "대출일";
            this.lvDaechulDate.Width = 120;
            // 
            // lvDaechulReturnDate
            // 
            this.lvDaechulReturnDate.Text = "반납예정일";
            this.lvDaechulReturnDate.Width = 120;
            // 
            // lvDaechulNum
            // 
            this.lvDaechulNum.Text = "대출번호";
            // 
            // ReturnDCBookbtn
            // 
            this.ReturnDCBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.ReturnDCBookbtn.Location = new System.Drawing.Point(820, 542);
            this.ReturnDCBookbtn.Name = "ReturnDCBookbtn";
            this.ReturnDCBookbtn.Size = new System.Drawing.Size(109, 28);
            this.ReturnDCBookbtn.TabIndex = 39;
            this.ReturnDCBookbtn.Text = "반납";
            this.ReturnDCBookbtn.UseVisualStyleBackColor = true;
            this.ReturnDCBookbtn.Click += new System.EventHandler(this.ReturnDCBookbtn_Click);
            // 
            // searchBookTextBox
            // 
            this.searchBookTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookTextBox.Location = new System.Drawing.Point(272, 73);
            this.searchBookTextBox.Multiline = true;
            this.searchBookTextBox.Name = "searchBookTextBox";
            this.searchBookTextBox.Size = new System.Drawing.Size(416, 28);
            this.searchBookTextBox.TabIndex = 38;
            // 
            // searchBookComboBox
            // 
            this.searchBookComboBox.Font = new System.Drawing.Font("굴림", 15F);
            this.searchBookComboBox.FormattingEnabled = true;
            this.searchBookComboBox.Items.AddRange(new object[] {
            "도서번호",
            "도서제목",
            "저자",
            "대출일",
            "반납예정일"});
            this.searchBookComboBox.Location = new System.Drawing.Point(140, 73);
            this.searchBookComboBox.Name = "searchBookComboBox";
            this.searchBookComboBox.Size = new System.Drawing.Size(126, 28);
            this.searchBookComboBox.TabIndex = 37;
            this.searchBookComboBox.Text = "검색 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "검색항목";
            // 
            // searchDCBookResetbtn
            // 
            this.searchDCBookResetbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.searchDCBookResetbtn.Location = new System.Drawing.Point(820, 73);
            this.searchDCBookResetbtn.Name = "searchDCBookResetbtn";
            this.searchDCBookResetbtn.Size = new System.Drawing.Size(109, 28);
            this.searchDCBookResetbtn.TabIndex = 35;
            this.searchDCBookResetbtn.Text = "초기화";
            this.searchDCBookResetbtn.UseVisualStyleBackColor = true;
            this.searchDCBookResetbtn.Click += new System.EventHandler(this.searchDCBookResetbtn_Click);
            // 
            // searchDCBookbtn
            // 
            this.searchDCBookbtn.Font = new System.Drawing.Font("굴림", 15F);
            this.searchDCBookbtn.Location = new System.Drawing.Point(694, 73);
            this.searchDCBookbtn.Name = "searchDCBookbtn";
            this.searchDCBookbtn.Size = new System.Drawing.Size(109, 28);
            this.searchDCBookbtn.TabIndex = 34;
            this.searchDCBookbtn.Text = "검색";
            this.searchDCBookbtn.UseVisualStyleBackColor = true;
            this.searchDCBookbtn.Click += new System.EventHandler(this.searchDCBookbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.Location = new System.Drawing.Point(264, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 34);
            this.label1.TabIndex = 33;
            this.label1.Text = "대출 도서 목록 / 반납 / 연장";
            // 
            // UcBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcBookReturn";
            this.Size = new System.Drawing.Size(974, 600);
            this.Load += new System.EventHandler(this.UcBookReturn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView selectedDCBookLView;
        private System.Windows.Forms.ColumnHeader SelectLvBookNum;
        private System.Windows.Forms.ColumnHeader SelectLvBookName;
        private System.Windows.Forms.ColumnHeader SelectLvBookAurthor;
        private System.Windows.Forms.ColumnHeader SelectLvDaechulDate;
        private System.Windows.Forms.ColumnHeader SelectLvDaechulReturnDate;
        private System.Windows.Forms.ColumnHeader SelectLvDaechulNum;
        private System.Windows.Forms.PictureBox picview;
        private System.Windows.Forms.Button cancelAllDCBookbtn;
        private System.Windows.Forms.Button cancelDCBookbtn;
        private System.Windows.Forms.Button selectDCBookbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView daechulBookLView;
        private System.Windows.Forms.ColumnHeader lvBookNum;
        private System.Windows.Forms.ColumnHeader lvBookName;
        private System.Windows.Forms.ColumnHeader lvBookAuthor;
        private System.Windows.Forms.ColumnHeader lvDaechulDate;
        private System.Windows.Forms.ColumnHeader lvDaechulReturnDate;
        private System.Windows.Forms.ColumnHeader lvDaechulNum;
        private System.Windows.Forms.Button ReturnDCBookbtn;
        private System.Windows.Forms.TextBox searchBookTextBox;
        private System.Windows.Forms.ComboBox searchBookComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchDCBookResetbtn;
        private System.Windows.Forms.Button searchDCBookbtn;
        private System.Windows.Forms.Label label1;
    }
}
