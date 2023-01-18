namespace Team1_Project.ui {
    partial class FormMdCustomer {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.picview = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbModLnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbModCnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModCname = new System.Windows.Forms.TextBox();
            this.tbModCint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbModCage = new System.Windows.Forms.TextBox();
            this.tbModCschool = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbModCgen = new System.Windows.Forms.TextBox();
            this.tbModTnum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModCtel = new System.Windows.Forms.TextBox();
            this.tbModPnum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbModClast = new System.Windows.Forms.TextBox();
            this.tbModCtype = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCusDel = new System.Windows.Forms.Button();
            this.btnCusMod = new System.Windows.Forms.Button();
            this.btnFindInit = new System.Windows.Forms.Button();
            this.chkParent = new System.Windows.Forms.CheckBox();
            this.chkChild = new System.Windows.Forms.CheckBox();
            this.btnCusFind = new System.Windows.Forms.Button();
            this.tbFindCus = new System.Windows.Forms.TextBox();
            this.cbFindOption = new System.Windows.Forms.ComboBox();
            this.cusLView = new System.Windows.Forms.ListView();
            this.lvCnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCgen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCtel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvClast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCschool = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLecAddTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picview);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCusDel);
            this.panel1.Controls.Add(this.btnCusMod);
            this.panel1.Controls.Add(this.btnFindInit);
            this.panel1.Controls.Add(this.chkParent);
            this.panel1.Controls.Add(this.chkChild);
            this.panel1.Controls.Add(this.btnCusFind);
            this.panel1.Controls.Add(this.tbFindCus);
            this.panel1.Controls.Add(this.cbFindOption);
            this.panel1.Controls.Add(this.cusLView);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 549);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Team1_Project.Properties.Resources.icon_addC;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(689, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 112;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picview
            // 
            this.picview.BackColor = System.Drawing.Color.White;
            this.picview.BackgroundImage = global::Team1_Project.Properties.Resources.pic_charPNG;
            this.picview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picview.Location = new System.Drawing.Point(18, 309);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(191, 220);
            this.picview.TabIndex = 111;
            this.picview.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbModLnum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tbModCnum);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbModCname);
            this.panel2.Controls.Add(this.tbModCint);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tbModCage);
            this.panel2.Controls.Add(this.tbModCschool);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbModCgen);
            this.panel2.Controls.Add(this.tbModTnum);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbModCtel);
            this.panel2.Controls.Add(this.tbModPnum);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbModClast);
            this.panel2.Controls.Add(this.tbModCtype);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(224, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 220);
            this.panel2.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 100;
            this.label10.Text = "선생님 번호";
            // 
            // tbModLnum
            // 
            this.tbModLnum.Location = new System.Drawing.Point(331, 191);
            this.tbModLnum.Name = "tbModLnum";
            this.tbModLnum.Size = new System.Drawing.Size(100, 21);
            this.tbModLnum.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 84;
            this.label1.Text = "회원번호";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 12);
            this.label13.TabIndex = 108;
            this.label13.Text = "강좌 번호";
            // 
            // tbModCnum
            // 
            this.tbModCnum.Location = new System.Drawing.Point(103, 11);
            this.tbModCnum.Name = "tbModCnum";
            this.tbModCnum.Size = new System.Drawing.Size(100, 21);
            this.tbModCnum.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 86;
            this.label2.Text = "이름";
            // 
            // tbModCname
            // 
            this.tbModCname.Location = new System.Drawing.Point(103, 49);
            this.tbModCname.Name = "tbModCname";
            this.tbModCname.Size = new System.Drawing.Size(100, 21);
            this.tbModCname.TabIndex = 87;
            // 
            // tbModCint
            // 
            this.tbModCint.Location = new System.Drawing.Point(331, 156);
            this.tbModCint.Name = "tbModCint";
            this.tbModCint.Size = new System.Drawing.Size(100, 21);
            this.tbModCint.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 88;
            this.label3.Text = "나이";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(255, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 104;
            this.label12.Text = "관심사";
            // 
            // tbModCage
            // 
            this.tbModCage.Location = new System.Drawing.Point(103, 87);
            this.tbModCage.Name = "tbModCage";
            this.tbModCage.Size = new System.Drawing.Size(100, 21);
            this.tbModCage.TabIndex = 89;
            // 
            // tbModCschool
            // 
            this.tbModCschool.Location = new System.Drawing.Point(331, 123);
            this.tbModCschool.Name = "tbModCschool";
            this.tbModCschool.Size = new System.Drawing.Size(100, 21);
            this.tbModCschool.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 90;
            this.label4.Text = "성별";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 102;
            this.label11.Text = "소속";
            // 
            // tbModCgen
            // 
            this.tbModCgen.Location = new System.Drawing.Point(103, 123);
            this.tbModCgen.Name = "tbModCgen";
            this.tbModCgen.Size = new System.Drawing.Size(100, 21);
            this.tbModCgen.TabIndex = 91;
            // 
            // tbModTnum
            // 
            this.tbModTnum.Location = new System.Drawing.Point(331, 87);
            this.tbModTnum.Name = "tbModTnum";
            this.tbModTnum.Size = new System.Drawing.Size(100, 21);
            this.tbModTnum.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 92;
            this.label5.Text = "연락처";
            // 
            // tbModCtel
            // 
            this.tbModCtel.Location = new System.Drawing.Point(103, 157);
            this.tbModCtel.Name = "tbModCtel";
            this.tbModCtel.Size = new System.Drawing.Size(100, 21);
            this.tbModCtel.TabIndex = 93;
            // 
            // tbModPnum
            // 
            this.tbModPnum.Location = new System.Drawing.Point(331, 52);
            this.tbModPnum.Name = "tbModPnum";
            this.tbModPnum.Size = new System.Drawing.Size(100, 21);
            this.tbModPnum.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 94;
            this.label7.Text = "마지막 접속일";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 98;
            this.label9.Text = "부모님 번호";
            // 
            // tbModClast
            // 
            this.tbModClast.Location = new System.Drawing.Point(103, 189);
            this.tbModClast.Name = "tbModClast";
            this.tbModClast.Size = new System.Drawing.Size(100, 21);
            this.tbModClast.TabIndex = 95;
            // 
            // tbModCtype
            // 
            this.tbModCtype.Location = new System.Drawing.Point(331, 11);
            this.tbModCtype.Name = "tbModCtype";
            this.tbModCtype.Size = new System.Drawing.Size(100, 21);
            this.tbModCtype.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 96;
            this.label8.Text = "회원 타입";
            // 
            // btnCusDel
            // 
            this.btnCusDel.BackgroundImage = global::Team1_Project.Properties.Resources.btn_del;
            this.btnCusDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCusDel.FlatAppearance.BorderSize = 0;
            this.btnCusDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusDel.Location = new System.Drawing.Point(689, 356);
            this.btnCusDel.Name = "btnCusDel";
            this.btnCusDel.Size = new System.Drawing.Size(80, 30);
            this.btnCusDel.TabIndex = 107;
            this.btnCusDel.UseVisualStyleBackColor = true;
            this.btnCusDel.Click += new System.EventHandler(this.btnCusDel_Click);
            // 
            // btnCusMod
            // 
            this.btnCusMod.BackgroundImage = global::Team1_Project.Properties.Resources.btn_mdfy;
            this.btnCusMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCusMod.FlatAppearance.BorderSize = 0;
            this.btnCusMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusMod.Location = new System.Drawing.Point(689, 320);
            this.btnCusMod.Name = "btnCusMod";
            this.btnCusMod.Size = new System.Drawing.Size(80, 30);
            this.btnCusMod.TabIndex = 106;
            this.btnCusMod.UseVisualStyleBackColor = true;
            this.btnCusMod.Click += new System.EventHandler(this.btnCusMod_Click);
            // 
            // btnFindInit
            // 
            this.btnFindInit.BackgroundImage = global::Team1_Project.Properties.Resources.btn_reset;
            this.btnFindInit.FlatAppearance.BorderSize = 0;
            this.btnFindInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindInit.Location = new System.Drawing.Point(704, 12);
            this.btnFindInit.Name = "btnFindInit";
            this.btnFindInit.Size = new System.Drawing.Size(65, 37);
            this.btnFindInit.TabIndex = 81;
            this.btnFindInit.UseVisualStyleBackColor = true;
            this.btnFindInit.Click += new System.EventHandler(this.btnFindInit_Click);
            // 
            // chkParent
            // 
            this.chkParent.AutoSize = true;
            this.chkParent.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkParent.Location = new System.Drawing.Point(273, 20);
            this.chkParent.Name = "chkParent";
            this.chkParent.Size = new System.Drawing.Size(50, 19);
            this.chkParent.TabIndex = 80;
            this.chkParent.Text = "성인";
            this.chkParent.UseVisualStyleBackColor = true;
            this.chkParent.CheckedChanged += new System.EventHandler(this.chkParent_CheckedChanged);
            // 
            // chkChild
            // 
            this.chkChild.AutoSize = true;
            this.chkChild.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkChild.Location = new System.Drawing.Point(327, 20);
            this.chkChild.Name = "chkChild";
            this.chkChild.Size = new System.Drawing.Size(62, 19);
            this.chkChild.TabIndex = 79;
            this.chkChild.Text = "어린이";
            this.chkChild.UseVisualStyleBackColor = true;
            this.chkChild.CheckedChanged += new System.EventHandler(this.chkChild_CheckedChanged);
            // 
            // btnCusFind
            // 
            this.btnCusFind.BackgroundImage = global::Team1_Project.Properties.Resources.icon_search1;
            this.btnCusFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCusFind.FlatAppearance.BorderSize = 0;
            this.btnCusFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusFind.Location = new System.Drawing.Point(633, 12);
            this.btnCusFind.Name = "btnCusFind";
            this.btnCusFind.Size = new System.Drawing.Size(65, 37);
            this.btnCusFind.TabIndex = 78;
            this.btnCusFind.UseVisualStyleBackColor = true;
            this.btnCusFind.Click += new System.EventHandler(this.btnCusFind_Click);
            // 
            // tbFindCus
            // 
            this.tbFindCus.Location = new System.Drawing.Point(494, 20);
            this.tbFindCus.Name = "tbFindCus";
            this.tbFindCus.Size = new System.Drawing.Size(133, 21);
            this.tbFindCus.TabIndex = 77;
            // 
            // cbFindOption
            // 
            this.cbFindOption.FormattingEnabled = true;
            this.cbFindOption.Items.AddRange(new object[] {
            "이름",
            "회원번호",
            "소속",
            "연락처"});
            this.cbFindOption.Location = new System.Drawing.Point(415, 20);
            this.cbFindOption.Name = "cbFindOption";
            this.cbFindOption.Size = new System.Drawing.Size(73, 20);
            this.cbFindOption.TabIndex = 76;
            // 
            // cusLView
            // 
            this.cusLView.BackColor = System.Drawing.Color.BurlyWood;
            this.cusLView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cusLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvCnum,
            this.lvCname,
            this.lvCage,
            this.lvCgen,
            this.lvCtel,
            this.lvClast,
            this.lvCtype,
            this.lvPnum,
            this.lvTnum,
            this.lvCschool,
            this.lvCint});
            this.cusLView.FullRowSelect = true;
            this.cusLView.GridLines = true;
            this.cusLView.HideSelection = false;
            this.cusLView.Location = new System.Drawing.Point(18, 55);
            this.cusLView.Name = "cusLView";
            this.cusLView.Size = new System.Drawing.Size(756, 248);
            this.cusLView.TabIndex = 75;
            this.cusLView.UseCompatibleStateImageBehavior = false;
            this.cusLView.View = System.Windows.Forms.View.Details;
            this.cusLView.SelectedIndexChanged += new System.EventHandler(this.cusLView_SelectedIndexChanged);
            // 
            // lvCnum
            // 
            this.lvCnum.Text = "회원번호";
            this.lvCnum.Width = 67;
            // 
            // lvCname
            // 
            this.lvCname.Text = "이름";
            this.lvCname.Width = 56;
            // 
            // lvCage
            // 
            this.lvCage.Text = "나이";
            this.lvCage.Width = 37;
            // 
            // lvCgen
            // 
            this.lvCgen.Text = "성별";
            this.lvCgen.Width = 36;
            // 
            // lvCtel
            // 
            this.lvCtel.Text = "연락처";
            this.lvCtel.Width = 91;
            // 
            // lvClast
            // 
            this.lvClast.Text = "마지막 접속일";
            this.lvClast.Width = 89;
            // 
            // lvCtype
            // 
            this.lvCtype.Text = "회원 타입";
            this.lvCtype.Width = 71;
            // 
            // lvPnum
            // 
            this.lvPnum.Text = "부모님 번호";
            this.lvPnum.Width = 79;
            // 
            // lvTnum
            // 
            this.lvTnum.Text = "선생님 번호";
            this.lvTnum.Width = 86;
            // 
            // lvCschool
            // 
            this.lvCschool.Text = "소속";
            this.lvCschool.Width = 75;
            // 
            // lvCint
            // 
            this.lvCint.Text = "관심사";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Controls.Add(this.labelLecAddTitle);
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 45);
            this.panel3.TabIndex = 52;
            // 
            // labelLecAddTitle
            // 
            this.labelLecAddTitle.AutoSize = true;
            this.labelLecAddTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLecAddTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLecAddTitle.Location = new System.Drawing.Point(23, 11);
            this.labelLecAddTitle.Name = "labelLecAddTitle";
            this.labelLecAddTitle.Size = new System.Drawing.Size(142, 24);
            this.labelLecAddTitle.TabIndex = 9;
            this.labelLecAddTitle.Text = "회원 정보 수정";
            // 
            // FormMdCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 598);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormMdCustomer";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.FormMdCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbModLnum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCusDel;
        private System.Windows.Forms.Button btnCusMod;
        private System.Windows.Forms.TextBox tbModCint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbModCschool;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbModTnum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbModPnum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbModCtype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbModClast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbModCtel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModCgen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbModCage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModCname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModCnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindInit;
        private System.Windows.Forms.CheckBox chkParent;
        private System.Windows.Forms.CheckBox chkChild;
        private System.Windows.Forms.Button btnCusFind;
        private System.Windows.Forms.TextBox tbFindCus;
        private System.Windows.Forms.ComboBox cbFindOption;
        private System.Windows.Forms.ListView cusLView;
        private System.Windows.Forms.ColumnHeader lvCnum;
        private System.Windows.Forms.ColumnHeader lvCname;
        private System.Windows.Forms.ColumnHeader lvCage;
        private System.Windows.Forms.ColumnHeader lvCgen;
        private System.Windows.Forms.ColumnHeader lvCtel;
        private System.Windows.Forms.ColumnHeader lvClast;
        private System.Windows.Forms.ColumnHeader lvCtype;
        private System.Windows.Forms.ColumnHeader lvPnum;
        private System.Windows.Forms.ColumnHeader lvTnum;
        private System.Windows.Forms.ColumnHeader lvCschool;
        private System.Windows.Forms.ColumnHeader lvCint;
        private System.Windows.Forms.PictureBox picview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label labelLecAddTitle;
        private System.Windows.Forms.Button button1;
    }
}