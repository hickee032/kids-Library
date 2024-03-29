﻿namespace Team1_Project.ui {
    partial class FormStory {
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
            this.picStroy = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStoryExit1 = new System.Windows.Forms.Button();
            this.btnStoryBack = new System.Windows.Forms.Button();
            this.btnStoryNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelLecAddTitle = new System.Windows.Forms.Label();
            this.btnStoryExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStroy)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picStroy);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 562);
            this.panel1.TabIndex = 0;
            // 
            // picStroy
            // 
            this.picStroy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picStroy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picStroy.Location = new System.Drawing.Point(0, 0);
            this.picStroy.Name = "picStroy";
            this.picStroy.Size = new System.Drawing.Size(919, 498);
            this.picStroy.TabIndex = 3;
            this.picStroy.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.btnStoryExit1);
            this.panel2.Controls.Add(this.btnStoryBack);
            this.panel2.Controls.Add(this.btnStoryNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 64);
            this.panel2.TabIndex = 2;
            // 
            // btnStoryExit1
            // 
            this.btnStoryExit1.BackColor = System.Drawing.Color.Transparent;
            this.btnStoryExit1.BackgroundImage = global::Team1_Project.Properties.Resources.icon_exit;
            this.btnStoryExit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStoryExit1.FlatAppearance.BorderSize = 0;
            this.btnStoryExit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryExit1.Location = new System.Drawing.Point(414, 0);
            this.btnStoryExit1.Name = "btnStoryExit1";
            this.btnStoryExit1.Size = new System.Drawing.Size(87, 64);
            this.btnStoryExit1.TabIndex = 2;
            this.btnStoryExit1.UseVisualStyleBackColor = false;
            this.btnStoryExit1.Click += new System.EventHandler(this.btnStoryExit1_Click);
            // 
            // btnStoryBack
            // 
            this.btnStoryBack.BackgroundImage = global::Team1_Project.Properties.Resources.icon_back;
            this.btnStoryBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStoryBack.FlatAppearance.BorderSize = 0;
            this.btnStoryBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryBack.Location = new System.Drawing.Point(16, 0);
            this.btnStoryBack.Name = "btnStoryBack";
            this.btnStoryBack.Size = new System.Drawing.Size(64, 64);
            this.btnStoryBack.TabIndex = 1;
            this.btnStoryBack.UseVisualStyleBackColor = true;
            this.btnStoryBack.Click += new System.EventHandler(this.btnStoryBack_Click);
            // 
            // btnStoryNext
            // 
            this.btnStoryNext.BackgroundImage = global::Team1_Project.Properties.Resources.icon_next;
            this.btnStoryNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStoryNext.FlatAppearance.BorderSize = 0;
            this.btnStoryNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryNext.Location = new System.Drawing.Point(838, 0);
            this.btnStoryNext.Name = "btnStoryNext";
            this.btnStoryNext.Size = new System.Drawing.Size(64, 64);
            this.btnStoryNext.TabIndex = 0;
            this.btnStoryNext.UseVisualStyleBackColor = true;
            this.btnStoryNext.Click += new System.EventHandler(this.btnStoryNext_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Controls.Add(this.labelLecAddTitle);
            this.panel3.Controls.Add(this.btnStoryExit);
            this.panel3.Location = new System.Drawing.Point(0, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 45);
            this.panel3.TabIndex = 53;
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
            // btnStoryExit
            // 
            this.btnStoryExit.BackgroundImage = global::Team1_Project.Properties.Resources.icon_cancel;
            this.btnStoryExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStoryExit.FlatAppearance.BorderSize = 0;
            this.btnStoryExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryExit.Location = new System.Drawing.Point(915, 6);
            this.btnStoryExit.Name = "btnStoryExit";
            this.btnStoryExit.Size = new System.Drawing.Size(32, 32);
            this.btnStoryExit.TabIndex = 2;
            this.btnStoryExit.UseVisualStyleBackColor = true;
            this.btnStoryExit.Click += new System.EventHandler(this.btnStoryExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(958, 591);
            this.panel4.TabIndex = 54;
            // 
            // FormStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 642);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "FormStory";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.FormStory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStroy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picStroy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStoryExit;
        private System.Windows.Forms.Button btnStoryBack;
        private System.Windows.Forms.Button btnStoryNext;
        private System.Windows.Forms.Button btnStoryExit1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label labelLecAddTitle;
        private System.Windows.Forms.Panel panel4;
    }
}