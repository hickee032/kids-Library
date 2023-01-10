namespace Team1_Project.ui {
    partial class UcLogin {
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
            this.ctelCheck = new System.Windows.Forms.Label();
            this.cnumCheck = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mLogIn = new System.Windows.Forms.Label();
            this.btnUcLogIn = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogInPWlabel = new System.Windows.Forms.Label();
            this.tbxPW = new System.Windows.Forms.TextBox();
            this.LogInID = new System.Windows.Forms.TextBox();
            this.LogInBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ctelCheck
            // 
            this.ctelCheck.AutoSize = true;
            this.ctelCheck.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ctelCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctelCheck.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ctelCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctelCheck.Location = new System.Drawing.Point(229, 416);
            this.ctelCheck.Name = "ctelCheck";
            this.ctelCheck.Size = new System.Drawing.Size(138, 15);
            this.ctelCheck.TabIndex = 26;
            this.ctelCheck.Text = "회원번호를 잊으셨나요?";
            // 
            // cnumCheck
            // 
            this.cnumCheck.AutoSize = true;
            this.cnumCheck.BackColor = System.Drawing.Color.MediumPurple;
            this.cnumCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cnumCheck.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cnumCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cnumCheck.Location = new System.Drawing.Point(572, 416);
            this.cnumCheck.Name = "cnumCheck";
            this.cnumCheck.Size = new System.Drawing.Size(111, 15);
            this.cnumCheck.TabIndex = 25;
            this.cnumCheck.Text = "회원가입 유무 확인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumPurple;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(556, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "등록하지 않으셨나요?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumPurple;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(578, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "아직 회원으로";
            // 
            // mLogIn
            // 
            this.mLogIn.AutoSize = true;
            this.mLogIn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mLogIn.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.mLogIn.Location = new System.Drawing.Point(773, 525);
            this.mLogIn.Name = "mLogIn";
            this.mLogIn.Padding = new System.Windows.Forms.Padding(25, 11, 15, 11);
            this.mLogIn.Size = new System.Drawing.Size(148, 39);
            this.mLogIn.TabIndex = 22;
            this.mLogIn.Text = "   관리자 로그인";
            // 
            // btnUcLogIn
            // 
            this.btnUcLogIn.AutoSize = true;
            this.btnUcLogIn.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUcLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUcLogIn.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUcLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUcLogIn.Location = new System.Drawing.Point(248, 363);
            this.btnUcLogIn.Name = "btnUcLogIn";
            this.btnUcLogIn.Padding = new System.Windows.Forms.Padding(25, 11, 25, 11);
            this.btnUcLogIn.Size = new System.Drawing.Size(100, 39);
            this.btnUcLogIn.TabIndex = 21;
            this.btnUcLogIn.Text = "로그인";
            this.btnUcLogIn.Click += new System.EventHandler(this.btnUcLogIn_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.BackColor = System.Drawing.Color.SlateBlue;
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.SignUp.Location = new System.Drawing.Point(572, 363);
            this.SignUp.Name = "SignUp";
            this.SignUp.Padding = new System.Windows.Forms.Padding(25, 11, 25, 11);
            this.SignUp.Size = new System.Drawing.Size(114, 39);
            this.SignUp.TabIndex = 20;
            this.SignUp.Text = "회원가입";
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Location = new System.Drawing.Point(498, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(258, 366);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(198, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "회원번호";
            // 
            // LogInPWlabel
            // 
            this.LogInPWlabel.AutoSize = true;
            this.LogInPWlabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LogInPWlabel.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogInPWlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogInPWlabel.Location = new System.Drawing.Point(198, 311);
            this.LogInPWlabel.Name = "LogInPWlabel";
            this.LogInPWlabel.Size = new System.Drawing.Size(64, 17);
            this.LogInPWlabel.TabIndex = 17;
            this.LogInPWlabel.Text = "비밀번호";
            // 
            // tbxPW
            // 
            this.tbxPW.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPW.Location = new System.Drawing.Point(269, 310);
            this.tbxPW.Name = "tbxPW";
            this.tbxPW.PasswordChar = '●';
            this.tbxPW.Size = new System.Drawing.Size(100, 21);
            this.tbxPW.TabIndex = 16;
            // 
            // LogInID
            // 
            this.LogInID.BackColor = System.Drawing.SystemColors.Window;
            this.LogInID.Location = new System.Drawing.Point(269, 266);
            this.LogInID.Name = "LogInID";
            this.LogInID.Size = new System.Drawing.Size(100, 21);
            this.LogInID.TabIndex = 15;
            this.LogInID.Leave += new System.EventHandler(this.LogInID_Leave);
            // 
            // LogInBox1
            // 
            this.LogInBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LogInBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogInBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogInBox1.Location = new System.Drawing.Point(165, 101);
            this.LogInBox1.Name = "LogInBox1";
            this.LogInBox1.Size = new System.Drawing.Size(258, 366);
            this.LogInBox1.TabIndex = 14;
            this.LogInBox1.Text = "";
            // 
            // UcLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctelCheck);
            this.Controls.Add(this.cnumCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mLogIn);
            this.Controls.Add(this.btnUcLogIn);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInPWlabel);
            this.Controls.Add(this.tbxPW);
            this.Controls.Add(this.LogInID);
            this.Controls.Add(this.LogInBox1);
            this.Name = "UcLogin";
            this.Size = new System.Drawing.Size(974, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctelCheck;
        private System.Windows.Forms.Label cnumCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mLogIn;
        private System.Windows.Forms.Label btnUcLogIn;
        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LogInPWlabel;
        private System.Windows.Forms.TextBox tbxPW;
        private System.Windows.Forms.TextBox LogInID;
        private System.Windows.Forms.RichTextBox LogInBox1;
    }
}
