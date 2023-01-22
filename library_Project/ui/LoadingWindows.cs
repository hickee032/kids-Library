using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team1_Project.Properties;

namespace LoadingWindow {

    public partial class LoadingWindows : Form {

        delegate void stringPrameterDelegate(string Text);
        delegate void stringPrameterWithStatusDelegate(string Text, TypeMessage tom);
        delegate void SplashShowCloseDelegate();

        bool CloseSplashScreenFlag = false;



        public LoadingWindows() {

            InitializeComponent();
            
            label1.Text = "도서관 문 여는 중..";
            pbxLoading.BackgroundImage = Resources.Splash01;
        }

        public void ShowSplashScreen() {
            if (InvokeRequired) {
                BeginInvoke(new SplashShowCloseDelegate(ShowSplashScreen));
                return;
            }
            this.Show();
            Application.Run(this);
        }

        public void CloseSplashScreen() {

            if (InvokeRequired) {
                BeginInvoke(new SplashShowCloseDelegate(CloseSplashScreen));
                return;
            }
            CloseSplashScreenFlag = true;
            this.Close();
        }

        public void UpdateLabelText(string Text) {
            if (InvokeRequired) {
                BeginInvoke(new stringPrameterDelegate(UpdateLabelText),new object[] {Text});
                return;
            }
            label1.Text= Text;
        }

        public void UpdatelabelTextStatus(string Text, TypeMessage tm) {
            if (InvokeRequired) {
                BeginInvoke(new stringPrameterWithStatusDelegate(UpdatelabelTextStatus), new object[] { Text ,tm});
                return;
            }
            //오류처리
            switch (tm) {
                case TypeMessage.Success:
                    break;
                case TypeMessage.Warning:
                    label1.ForeColor = Color.Red;
                    break;
                case TypeMessage.Error:
                    label1.ForeColor = Color.Red;
                    break;
            }
            label1.Text = Text;
        }

        public void UpdatePic(Image img) {
            pbxLoading.BackgroundImage = img;
        }

        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (CloseSplashScreenFlag == false) {
                e.Cancel = true;
            }
        }


    }
}
