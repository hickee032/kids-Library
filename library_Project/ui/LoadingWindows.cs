using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingWindow {

    public partial class LoadingWindows : Form {

        delegate void stringPrameterDelegate(string Text);
        delegate void stringPrameterWithStatusDelegate(string Text, TypeOfMessage tom);
        delegate void SplashShowCloseDelegate();

        bool CloseSplashScreenFlag = false;

        public LoadingWindows() {
            InitializeComponent();
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
        
        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (CloseSplashScreenFlag == false) {
                e.Cancel = true;
            }
        }
    }
}
