namespace library_Project.ui {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.picStroy = new System.Windows.Forms.PictureBox();
            this.btnStoryExit = new System.Windows.Forms.Button();
            this.btnStoryBack = new System.Windows.Forms.Button();
            this.btnStoryNext = new System.Windows.Forms.Button();
            this.btnStoryExit1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStroy)).BeginInit();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStoryExit1);
            this.panel2.Controls.Add(this.btnStoryBack);
            this.panel2.Controls.Add(this.btnStoryNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 64);
            this.panel2.TabIndex = 2;
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
            // btnStoryExit
            // 
            this.btnStoryExit.BackgroundImage = global::library_Project.Properties.Resources.icon_cancel;
            this.btnStoryExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStoryExit.FlatAppearance.BorderSize = 0;
            this.btnStoryExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryExit.Location = new System.Drawing.Point(907, 22);
            this.btnStoryExit.Name = "btnStoryExit";
            this.btnStoryExit.Size = new System.Drawing.Size(32, 32);
            this.btnStoryExit.TabIndex = 2;
            this.btnStoryExit.UseVisualStyleBackColor = true;
            this.btnStoryExit.Click += new System.EventHandler(this.btnStoryExit_Click);
            // 
            // btnStoryBack
            // 
            this.btnStoryBack.BackgroundImage = global::library_Project.Properties.Resources.icon_back;
            this.btnStoryBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btnStoryNext.BackgroundImage = global::library_Project.Properties.Resources.icon_next;
            this.btnStoryNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStoryNext.FlatAppearance.BorderSize = 0;
            this.btnStoryNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryNext.Location = new System.Drawing.Point(838, 0);
            this.btnStoryNext.Name = "btnStoryNext";
            this.btnStoryNext.Size = new System.Drawing.Size(64, 64);
            this.btnStoryNext.TabIndex = 0;
            this.btnStoryNext.UseVisualStyleBackColor = true;
            this.btnStoryNext.Click += new System.EventHandler(this.btnStoryNext_Click);
            // 
            // btnStoryExit1
            // 
            this.btnStoryExit1.BackColor = System.Drawing.Color.Transparent;
            this.btnStoryExit1.BackgroundImage = global::library_Project.Properties.Resources.icon_exit;
            this.btnStoryExit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStoryExit1.FlatAppearance.BorderSize = 0;
            this.btnStoryExit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoryExit1.Location = new System.Drawing.Point(414, 0);
            this.btnStoryExit1.Name = "btnStoryExit1";
            this.btnStoryExit1.Size = new System.Drawing.Size(87, 64);
            this.btnStoryExit1.TabIndex = 2;
            this.btnStoryExit1.UseVisualStyleBackColor = false;
            this.btnStoryExit1.Click += new System.EventHandler(this.btnStoryExit1_Click);
            // 
            // FormStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 642);
            this.ControlBox = false;
            this.Controls.Add(this.btnStoryExit);
            this.Controls.Add(this.panel1);
            this.Name = "FormStory";
            this.Load += new System.EventHandler(this.FormStory_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStroy)).EndInit();
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
    }
}