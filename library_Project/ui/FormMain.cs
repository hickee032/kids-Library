using LoadingWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team1_Project.adapter;
using Team1_Project.ui;

namespace Team1_Project {
    
    public partial class FormMain : MetroFramework.Forms.MetroForm {

        public static int checkCtype = 0;
        public static string CHECK_ID = string.Empty;

        #region 슬라이더

        //슬라이더 변수
        const int MAX_SLIDING_WIDTH = 264;
        const int MIN_SLIDING_WIDTH = 64;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 68;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 264;

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
                btnSearch.BackgroundImage = null;
                btnReBook.Text = "책 반납";
                btnReBook.BackgroundImage = null;
                btnLesson.Text = "교실";
                btnLesson.BackgroundImage = null;

                //btnMedia.Text = "영상관";
                //btnMedia.BackgroundImage = null;
                btnExit.Text = "종료";
                btnExit.BackgroundImage = null;


            }
            else {
                //슬라이딩 메뉴가 접혔을 때, 메뉴 버튼의 표시

                cbxSlider.BackgroundImage = Properties.Resources.icon_forward;

                btnHome.Text = string.Empty;
                btnHome.BackgroundImage = Properties.Resources.icon_home;
                btnSearch.Text = string.Empty;
                btnSearch.BackgroundImage = Properties.Resources.icon_searchBook;
                btnReBook.Text = string.Empty;
                btnReBook.BackgroundImage = Properties.Resources.icon_returnBook;
                btnLesson.Text = string.Empty;
                btnLesson.BackgroundImage = Properties.Resources.icon_lesson;
               
                btnExit.Text = string.Empty;
                btnExit.BackgroundImage = Properties.Resources.icon_stop;


                // button1.Size = new System.Drawing.Size(MIN_SLIDING_WIDTH, 54);

            }

            //타이머 시작
            timerSliding.Start();
        }


        #endregion

        //유저 컨트롤 변수
        public const string UC_HOMEUSER = "UcHome";
        public const string UC_LECTURE = "UcLecture";
        public const string UC_LOGIN = "UcLogIn";
        public const string UC_ADDUSER = "UcAddUser";

        const string UC_BOOKSEARCH = "UcSearchBook";
        const string UC_BOOKRETURN = "UcBookReturn";

        const string UC_MEMVERVIEW = "UcMemberView";

        BaseAdapter ba = new BaseAdapter();

        internal BaseAdapter Ba { get => ba; set => ba = value; }

        public FormMain() {

            InitializeComponent();  
            controllView(new UcHome(ba), UC_HOMEUSER);
            labelTitle.Text = "어린이 도서관";
            myProfile.Visible= false;

            #region 스플래쉬 화면 시작
            int sleepTime = 1600;
            Thread splashthread = new Thread(new ThreadStart(LoadingScreen.ShowSplashScreen));

            splashthread.IsBackground = true;
            splashthread.Start();

            Thread.Sleep(sleepTime);
            LoadingScreen.CloseSplashScreen();
            #endregion
        }

        //슬라이더 버튼 이벤트
        private void btnHome_Click(object sender, EventArgs e) {
            //this.ResetText();
            labelTitle.Text = "시작화면 입니다";
            controllView(new UcHome(ba ,this, checkCtype), UC_HOMEUSER);
        }

        private void btnSearch_Click(object sender, EventArgs e) {

            controllView(new UcBookSearch(ba, CHECK_ID, checkCtype), UC_BOOKSEARCH);

            labelTitle.Text = "책을 찾습니다";
        }

        private void btnLesson_Click(object sender, EventArgs e) {
            //this.ResetText();
            labelTitle.Text = "공부를 합니다";
            controllView(new UcLecture(ba, checkCtype), UC_LECTURE);
        }

        private void btnReBook_Click(object sender, EventArgs e) {

            labelTitle.Text = "책을 반납합니다";

            if (CHECK_ID.Equals(string.Empty)) {

                MessageBox.Show("로그인이 필요합니다. 로그인 창으로 이동합니다.");

                controllView(new UcLogin(ba, this), UC_HOMEUSER);
            }
            else {
                controllView(new UcBookReturn(ba, CHECK_ID), UC_BOOKRETURN);
            }


        }

        private void btnLogIn_Click(object sender, EventArgs e) {

            labelTitle.Text = "로그인 합니다";

            if (btnLogIn.Text.Equals("로그인")) {

                controllView(new UcLogin(ba,this,0), UC_HOMEUSER);

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

        public void controllView(UserControl uc, string viewName, string id) {
            CHECK_ID = id;

            panelCenter.Controls.Clear();

            if (!panelCenter.Controls.ContainsKey(viewName)) {
                uc.Dock = DockStyle.Fill;
                panelCenter.Controls.Add(uc);
            }
        }

        #region 버튼 이벤트

        private void picLibStory_Click(object sender, EventArgs e) {
            FormStory fs = new FormStory();
            fs.ShowDialog();
        }

        private void myProfile_Click(object sender, EventArgs e) {
            FormEditPfil fep = new FormEditPfil(ba, CHECK_ID);
            fep.ShowDialog();
        }

        #endregion

        public static string UC_HOMEUSER1 => UC_HOMEUSER;

        public static string UC_LECTURE1 => UC_LECTURE;

        public static string UC_LOGIN1 => UC_LOGIN;

        public static string UC_ADDUSER1 => UC_ADDUSER;

        public static string UC_BOOKSEARCH1 => UC_BOOKSEARCH;

        public static string UC_BOOKRETURN1 => UC_BOOKRETURN;


    }
}
