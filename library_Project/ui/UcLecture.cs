using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team1_Project.adapter;
using Team1_Project.model;
using static System.Net.Mime.MediaTypeNames;


namespace Team1_Project.ui {

    partial class UcLecture : UserControl {

        const string UC_LECINFO = "UcLec_Info";

        BaseAdapter ba;

        int btnCount = 0;

        List<Lecture> lectureData;

        public UcLecture (BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            this.Load += UcLecture_Load;
        }

        public UcLecture(BaseAdapter ba,int checkCtype) {

            InitializeComponent();
            this.ba = ba;
            this.lectureData= new List<Lecture>(ba.Ora.lectureShow());
            Console.WriteLine(lectureData[0].LName);
            this.Load += UcLecture_Load;
            Console.WriteLine(lectureData.Count);
            //lectureData = new List<Lecture>(ba.Ora.lectureShow());

            if (checkCtype == 5) {
                btnLecAdd.Visible = true;
            }
            else {               
                btnLecAdd.Visible= true;
            }

            
        }

        private void UcLecture_Load(object sender, EventArgs e) {
            GetImageListView(lectureData,btnCount);
        }

        public void GetImageListView(List<Lecture> lecList,int btnCount) {


            int a,b = 0;
            

            System.Drawing.Image emptyImg = Properties.Resources.pic_empty_lecture;


            //List<string> ImgNameList = ba.Ora.tableGetColumn("lnum", "lecture");
            //List<string> lecLocList = ba.Ora.tableGetColumn("lloc", "lecture");
           // List<string> lecAgeList = ba.Ora.tableGetColumn("ltar", "lecture");
            //List<string> lecLperList = ba.Ora.tableGetColumn("lper", "lecture");
            //List<string> lecLdayList = ba.Ora.tableGetColumn("lday", "lecture");
            //List<string> lecLtimeList = ba.Ora.tableGetColumn("ltime", "lecture");


            List<PictureBox> picBoxList = new List<PictureBox> { this.lecPbx0, this.lecPbx1, this.lecPbx2, this.lecPbx3 };

            List<Label> labelAge = new List<Label> { this.labelAge1, this.labelAge2, this.labelAge3, this.labelAge4 };
            //labelClass
            List<Label> labelClass = new List<Label> {this.labelClass1 ,this.labelClass2, this.labelClass3, this.labelClass4};
            //labelDate
            List<Label> labelDate = new List<Label> { this.labelDate1, this.labelDate2, this.labelDate3, this.labelDate4 };
            //labelDay
            List<Label> labelDay = new List<Label> { this.labelClass1, this.labelClass2, this.labelClass3, this.labelClass4 };
            //labelTime
            List<Label> labelTime = new List<Label> { this.labelClass1, this.labelClass2, this.labelClass3, this.labelClass4 };

            //이미지 리스트에 이미지 Add
            for (int i = 0; i < lectureData.Count; i++) {
                string lnum = lecList[i].LNum.ToString();
                lecImgList.Images.Add(ba.Ora.tableGetimage(lnum, "lectureImg"));
            }

            if (lectureData.Count == 0) {

                picBoxList[0].Image = emptyImg;
                picBoxList[1].Image = emptyImg;
                picBoxList[2].Image = emptyImg;
                picBoxList[3].Image = emptyImg;
                lecSubPnl1.Visible = false;
                lecSubPnl2.Visible = false;
                lecSubPnl3.Visible = false;
                lecSubPnl4.Visible = false;
            }
            else {

                a = lectureData.Count / picBoxList.Count;
                b = lectureData.Count % picBoxList.Count; //1

                Console.WriteLine("a : " + a);
                Console.WriteLine("b : " + b);

                if (a == 0) {
                    lecBackBtn.Visible= false;
                    lecNextBtn.Visible= false;
                    pbxAddImgList(lectureData, lecImgList, picBoxList, labelAge, labelClass, labelDate, labelDay, labelTime, btnCount);
                }
                else if (a < (lectureData.Count-1) && a != 0) {
                    lecBackBtn.Visible= true;
                    lecNextBtn.Visible = false;
                    pbxAddImgList(lectureData, lecImgList, picBoxList, labelAge, labelClass, labelDate, labelDay, labelTime, btnCount);
                }
                else {
                    lecBackBtn.Visible = true;
                    lecNextBtn.Visible = true;
                    pbxAddImgList(lectureData, lecImgList, picBoxList, labelAge, labelClass, labelDate, labelDay, labelTime, btnCount);
                }
            }
           this.Refresh();   
        }

        public void pbxAddImgList(List<Lecture> LectureList, ImageList imgList, List<PictureBox> pbx,
            List<Label> lage,List<Label> lclass,List<Label> ldate, List<Label> days, List<Label> times,
            int btnCount) {

            int count = 0;
            int index = count + btnCount;
            int a = LectureList.Count / pbx.Count; 
            int b = LectureList.Count % pbx.Count; // 1이 남을경우 

            if (a >= 0) {
                if (b == 0) {
  

                    for (count = 0; count < pbx.Count; count++) {
                        if (count >= b) {
                            pbx[count + btnCount].Image = Properties.Resources.pic_empty_lecture;
                            lage[count + btnCount].Text = null;
                            lclass[count + btnCount].Text = null;
                            ldate[count + btnCount].Text = null;
                            days[count + btnCount].Text = null;
                            times[count + btnCount].Text = null;

                        }
                        else {
                            pbx[count + btnCount].Image = imgList.Images[count + btnCount];
                            lage[count + btnCount].Text = LectureList[count + btnCount].LTar;
                            lclass[count + btnCount].Text = LectureList[count + btnCount].LLoc;
                            ldate[count + btnCount].Text = LectureList[count + btnCount].LPer;
                            days[count + btnCount].Text = LectureList[count + btnCount].LDay;
                            times[count + btnCount].Text = LectureList[count + btnCount].LTime;
                        }

                    }

                }
                else {

                    for (count = 0; count < pbx.Count; count++) {
                        if (count >= b) {
                            pbx[count + btnCount].Image = Properties.Resources.pic_empty_lecture;
                            lage[count + btnCount].Text = null;
                            lclass[count + btnCount].Text = null;
                            ldate[count + btnCount].Text = null;
                            days[count + btnCount].Text = null;
                            times[count + btnCount].Text = null;
                        }
                        else {
                            pbx[count + btnCount].Image = imgList.Images[count + btnCount];
                            pbx[count + btnCount].Image = imgList.Images[count + btnCount];
                            lage[count + btnCount].Text = LectureList[count + btnCount].LTar;
                            lclass[count + btnCount].Text = LectureList[count + btnCount].LLoc;
                            ldate[count + btnCount].Text = LectureList[count + btnCount].LPer;
                            days[count + btnCount].Text = LectureList[count + btnCount].LDay;
                            times[count + btnCount].Text = LectureList[count + btnCount].LTime;

                        }
                        
                    }
                }
            }
            else {
                pbx[count + btnCount].Image = Properties.Resources.pic_empty_lecture;
            }

        }

        //강좌 등록
        private void btnLecAdd_Click(object sender, EventArgs e) {
            FormAddLecture fal = new FormAddLecture(ba);
            fal.ShowDialog();
        }

        private void lecBackBtn_Click(object sender, EventArgs e) {
            btnCount -= 4;
            GetImageListView(lectureData,btnCount);
        }

        private void lecNextBtn_Click(object sender, EventArgs e) {
            btnCount += 4;
            GetImageListView(lectureData,btnCount);
        }
    }
}
