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

        //슬라이더 변수
        const int MAX_SLIDING_WIDTH = 264;
        const int MIN_SLIDING_WIDTH = 64;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 68;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 264;

        //유저 컨트롤 변수
        const string UC_HOMEUSER = "UcHome";
        const string UC_LECTURE = "UcLecture";
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
            controllView(new UcHome(), UC_HOMEUSER);
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
                cbxSlider.BackgroundImage = Properties.Resources.arrow_left;

                btnHome.Text = "메인";
                btnHome.BackgroundImage = null;
                btnLogin.Text = "로그인";
                btnLogin.BackgroundImage = null;
                btnSearch.Text = "책 검색";
                btnSearch.BackgroundImage= null;
                btnReBook.Text = "책 반납";
                btnReBook.BackgroundImage = null;
                btnLesson.Text = "교실";
                btnLesson.BackgroundImage= null;
                btnModify.Text = "정보수정";
                btnModify.BackgroundImage= null;
                btnMedia.Text = "영상관";
                btnMedia.BackgroundImage= null;
                btnExit.Text = "종료";
                btnExit.BackgroundImage= null;

                
            }
            else {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시
                cbxSlider.BackgroundImage = Properties.Resources.arrow_right;

                btnHome.BackgroundImage = Properties.Resources.icon_home;
                btnHome.Text = string.Empty;
                btnLogin.BackgroundImage= Properties.Resources.icon_login;
                btnLogin.Text = string.Empty;
                btnSearch.Text = string.Empty;
                btnSearch.BackgroundImage = Properties.Resources.icon_search;
                btnReBook.Text= string.Empty;
                btnReBook.BackgroundImage = Properties.Resources.icon_rebook;
                btnModify.Text= string.Empty;
                btnModify.BackgroundImage = Properties.Resources.icon_modify;
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

        //패널에 유저 컨트롤 세팅
        private void controllView(UserControl uc, string viewName) {

            panelCenter.Controls.Clear();

            if (!panelCenter.Controls.ContainsKey(viewName)) {
                uc.Dock = DockStyle.Fill;
                panelCenter.Controls.Add(uc);
            }
        }

        //슬라이더 버튼 이벤트
        private void btnHome_Click(object sender, EventArgs e) {

        }

        private void button7_Click(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void btnLesson_Click(object sender, EventArgs e) {
            controllView(new UcLecture(ba), UC_LECTURE);
        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void btnMainExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
