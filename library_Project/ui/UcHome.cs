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
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;
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

        string loginId = string.Empty;

        //배너에 이미지URL 보여주기
        string [] panelimageAdd = new string[] { "https://www.nlcy.go.kr/attach/together/40016/THUM1117851_20211027152006541_1.jpg",
                                                 "https://www.nlcy.go.kr/attach/together/40016/THUM1073373_20200804110649236_1.jpg",
                                                 "https://www.nlcy.go.kr/attach/together/40016/THUM1045534_20190108134416948_1.jpg" };

        #region 생성자
        public UcHome(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            video = new VideoPlay(panelVideo);
            //formMain.myProfile.Visible = false;
            panelManager.Visible = false;

            suggestBook(0);
        }

        public UcHome(BaseAdapter ba, int checkCtype) {

            InitializeComponent();
            this.ba = ba;
            this.checkCtype = checkCtype;
            video = new VideoPlay(panelVideo);

            if (checkCtype == 1) {
                labelHomeBC.Text = "선생님의 추천 책";
                suggestBook(1);
            }
            else if (checkCtype == 5) {
                formMain.myProfile.Visible = false;
                panelManager.Visible = true;
                panelManager.BringToFront();
                suggestBook(0);
            }
            else if (checkCtype == 0) {
                formMain.myProfile.Visible = false;
                panelManager.Visible = false;
                suggestBook(0);
            }
            
        }
        
        public UcHome(BaseAdapter ba, FormMain formMain, int checkCtype) {

            InitializeComponent();
            this.ba = ba;
            this.checkCtype = checkCtype;
            video = new VideoPlay(panelVideo);
            formMain.labelTitle.Text = "어린이 도서관";

            if (checkCtype == 1) {
                labelHomeBC.Text = "선생님의 추천 책";
                suggestBook(1);
            }
            else if (checkCtype == 5) {

                formMain.myProfile.Visible = false;
                panelManager.Visible = true;
                panelManager.BringToFront();
                suggestBook(0);
            }
            else if (checkCtype == 0) {
                formMain.myProfile.Visible = false;
                panelManager.Visible = false;
                suggestBook(0);
            }
        }
#endregion

        public UcHome(BaseAdapter ba,FormMain formMain,int checkCtype, string loginId) {

            InitializeComponent();
            this.ba = ba;
            this.checkCtype = checkCtype;
            this.loginId = loginId;
            FormMain.CHECK_ID = loginId;

            video = new VideoPlay(panelVideo);
            if (checkCtype == 1) {
                labelHomeBC.Text = "선생님의 추천 책";
                panelManager.Visible = false;
                suggestBook(1);
            }
            else if (checkCtype == 5) {

                formMain.myProfile.Visible = false;
                panelManager.Visible = true;
                panelManager.BringToFront();
                suggestBook(0);
            }
            else {
                formMain.myProfile.Visible = false;
                panelManager.Visible = false;
                suggestBook(0);
            }
        }

        private void UcHome_Load(object sender, EventArgs e) {   
            postChange.Start();
        }

        private void suggestBook(int n) {

            int i = 0;

            picBook1.SizeMode = PictureBoxSizeMode.Zoom;
            picBook2.SizeMode = PictureBoxSizeMode.Zoom;

            if (n == 1) {

                List<string> recomm = ba.Ora.tableGetColumn("bnum", "RECOMMENDEDBOOKS", 2, "DBMS_RANDOM.RANDOM");
                picBook1.Image = ba.Ora.tableGetimage("bdimg", "book", recomm[i]);
                i++;
                picBook2.Image = ba.Ora.tableGetimage("bdimg", "book", recomm[i]);

            }
            else {
               
                List<string> recomm =  ba.Ora.tableGetColumn("bnum", "book", "bdcount"); //2
                picBook1.Image = ba.Ora.tableGetimage("bdimg", "book", recomm[i]);
                i++;
                picBook2.Image = ba.Ora.tableGetimage("bdimg", "book", recomm[i]);
                
            }
            
        }

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

        #region  버튼이벤트

        private void btnMap_Click(object sender, EventArgs e) {
            FormMap formMap = new FormMap();
            formMap.ShowDialog(); //modal 방식
        }

        private void button1_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.youtube.com/@user-be3jf5yg9x");
        }

        //관리자 메뉴
        private void btxAddLec_Click(object sender, EventArgs e) {
            FormAddLecture fal = new FormAddLecture(ba);
            fal.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e) {
            FormAddBook fab = new FormAddBook(ba);
            fab.ShowDialog();
        }

        private void btnMemLook_Click(object sender, EventArgs e) {
            FormMdCustomer fmc = new FormMdCustomer(ba);
            fmc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            FormMdBook fmb = new FormMdBook(ba);
            fmb.ShowDialog();
        }

        #endregion
    }
}
