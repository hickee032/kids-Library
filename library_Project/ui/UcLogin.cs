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

        public static string id = string.Empty;

        public string Id { get => id; set => id = value; }

        BaseAdapter ba;
        FormMain formMain;

        string cmNum = string.Empty;

        

        public UcLogin(FormMain formMain) // 로그인 또는 회원가입
{
            InitializeComponent();
            this.formMain = formMain;
        }

        public UcLogin(BaseAdapter ba, FormMain formMain) // 로그인 또는 회원가입
       {
            InitializeComponent();
            this.ba = ba;
            this.formMain = formMain;
            formMain.Text = "로그인";
        }

        private void SignUp_Click(object sender, EventArgs e) // 회원가입 창으로 이동
        {
            formMain.controllView(new UcAddUser(ba), FormMain.UC_ADDUSER);
        }

        private void LogInID_Leave(object sender, EventArgs e) {
            int flags = 0;

            List<string> cnumList;

            cmNum = tbxID.Text;

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
                tbxID.Focus();
            }
        }


        // 입력된 로그인 정보 (cnum, cpw의 일치확인) 를 통해 해당 회원의 ctype(어린이, 학부모, 선생님)에 따라 다른 창이 뜨게
        //// 1 어린이 2 선생님 3 부모 4 일반 5 관리자
        private void btnUcLogIn_Click(object sender, EventArgs e) {

            if (tbxID.Text == string.Empty) {
                if (tbxPW.Text == string.Empty) {
                    MessageBox.Show("아이디와 비밀번호 입력이 필요합니다.");
                }
                else {
                    MessageBox.Show("아이디 입력이 필요합니다.");
                }
            }
            else {

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
                            formMain.controllView(new UcHome(ba, formMain, 2, tbxID.Text), FormMain.UC_HOMEUSER, tbxID.Text);

                        }
                        else if (cAge.Equals("성인") && cSchool.Equals(string.Empty)) {
                            Console.WriteLine("일반");
                            FormMain.checkCtype = 3;
                            formMain.controllView(new UcHome(ba, formMain, 3, tbxID.Text), FormMain.UC_HOMEUSER, tbxID.Text);

                        }
                        else {
                            Console.WriteLine("어린이");
                            FormMain.checkCtype = 1;
                            formMain.controllView(new UcHome(ba, formMain, 1, tbxID.Text), FormMain.UC_HOMEUSER, tbxID.Text);

                        }

                        formMain.btnLogIn.Text = "로그아웃";
                        formMain.cbxSlider.Checked = true;
                        formMain.cbxSlider.Checked = true;
                        formMain.labelLogName.Visible = true;
                        formMain.myProfile.Visible= true;
                        formMain.labelLogName.Text = $"{cName} 님 환영합니다.";
                        id = tbxID.Text;
                    }
                    else {

                        cName = ba.Ora.tableGetColumn("mname", "manager", "mnum", cmNum);

                        formMain.btnLogIn.Text = "로그아웃";
                        formMain.cbxSlider.Checked = true;
                        formMain.cbxSlider.Checked = true;
                        formMain.labelLogName.Visible = true;
                        formMain.myProfile.Visible = true;
                        formMain.labelLogName.Text = $"관리자 {cName} 님 환영합니다.";
                        formMain.controllView(new UcHome(ba, formMain, 5, tbxID.Text), FormMain.UC_HOMEUSER);
                        id = tbxID.Text;
                    }

                }
                else {
                    MessageBox.Show("틀린 비밀번호 입니다.");
                }
                //Console.WriteLine(checkPW);
            }          
        }

    }
}
