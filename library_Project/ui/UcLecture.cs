using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team1_Project.adapter;
using Team1_Project.model;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;
using static System.Net.Mime.MediaTypeNames;


namespace Team1_Project.ui {

    partial class UcLecture : UserControl {

        const string UC_LECINFO = "UcLec_Info";

        BaseAdapter ba;

        int btnCount = 0;

        List<Lecture> lectureData;

        #region 생성자

        public UcLecture (BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            this.Load += UcLecture_Load;

        }

        public UcLecture(BaseAdapter ba,int checkCtype) {

            InitializeComponent();
            this.ba = ba;
            this.lectureData= new List<Lecture>(ba.Ora.lectureShow());

          
                                                   // Console.WriteLine(lectureData[0].LName);
            this.Load += UcLecture_Load;

            // Console.WriteLine(lectureData.Count);
            //lectureData = new List<Lecture>(ba.Ora.lectureShow());

            if (checkCtype == 5) {
                btnLecAdd.Visible = true;
            }
            else {               
                btnLecAdd.Visible= true;
            }

            
        }

        #endregion

        #region 로더
        private void UcLecture_Load(object sender, EventArgs e) {
            GetImageListView(lectureData,btnCount);
        }
        #endregion

        #region 버튼이벤트 

        private void btnLecAdd_Click(object sender, EventArgs e) {
            FormAddLecture fal = new FormAddLecture(ba);
            fal.ShowDialog();
        }

        private void lecBackBtn_Click(object sender, EventArgs e) {

            Console.WriteLine("btnCount :" + btnCount);

            try {
                btnCount -= 4;
                Console.WriteLine("btnCount :" + btnCount);
                GetImageListView(lectureData, btnCount);
            }
            catch (Exception) {

                MessageBox.Show("처음입니다.");
            }

        }

        private void lecNextBtn_Click(object sender, EventArgs e) {

            Console.WriteLine("btnCount :" + btnCount);

            try {
                btnCount += 4;
                Console.WriteLine("btnCount :" + btnCount);
                GetImageListView(lectureData, btnCount);
            }
            catch (Exception) {

                MessageBox.Show("마지막입니다.");
            }
        }
        #endregion

        public void GetImageListView(List<Lecture> lecList,int btnCount) {

            int a,b = 0;

            
            //픽쳐박스
            List<PictureBox> picBoxList = new List<PictureBox> { this.lecPbx0, this.lecPbx1, this.lecPbx2, this.lecPbx3 };
            //라벨
            List<Label> labelAge = new List<Label> { this.labelAge1, this.labelAge2, this.labelAge3, this.labelAge4 };
            List<Label> labelClass = new List<Label> { this.labelClass1, this.labelClass2, this.labelClass3, this.labelClass4 };
            List<Label> labelDate = new List<Label> { this.labelDate1, this.labelDate2, this.labelDate3, this.labelDate4 };
            List<Label> labelDay = new List<Label> { this.labelDay1, this.labelDay2, this.labelDay3, this.labelDay4 };
            List<Label> labelTime = new List<Label> { this.labelTime1, this.labelTime2, this.labelTime3, this.labelTime4 };

            //이미지 리스트에 이미지 Add 
            for (int i = 0; i < lectureData.Count; i++) {
                string lnum = lecList[i].LNum.ToString();
                lecImgList.Images.Add(ba.Ora.tableGetimage(lnum, "lectureImg"));
            }
            //DB에 이미지가 없을경우
            if (lectureData.Count == 0) {

                picBoxList[0].Image = Properties.Resources.pic_empty_lecture; ;
                picBoxList[1].Image = Properties.Resources.pic_empty_lecture; ;
                picBoxList[2].Image = Properties.Resources.pic_empty_lecture; ;
                picBoxList[3].Image = Properties.Resources.pic_empty_lecture; ;
                lecSubPnl1.Visible = false;
                lecSubPnl2.Visible = false;
                lecSubPnl3.Visible = false;
                lecSubPnl4.Visible = false;
            }
            //이미지가 있을 경우  4개로 떨어질 경우 1개가 남을경우
            else {
                    pbxAddImgList(lectureData, lecImgList, picBoxList, labelAge, labelClass, labelDate, labelDay, labelTime, btnCount);
            }
           this.Refresh();   
        }

