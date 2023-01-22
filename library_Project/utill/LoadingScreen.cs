using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingWindow {

    public enum TypeMessage {
        Success,
        Warning,
        Error,
    }

    public static class LoadingScreen {
        
        static LoadingWindows sf = null;
        
        //lOADING SCREEN 없다면 띄우기
        public static void ShowSplashScreen() {
            if (sf==null) {
                sf = new LoadingWindows();
                sf.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                sf.ShowSplashScreen();
            }
        }

        //lOADING SCREEN 있다면 지우기
        public static void CloseSplashScreen() {
            if (sf!=null) {
                sf.CloseSplashScreen();
                sf = null;
            }
        }
        public static void UpdateText(string text) {
            if (sf!=null) {
                sf.UpdateLabelText(text);
            }
        }
        public static void UpdateTextStatus(string Text, TypeMessage tm) {
            if (sf != null) {
                sf.UpdatelabelTextStatus(Text, tm);
            }
        }
        public static void UpdatePic(Image img) {
            if (sf != null) {
                sf.UpdatePic(img);
            }
        }
    }
}
