namespace Team1_Project.ui {
    partial class FormEditPfil {
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
            this.modCtype = new System.Windows.Forms.ComboBox();
            this.modCint = new System.Windows.Forms.ComboBox();
            this.profileCnum = new System.Windows.Forms.Label();
            this.ptnumsGroup = new System.Windows.Forms.GroupBox();
            this.modCheckBox2 = new System.Windows.Forms.CheckBox();
            this.modCheckBox1 = new System.Windows.Forms.CheckBox();
            this.modPnum = new System.Windows.Forms.TextBox();
            this.modCschool = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modCtel3 = new System.Windows.Forms.TextBox();
            this.addCtel2 = new System.Windows.Forms.Label();
            this.modCtel1 = new System.Windows.Forms.ComboBox();
            this.modCgenGroup = new System.Windows.Forms.GroupBox();
            this.modCgenM = new System.Windows.Forms.RadioButton();
            this.modCgenF = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modCtel2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modCage = new System.Windows.Forms.TextBox();
            this.NewCnamelb = new System.Windows.Forms.Label();
            this.modCname = new System.Windows.Forms.TextBox();
            this.NewCpwlb = new System.Windows.Forms.Label();
            this.NewCnumlb = new System.Windows.Forms.Label();
            this.modCpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFormEditClose = new System.Windows.Forms.Label();
            this.UpdateProfile = new System.Windows.Forms.Label();
            this.ptnumsGroup.SuspendLayout();
            this.modCgenGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // modCtype
            // 
            this.modCtype.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modCtype.FormattingEnabled = true;
            this.modCtype.Items.AddRange(new object[] {
            "어린이",
            "성인",
            "학부모",
            "선생님"});
            this.modCtype.Location = new System.Drawing.Point(445, 268);
            this.modCtype.Name = "modCtype";
            this.modCtype.Size = new System.Drawing.Size(100, 23);
            this.modCtype.TabIndex = 96;
            // 
            // modCint
            // 
            this.modCint.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modCint.FormattingEnabled = true;
            this.modCint.Items.AddRange(new object[] {
            "기술과학",
            "문학",
            "사회과학",
            "역사",
            "자연과학",
            "철학"});
            this.modCint.Location = new System.Drawing.Point(130, 330);
            this.modCint.Name = "modCint";
            this.modCint.Size = new System.Drawing.Size(100, 23);
            this.modCint.TabIndex = 95;
            // 
            // profileCnum
            // 
            this.profileCnum.AutoSize = true;
            this.profileCnum.BackColor = System.Drawing.Color.Transparent;
            this.profileCnum.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.profileCnum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.profileCnum.Location = new System.Drawing.Point(132, 70);
            this.profileCnum.Name = "profileCnum";
            this.profileCnum.Size = new System.Drawing.Size(38, 15);
            this.profileCnum.TabIndex = 92;
            this.profileCnum.Text = "Labal";
            // 
            // ptnumsGroup
            // 
            this.ptnumsGroup.BackColor = System.Drawing.Color.DarkOrange;
            this.ptnumsGroup.Controls.Add(this.modCheckBox2);
            this.ptnumsGroup.Controls.Add(this.modCheckBox1);
            this.ptnumsGroup.Controls.Add(this.modPnum);
            this.ptnumsGroup.Controls.Add(this.modCschool);
            this.ptnumsGroup.Location = new System.Drawing.Point(365, 341);
            this.ptnumsGroup.Name = "ptnumsGroup";
            this.ptnumsGroup.Size = new System.Drawing.Size(260, 68);
            this.ptnumsGroup.TabIndex = 90;
            this.ptnumsGroup.TabStop = false;
            // 
            // modCheckBox2
            // 
            this.modCheckBox2.AutoSize = true;
            this.modCheckBox2.Location = new System.Drawing.Point(13, 38);
            this.modCheckBox2.Name = "modCheckBox2";
            this.modCheckBox2.Size = new System.Drawing.Size(100, 16);
            this.modCheckBox2.TabIndex = 1;
            this.modCheckBox2.Text = "소속 학교번호";
            this.modCheckBox2.UseVisualStyleBackColor = true;
            // 
            // modCheckBox1
            // 
            this.modCheckBox1.AutoSize = true;
            this.modCheckBox1.Location = new System.Drawing.Point(13, 16);
            this.modCheckBox1.Name = "modCheckBox1";
            this.modCheckBox1.Size = new System.Drawing.Size(112, 16);
            this.modCheckBox1.TabIndex = 0;
            this.modCheckBox1.Text = "보호자 회원번호";
            this.modCheckBox1.UseVisualStyleBackColor = true;
            // 
            // modPnum
            // 
            this.modPnum.BackColor = System.Drawing.SystemColors.Window;
            this.modPnum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modPnum.Location = new System.Drawing.Point(145, 11);
            this.modPnum.Name = "modPnum";
            this.modPnum.Size = new System.Drawing.Size(100, 21);
            this.modPnum.TabIndex = 18;
            // 
            // modCschool
            // 
            this.modCschool.BackColor = System.Drawing.SystemColors.Window;
            this.modCschool.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modCschool.Location = new System.Drawing.Point(145, 38);
            this.modCschool.Name = "modCschool";
            this.modCschool.Size = new System.Drawing.Size(100, 21);
            this.modCschool.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(366, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 91;
            this.label7.Text = "추가정보";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(366, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "회원유형";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(251, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 88;
            this.label8.Text = "-";
            // 
            // modCtel3
            // 
            this.modCtel3.BackColor = System.Drawing.SystemColors.Window;
            this.modCtel3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modCtel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modCtel3.Location = new System.Drawing.Point(265, 286);
            this.modCtel3.Name = "modCtel3";
            this.modCtel3.Size = new System.Drawing.Size(48, 22);
            this.modCtel3.TabIndex = 87;
            // 
            // addCtel2
            // 
            this.addCtel2.AutoSize = true;
            this.addCtel2.BackColor = System.Drawing.Color.Transparent;
            this.addCtel2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addCtel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addCtel2.Location = new System.Drawing.Point(187, 290);
            this.addCtel2.Name = "addCtel2";
            this.addCtel2.Size = new System.Drawing.Size(12, 15);
            this.addCtel2.TabIndex = 86;
            this.addCtel2.Text = "-";
            // 
            // modCtel1
            // 
            this.modCtel1.FormattingEnabled = true;
            this.modCtel1.Items.AddRange(new object[] {
            "010"});
            this.modCtel1.Location = new System.Drawing.Point(130, 286);
            this.modCtel1.Name = "modCtel1";
            this.modCtel1.Size = new System.Drawing.Size(54, 20);
            this.modCtel1.TabIndex = 85;
            this.modCtel1.Text = "선택";
            // 
            // modCgenGroup
            // 
            this.modCgenGroup.Controls.Add(this.modCgenM);
            this.modCgenGroup.Controls.Add(this.modCgenF);
            this.modCgenGroup.Location = new System.Drawing.Point(124, 227);
            this.modCgenGroup.Name = "modCgenGroup";
            this.modCgenGroup.Size = new System.Drawing.Size(115, 45);
            this.modCgenGroup.TabIndex = 84;
            this.modCgenGroup.TabStop = false;
            // 
            // modCgenM
            // 
            this.modCgenM.AutoSize = true;
            this.modCgenM.Location = new System.Drawing.Point(11, 18);
            this.modCgenM.Name = "modCgenM";
            this.modCgenM.Size = new System.Drawing.Size(35, 16);
            this.modCgenM.TabIndex = 32;
            this.modCgenM.TabStop = true;
            this.modCgenM.Text = "남";
            this.modCgenM.UseVisualStyleBackColor = true;
            // 
            // modCgenF
            // 
            this.modCgenF.AutoSize = true;
            this.modCgenF.Location = new System.Drawing.Point(66, 18);
            this.modCgenF.Name = "modCgenF";
            this.modCgenF.Size = new System.Drawing.Size(35, 16);
            this.modCgenF.TabIndex = 33;
            this.modCgenF.TabStop = true;
            this.modCgenF.Text = "여";
            this.modCgenF.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(44, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "성별";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(44, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "관심사";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(44, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "연락처";
            // 
            // modCtel2
            // 
            this.modCtel2.BackColor = System.Drawing.SystemColors.Window;
            this.modCtel2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.modCtel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modCtel2.Location = new System.Drawing.Point(201, 286);
            this.modCtel2.Name = "modCtel2";
            this.modCtel2.Size = new System.Drawing.Size(48, 22);
            this.modCtel2.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(44, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "나이";
            // 
            // modCage
            // 
            this.modCage.BackColor = System.Drawing.SystemColors.Window;
            this.modCage.Location = new System.Drawing.Point(130, 199);
            this.modCage.Name = "modCage";
            this.modCage.Size = new System.Drawing.Size(100, 21);
            this.modCage.TabIndex = 78;
            // 
            // NewCnamelb
            // 
            this.NewCnamelb.AutoSize = true;
            this.NewCnamelb.BackColor = System.Drawing.Color.Transparent;
            this.NewCnamelb.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewCnamelb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NewCnamelb.Location = new System.Drawing.Point(44, 158);
            this.NewCnamelb.Name = "NewCnamelb";
            this.NewCnamelb.Size = new System.Drawing.Size(36, 17);
            this.NewCnamelb.TabIndex = 77;
            this.NewCnamelb.Text = "이름";
            // 
            // modCname
            // 
            this.modCname.BackColor = System.Drawing.SystemColors.Window;
            this.modCname.Location = new System.Drawing.Point(130, 154);
            this.modCname.Name = "modCname";
            this.modCname.Size = new System.Drawing.Size(100, 21);
            this.modCname.TabIndex = 76;
            // 
            // NewCpwlb
            // 
            this.NewCpwlb.AutoSize = true;
            this.NewCpwlb.BackColor = System.Drawing.Color.Transparent;
            this.NewCpwlb.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewCpwlb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NewCpwlb.Location = new System.Drawing.Point(44, 114);
            this.NewCpwlb.Name = "NewCpwlb";
            this.NewCpwlb.Size = new System.Drawing.Size(64, 17);
            this.NewCpwlb.TabIndex = 75;
            this.NewCpwlb.Text = "비밀번호";
            // 
            // NewCnumlb
            // 
            this.NewCnumlb.AutoSize = true;
            this.NewCnumlb.BackColor = System.Drawing.Color.Transparent;
            this.NewCnumlb.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewCnumlb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NewCnumlb.Location = new System.Drawing.Point(44, 69);
            this.NewCnumlb.Name = "NewCnumlb";
            this.NewCnumlb.Size = new System.Drawing.Size(50, 17);
            this.NewCnumlb.TabIndex = 74;
            this.NewCnumlb.Text = "아이디";
            // 
            // modCpw
            // 
            this.modCpw.BackColor = System.Drawing.SystemColors.Window;
            this.modCpw.Location = new System.Drawing.Point(130, 110);
            this.modCpw.Name = "modCpw";
            this.modCpw.PasswordChar = '●';
            this.modCpw.Size = new System.Drawing.Size(100, 21);
            this.modCpw.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "내 정보 수정";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-1, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 40);
            this.panel4.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.profileCnum);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelFormEditClose);
            this.panel1.Controls.Add(this.NewCnumlb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.UpdateProfile);
            this.panel1.Controls.Add(this.modCtype);
            this.panel1.Controls.Add(this.NewCpwlb);
            this.panel1.Controls.Add(this.modCint);
            this.panel1.Controls.Add(this.NewCnamelb);
            this.panel1.Controls.Add(this.ptnumsGroup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.modCpw);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.modCname);
            this.panel1.Controls.Add(this.modCtel3);
            this.panel1.Controls.Add(this.modCage);
            this.panel1.Controls.Add(this.addCtel2);
            this.panel1.Controls.Add(this.modCtel2);
            this.panel1.Controls.Add(this.modCtel1);
            this.panel1.Controls.Add(this.modCgenGroup);
            this.panel1.Location = new System.Drawing.Point(-1, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 529);
            this.panel1.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Team1_Project.Properties.Resources.pic_charMd;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(365, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 203);
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // labelFormEditClose
            // 
            this.labelFormEditClose.BackColor = System.Drawing.Color.Transparent;
            this.labelFormEditClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFormEditClose.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFormEditClose.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFormEditClose.Image = global::Team1_Project.Properties.Resources.icon_addC;
            this.labelFormEditClose.Location = new System.Drawing.Point(337, 455);
            this.labelFormEditClose.Name = "labelFormEditClose";
            this.labelFormEditClose.Padding = new System.Windows.Forms.Padding(33, 11, 33, 11);
            this.labelFormEditClose.Size = new System.Drawing.Size(100, 39);
            this.labelFormEditClose.TabIndex = 97;
            this.labelFormEditClose.Click += new System.EventHandler(this.labelFormEditClose_Click);
            // 
            // UpdateProfile
            // 
            this.UpdateProfile.BackColor = System.Drawing.Color.Transparent;
            this.UpdateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateProfile.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdateProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateProfile.Image = global::Team1_Project.Properties.Resources.btn_mdfy;
            this.UpdateProfile.Location = new System.Drawing.Point(229, 455);
            this.UpdateProfile.Name = "UpdateProfile";
            this.UpdateProfile.Padding = new System.Windows.Forms.Padding(33, 11, 33, 11);
            this.UpdateProfile.Size = new System.Drawing.Size(100, 39);
            this.UpdateProfile.TabIndex = 94;
            // 
            // FormEditPfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 570);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FormEditPfil";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ptnumsGroup.ResumeLayout(false);
            this.ptnumsGroup.PerformLayout();
            this.modCgenGroup.ResumeLayout(false);
            this.modCgenGroup.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox modCtype;
        private System.Windows.Forms.ComboBox modCint;
        private System.Windows.Forms.Label UpdateProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label profileCnum;
        private System.Windows.Forms.GroupBox ptnumsGroup;
        private System.Windows.Forms.CheckBox modCheckBox2;
        private System.Windows.Forms.CheckBox modCheckBox1;
        private System.Windows.Forms.TextBox modPnum;
        private System.Windows.Forms.TextBox modCschool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox modCtel3;
        private System.Windows.Forms.Label addCtel2;
        private System.Windows.Forms.ComboBox modCtel1;
        private System.Windows.Forms.GroupBox modCgenGroup;
        private System.Windows.Forms.RadioButton modCgenM;
        private System.Windows.Forms.RadioButton modCgenF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modCtel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modCage;
        private System.Windows.Forms.Label NewCnamelb;
        private System.Windows.Forms.TextBox modCname;
        private System.Windows.Forms.Label NewCpwlb;
        private System.Windows.Forms.Label NewCnumlb;
        private System.Windows.Forms.TextBox modCpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFormEditClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
    }
}