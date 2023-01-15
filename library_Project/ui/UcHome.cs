using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team1_Project.adapter;
using Team1_Project.utill;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Team1_Project.ui {
    partial class UcHome : UserControl {

        int checkCtype = 0;

        // 1 어린이 2 선생님 3 일반
        FormMain formMain;

        VideoPlay video;
        BaseAdapter ba;
        //이미지 플래그 변수 
        int changeCount = 0;
        int loop = 0;

        string loginId = string.Empty;


        //배너에 이미지URL 보여주기
        string [] panelimageAdd = new string[] { "https://www.nlcy.go.kr/attach/together/40016/THUM1117851_20211027152006541_1.jpg",
                                                 "https://www.nlcy.go.kr/attach/together/40016/THUM1073373_20200804110649236_1.jpg",
                                                 "https://www.nlcy.go.kr/attach/together/40016/THUM1045534_20190108134416948_1.jpg" };



        public UcHome(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            video = new VideoPlay(panelVideo);
            //formMain.myProfile.Visible = false;
            suggestBook(0);
        }

        public UcHome(BaseAdapter ba, int checkCtype) {
            InitializeComponent();
            this.ba = ba;
            this.checkCtype = checkCtype;
            video = new VideoPlay(panelVideo);

            if (checkCtype == 1) {
                labelHomeBC.Text = "선생님의 추천 책";
            }
            else if (checkCtype == 5) {

            }
            else if (checkCtype == 0) {
               
            }
            suggestBook(0);
        }

        public UcHome(BaseAdapter ba, FormMain formMain, int checkCtype) {
            InitializeComponent();
            this.ba = ba;
            this.checkCtype = checkCtype;
            video = new VideoPlay(panelVideo);

            if (checkCtype == 1) {
                labelHomeBC.Text = "선생님의 추천 책";
            }
            else if (checkCtype == 5) {

            }
            else if (checkCtype == 0) {
                formMain.myProfile.Visible = false;
            }
            suggestBook(0);
        }

        public UcHome(BaseAdapter ba,FormMain formMain,int checkCtype, string loginId) {
            InitializeComponent();
            this.ba = ba;
            this.checkCtype = checkCtype;
            this.loginId = loginId;
            
            video = new VideoPlay(panelVideo);
            if (checkCtype == 1) {
                labelHomeBC.Text = "선생님의 추천 책";
            }
            else if (checkCtype == 5) {

                
            }
            suggestBook(0);
        }

        private void UcHome_Load(object sender, EventArgs e) {
            
            postChange.Start();

        }

        //추천 책 추후 선생님의 추천 으로 바꿀수 있도록 설정
        private void suggestBook(int n) {

            if (n == 2) {
                //선생님
                
            }
            else {


            }
            
        }

        //이미지를 바꾸는 타이머
        private void postChange_Tick(object sender, EventArgs e) {

            postChange.Interval = 2000;

            
            if (changeCount == 0) {
                pbHomeBan1.ImageLocation = panelimageAdd[0];
                pbHomeBan1.Load(panelimageAdd[0]);
                changeCount++;
            }
            else if (changeCount == 1) {            
                pbHomeBan1.ImageLocation = panelimageAdd[1];
                pbHomeBan1.Load(panelimageAdd[1]);
                changeCount++;
            }
            else {
                pbHomeBan1.ImageLocation = panelimageAdd[2];
                pbHomeBan1.Load(panelimageAdd[2]);
                changeCount = 0;
            }            
        }

        private void btnMap_Click(object sender, EventArgs e) {
            FormMap formMap = new FormMap();
            formMap.ShowDialog(); //modal 방식
        }

        private void button1_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.youtube.com/@user-be3jf5yg9x");
        }



        private void pbHomeBan1_Click(object sender, EventArgs e) {
            //formMain.controllView(new UcLecture(ba, checkCtype), formMain.);
        }
    }
}
