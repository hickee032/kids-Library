using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team1_Project.adapter;
using Team1_Project.ui;

namespace Team1_Project {
    
    public partial class FormMain : MetroFramework.Forms.MetroForm {
        public static int checkCtype = 0;

        //슬라이더 변수
        const int MAX_SLIDING_WIDTH = 264;
        const int MIN_SLIDING_WIDTH = 64;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 68;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 264;

        //유저 컨트롤 변수
        public const string UC_HOMEUSER = "UcHome";
        const string UC_LECTURE = "UcLecture";
        public const string UC_LOGIN = "UcLogIn";
        public const string UC_ADDUSER = "UcAddUser";
        /*
        const string UC_SIGNUSER = "UCSign";
        const string UC_GRADEUSER = "UCGrade";
        const string UC_VIEWUSER = "UCView";
        const string UC_MAILUSER = "UCMail";
        const string UC_SETTINGUSER = "UCSetting";
        const string UC_ADMINUSER = "UCAdmin";
        const string UC_HELPUSER = "UCHelp";
        */

        BaseAdapter ba = new BaseAdapter();

        public FormMain() {
            InitializeComponent();
            controllView(new UcHome(ba), UC_HOMEUSER);
        }

        //슬라이더 동작
        private void timerSliding_Tick(object sender, EventArgs e) {
            if (cbxSlider.Checked == true) {
                //슬라이딩 메뉴를 보이는 동작
                _posSliding -= STEP_SLIDING;

                if (_posSliding <= MIN_SLIDING_WIDTH)
                    //button1.Size = new System.Drawing.Size(MIN_SLIDING_WIDTH, 54);

                timerSliding.Stop();
               // button1.BackgroundImage = Properties.Resources.bImage_home;
            }
            else {
                
                //슬라이딩 메뉴를 숨기는 동작
                _posSliding += STEP_SLIDING;

                if (_posSliding >= MAX_SLIDING_WIDTH)
                    timerSliding.Stop();
            }

            panelSideMenu.Width = _posSliding;
            Console.WriteLine(panelSideMenu.Width);
        }

        //슬라이더 타이머
        private void checkBoxHide_CheckedChanged(object sender, EventArgs e) {
            if (cbxSlider.Checked == false) {
                //슬라이딩 메뉴가 보였을 때, 메뉴 버튼의 표시
                cbxSlider.BackgroundImage = Properties.Resources.icon_backward;

                btnHome.Text = "메인";
                btnHome.BackgroundImage = null;

                btnSearch.Text = "책 검색";
                btnSearch.BackgroundImage= null;
                btnReBook.Text = "책 반납";
                btnReBook.BackgroundImage = null;
                btnLesson.Text = "교실";
                btnLesson.BackgroundImage= null;

                btnMedia.Text = "영상관";
                btnMedia.BackgroundImage= null;
                btnExit.Text = "종료";
                btnExit.BackgroundImage= null;

                
            }
            else {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
                
                cbxSlider.BackgroundImage = Properties.Resources.icon_forward;

                btnHome.BackgroundImage = Properties.Resources.icon_home;
                btnHome.Text = string.Empty;

                btnSearch.Text = string.Empty;
                btnSearch.BackgroundImage = Properties.Resources.icon_searchBook;
                btnReBook.Text= string.Empty;
                btnReBook.BackgroundImage = Properties.Resources.icon_returnBook;
               
                btnLesson.Text = string.Empty;
                btnLesson.BackgroundImage = Properties.Resources.icon_lesson;
                btnMedia.Text = string.Empty;
                btnMedia.BackgroundImage = Properties.Resources.icon_media;
                btnExit.Text = string.Empty;
                btnExit.BackgroundImage = Properties.Resources.icon_bye;


                // button1.Size = new System.Drawing.Size(MIN_SLIDING_WIDTH, 54);

            }

            //타이머 시작
            timerSliding.Start();
        }



        //슬라이더 버튼 이벤트
        private void btnHome_Click(object sender, EventArgs e) {
            //this.ResetText();
            this.Text = "홈";
            controllView(new UcHome(ba, checkCtype), UC_HOMEUSER);
        }

        private void btnLesson_Click(object sender, EventArgs e) {
            //this.ResetText();
            this.Text = "강좌";
            controllView(new UcLecture(ba, checkCtype), UC_LECTURE);
        }





        private void btnLogIn_Click(object sender, EventArgs e) {
            this.ResetText();
            this.Text = "로그인";

            if (btnLogIn.Text.Equals("로그인")) {

                controllView(new UcLogin(ba, this), UC_HOMEUSER);
            }

            if (btnLogIn.Text.Equals("로그아웃")) {
                
                controllView(new UcHome(ba,this,0), UC_HOMEUSER);
                labelLogName.Text = string.Empty;
                labelLogName.Visible= false;
                btnLogIn.Text = "로그인";
            }
            
        }

        private void btnMainExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //패널에 유저 컨트롤 세팅
        public void controllView(UserControl uc, string viewName) {

            panelCenter.Controls.Clear();

            if (!panelCenter.Controls.ContainsKey(viewName)) {
                uc.Dock = DockStyle.Fill;
                panelCenter.Controls.Add(uc);
            }
        }
    }
}
