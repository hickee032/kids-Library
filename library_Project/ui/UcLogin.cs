using DirectShowLib;
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

namespace Team1_Project.ui {

    partial class UcLogin : UserControl {

        int checkCtype = 0;


        BaseAdapter ba;
        FormMain formMain;

        string cmNum = string.Empty;

        public UcLogin() {
            InitializeComponent();
        }

        public UcLogin(BaseAdapter ba, FormMain formMain) // 로그인 또는 회원가입
       {
            InitializeComponent();
            this.ba = ba;
            this.formMain = formMain;
        }

        private void SignUp_Click(object sender, EventArgs e) // 회원가입 창으로 이동
        {
            formMain.controllView(new UcAddUser(), FormMain.UC_ADDUSER);
        }

        private void LogInID_Leave(object sender, EventArgs e) {
            int flags = 0;

            List<string> cnumList;

            cmNum = LogInID.Text;

            //일반회원인지 관리자 인지 체크
            string checkCM =cmNum.Substring(0,1);

            Console.WriteLine("첫번째 글자 확인 :" + checkCM);

            if (checkCM.Equals("m")|| checkCM.Equals("M")) {
                cnumList = ba.Ora.tableGetColumn("mnum", "manager");
                FormMain.checkCtype = 5;

                Console.WriteLine(FormMain.checkCtype);
            }
            else {
                cnumList = ba.Ora.tableGetColumn("cnum", "customer");
            }
            
            foreach (var item in cnumList) {
                if (cmNum.ToString().Equals(item)) {
                    flags= 1;
                }
            }
            if (flags == 0) {
                MessageBox.Show("존재하지 않는 아이디 입니다.");
                LogInID.Focus();
            }
        }


        // 입력된 로그인 정보 (cnum, cpw의 일치확인) 를 통해 해당 회원의 ctype(어린이, 학부모, 선생님)에 따라 다른 창이 뜨게
        //// 1 어린이 2 선생님 3 부모 4 일반 5 관리자
        private void btnUcLogIn_Click(object sender, EventArgs e) {

            string checkPW;
            string cName;

            if (FormMain.checkCtype == 5) {

                checkPW = ba.Ora.tableGetColumn("mpw", "manager", "mnum", cmNum);
            }
            else {
                checkPW = ba.Ora.tableGetColumn("cpw", "customer", "cnum", cmNum);
            }

            if (tbxPW.Text.Equals(checkPW)) {

                if (FormMain.checkCtype != 5) {
                    string cAge = ba.Ora.tableGetColumn("ctype", "customer", "cnum", cmNum);
                    string cSchool = ba.Ora.tableGetColumn("cschool", "customer", "cnum", cmNum);
                    cName = ba.Ora.tableGetColumn("cname", "customer", "cnum", cmNum);

                    if (cAge.Equals("성인") && !cSchool.Equals(string.Empty)) {

                        Console.WriteLine("선생님");
                        FormMain.checkCtype = 2;
                        formMain.controllView(new UcHome(ba, formMain, 2), FormMain.UC_HOMEUSER);

                    }
                    else if (cAge.Equals("성인") && cSchool.Equals(string.Empty)) {
                        Console.WriteLine("일반");
                        FormMain.checkCtype = 3;
                        formMain.controllView(new UcHome(ba, formMain, 3), FormMain.UC_HOMEUSER);

                    }
                    else {
                        Console.WriteLine("어린이");
                        FormMain.checkCtype = 1;
                        formMain.controllView(new UcHome(ba, formMain, 1), FormMain.UC_HOMEUSER);

                    }

                    formMain.btnLogIn.Text = "로그아웃";
                    formMain.cbxSlider.Checked = true;
                    formMain.cbxSlider.Checked = true;
                    formMain.labelLogName.Visible = true;
                    formMain.labelLogName.Text = $"{cName} 님 환영합니다.";
                }
                else {

                    cName = ba.Ora.tableGetColumn("mname", "manager", "mnum", cmNum);

                    formMain.btnLogIn.Text = "로그아웃";
                    formMain.cbxSlider.Checked = true;
                    formMain.cbxSlider.Checked = true;
                    formMain.labelLogName.Visible = true;
                    formMain.labelLogName.Text = $"{cName} 님 환영합니다.";
                }

            }
            else {
                MessageBox.Show("틀린 비밀번호 입니다.");
            }
            Console.WriteLine(checkPW);
        }

        private void ctelCheck_Click(object sender, EventArgs e) // 연락처 검색으로 회원번호 조회
        {

        }

        private void cnumCheck_Click(object sender, EventArgs e) // 연락처 검색으로 회원번호 유무 조회
        {

        }
    }
}