        public void pbxAddImgList(List<Lecture> LectureList, ImageList imgList, List<PictureBox> pbx,
            List<Label> lage, List<Label> lclass, List<Label> ldate, List<Label> ldays, List<Label> ltimes,
            int btnCount) {

            int n = LectureList.Count / pbx.Count;
            int m = LectureList.Count % pbx.Count;

            Console.WriteLine("LectureList.Count / pbx.Count : " + n); //0
            Console.WriteLine("LectureList.Count % pbx.Count : " + m); //2
            Console.WriteLine("imgList.Images.Count : " + imgList.Images.Count); //2
            Console.WriteLine("btnCount" + btnCount);

            if (btnCount != 0) {
                Console.WriteLine("btnCount :" + btnCount);
                if (n != 0) {

                    Console.WriteLine("n :" + n);
                    Console.WriteLine("m : " + m);

                    for (int i = 0; i < pbx.Count; i++) {

                        if (i < m) {
                            Console.WriteLine("if");

                            pbx[i].Image = imgList.Images[i + btnCount];
                            lage[i].Text = LectureList[i + btnCount].LTar;
                            lclass[i].Text = LectureList[i + btnCount].LLoc;
                            ldate[i].Text = LectureList[i + btnCount].LPer;
                            ldays[i].Text = LectureList[i + btnCount].LDay;
                            ltimes[i].Text = LectureList[i + btnCount].LTime;
                            


                        }
                        else {
                            Console.WriteLine("else");
                            pbx[i].Image = Properties.Resources.pic_empty_lecture;
                            lage[i].Text = null;
                            lclass[i].Text = null;
                            ldate[i].Text = null;
                            ldays[i].Text = null;
                            ltimes[i].Text = null;
                        }
                    }
                    n -= 1;
                }
                else {
                    for (int i = 0; i < pbx.Count; i++) {

                        if (i < m) {
                            Console.WriteLine("else/if");
                            pbx[i].Image = Properties.Resources.pic_empty_lecture;
                            lage[i].Text = null;
                            lclass[i].Text = null;
                            ldate[i].Text = null;
                            ldays[i].Text = null;
                            ltimes[i].Text = null;
                        }
                        else {

                        }
                    }
                }
            }
            else {
                Console.WriteLine("btnCount == 0");
                if (n != 0) {
                    Console.WriteLine("n :" + n);
                    Console.WriteLine("m : " + m);

                    for (int i = 0; i < pbx.Count; i++) {

                        Console.WriteLine("if");
                        pbx[i].Image = imgList.Images[i];
                        lage[i].Text = LectureList[i].LTar;
                        lclass[i].Text = LectureList[i].LLoc;
                        ldate[i].Text = LectureList[i].LPer;
                        ldays[i].Text = LectureList[i].LDay;
                        ltimes[i].Text = LectureList[i].LTime;
                    }
                }
                else {
                    Console.WriteLine("n == 0");
                    for (int i = 0; i < pbx.Count; i++) {

                        if (i < m) {
                            Console.WriteLine("if");
                            pbx[i].Image = imgList.Images[i];
                            lage[i].Text = LectureList[i].LTar;
                            lclass[i].Text = LectureList[i].LLoc;
                            ldate[i].Text = LectureList[i].LPer;
                            ldays[i].Text = LectureList[i].LDay;
                            ltimes[i].Text = LectureList[i].LTime;
                        }
                        else {
                            Console.WriteLine("else");
                            pbx[i].Image = Properties.Resources.pic_empty_lecture;
                            lage[i].Text = null;
                            lclass[i].Text = null;
                            ldate[i].Text = null;
                            ldays[i].Text = null;
                            ltimes[i].Text = null;
                        }

                    }
                }



            }

        }
    }

}

