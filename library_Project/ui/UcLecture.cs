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
using Team1_Project.model;
using static System.Net.Mime.MediaTypeNames;


namespace Team1_Project.ui {

    partial class UcLecture : UserControl {

        const string UC_LECINFO = "UcLec_Info";

        BaseAdapter ba;

        public UcLecture (BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            this.Load += UcLecture_Load;

        }

        private void UcLecture_Load(object sender, EventArgs e) {
            GetImageListView();
        }
        
        public void GetImageListView() {
            
                List<PictureBox> picBoxList = new List<PictureBox>();

                List<string> ImgNameList = ba.Ora.tableGetColumn("lnum", "lecture");

                for (int i = 0; i < ImgNameList.Count; i++) {
                    imageList1.Images.Add(ba.Ora.tableGetimage(ImgNameList[i], "lectureImg"));
                }
               this.pictureBox1.Image = this.imageList1.Images[0];

                    
                this.Refresh();
            
        }

        //강좌 등록
        private void btnLecAdd_Click(object sender, EventArgs e) {
            FormAddLecture fal = new FormAddLecture(ba);
            fal.ShowDialog();
        }
    }
}
