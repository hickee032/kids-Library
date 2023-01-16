using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Team1_Project.adapter;
using Team1_Project.dao;
using Team1_Project.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Team1_Project.ui {
    partial class FormAddLecture : MetroFramework.Forms.MetroForm {

        BaseAdapter ba;
        UserControl uc;

        public FormAddLecture(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            dateTimePickerSetting();

            //콤보 박스에 데이터 넣기
            lTechCbxAdd("mname", "manager");

            lNumLabel.Text = LectNum(ba.Ora.tableCount("lecture"));

            ba.Ora.tableCount("lecture");
        }

        public FormAddLecture(BaseAdapter ba, UserControl uc) {
            InitializeComponent();
            this.ba = ba;
            this.uc = uc;
            dateTimePickerSetting();

            //콤보 박스에 데이터 넣기
            lTechCbxAdd("mname", "manager");

            lNumLabel.Text = LectNum(ba.Ora.tableCount("lecture"));

            ba.Ora.tableCount("lecture");
        }

        #region dateTimePicker 설정
        public void dateTimePickerSetting() {

            PickerStartDay.Format = DateTimePickerFormat.Custom;
            PickerStartDay.CustomFormat = "yy-MM-dd";

            PickerEndDay.Format = DateTimePickerFormat.Custom;
            PickerEndDay.CustomFormat = "yy-MM-dd";

            PickerStartTime.Format = DateTimePickerFormat.Custom;
            PickerStartTime.ShowUpDown = true;
            PickerStartTime.CustomFormat = "HH:mm";

            PickerEndTime.Format = DateTimePickerFormat.Custom;
            PickerEndTime.ShowUpDown = true;
            PickerEndTime.CustomFormat = "HH:mm";
        }
        #endregion

        
        private void lTechCbxAdd(string colmn,string table) {

            lTechCbx.Items.AddRange(ba.Ora.tableGetColumn(colmn, table).ToArray());
        }

        //번호 자동부여
        public string LectNum(int n) {

            string lNum = "L" + (n).ToString("000.");
            Console.WriteLine(lNum);

            return lNum;
        }
        //버튼 이벤트 
        private void btnLectAdd_Click(object sender, EventArgs e) {

            DaoOra ora = ba.Ora;

            string num = lNumLabel.Text;
            string title = lNameTbx.Text;

            string loc = lLocCbx.SelectedItem.ToString();
            string age = lAgeCbx.SelectedItem.ToString();
            string per = PickerStartDay.Value.ToString("d") + "/" + PickerEndDay.Value.ToString("d");
            string week = weekCbx.SelectedItem.ToString();
            string time = PickerStartTime.Value.ToString("HH:mm") + "~" + PickerEndTime.Value.ToString("HH:mm");

            string teacher = ba.Ora.tableGetColumn("mnum", "manager", "mname", lTechCbx.SelectedItem.ToString());

            Console.WriteLine(num);
            Console.WriteLine(title);
            Console.WriteLine(loc);
            Console.WriteLine(age);
            Console.WriteLine(per);
            Console.WriteLine(week);
            Console.WriteLine(time);
            Console.WriteLine(teacher);

            ba.Ora.lectureImgImg(lNumLabel.Text, openFileImg.FileName);
            try {
                ba.Ora.insertData(new Lecture(num, title, loc, age, per, time, week, teacher));

                this.Close();
                uc.Refresh();
            }
            catch (Exception) {

                MessageBox.Show("빈칸이 있습니다.");
            }
        }

        private void btnLectCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        //강좌 이미지 버튼
        private void btnLecImgAdd_Click(object sender, EventArgs e) {
            try {
                DaoOra ora = ba.Ora;
                openFileImg.InitialDirectory = @"C:\";
                openFileImg.Filter = "jpeg 파일(*.jpg)|*.jpg|" +
                    "png 파일(*.png)|*.png|" +
                    "gif 파일(*.gif)|*.gif|" +
                    "모든 파일(*.*)|*.*";
                openFileImg.FilterIndex = 0;
                openFileImg.RestoreDirectory = true;
                openFileImg.ShowDialog();
                string imgPath = openFileImg.FileName;

                Image img = Image.FromFile(imgPath);
                piclecPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                piclecPoster.Image = img;
            }
            catch (Exception) {

                piclecPoster.Image = Properties.Resources.pic_empty_lecture;
            }


        }

        private void btnLecImgDel_Click(object sender, EventArgs e) {
            piclecPoster.Image = null;
            piclecPoster.Image = Properties.Resources.pic_needPoster;
        }
    }
}
