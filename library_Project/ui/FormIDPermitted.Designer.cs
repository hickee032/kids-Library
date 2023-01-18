namespace Team1_Project.ui {
    partial class FormIDPermitted {
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
            this.labelSignCK = new System.Windows.Forms.Label();
            this.btnConform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSignCK
            // 
            this.labelSignCK.AutoSize = true;
            this.labelSignCK.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSignCK.Location = new System.Drawing.Point(80, 54);
            this.labelSignCK.Name = "labelSignCK";
            this.labelSignCK.Size = new System.Drawing.Size(175, 17);
            this.labelSignCK.TabIndex = 12;
            this.labelSignCK.Text = "사용 가능한 아이디입니다.";
            this.labelSignCK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConform
            // 
            this.btnConform.AutoSize = true;
            this.btnConform.BackColor = System.Drawing.Color.OrangeRed;
            this.btnConform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConform.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConform.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConform.Location = new System.Drawing.Point(112, 117);
            this.btnConform.Name = "btnConform";
            this.btnConform.Padding = new System.Windows.Forms.Padding(40, 11, 40, 11);
            this.btnConform.Size = new System.Drawing.Size(116, 39);
            this.btnConform.TabIndex = 11;
            this.btnConform.Text = "확인";
            this.btnConform.Click += new System.EventHandler(this.btnConform_Click);
            // 
            // FormIDPermitted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.labelSignCK);
            this.Controls.Add(this.btnConform);
            this.Name = "FormIDPermitted";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignCK;
        private System.Windows.Forms.Label btnConform;
    }
}