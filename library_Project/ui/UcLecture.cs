using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library_Project.adapter;


namespace library_Project.ui {

    partial class UcLecture : UserControl {

        const string UC_LECINFO = "UcLec_Info";

        BaseAdapter ba;

        public UcLecture() {
            InitializeComponent();
            this.Load += UcLecture_Load;
        }
        public UcLecture (BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            this.Load += UcLecture_Load;

        }

        private void UcLecture_Load(object sender, EventArgs e) {
            GetImageListView();
        }

        public void GetImageListView() {
            this.Invoke(new MethodInvoker(delegate () {

                Image image1 = Properties.Resources.icon_cancel;
                Image image2 = Properties.Resources.icon_profile;
                Image image3 = Properties.Resources.icon_home;

                imageList1.Images.Add(image1);
                imageList1.Images.Add(image2);
                imageList1.Images.Add(image3);

                imageList1.ImageSize = new Size(64, 64);
                imageList1.ColorDepth = ColorDepth.Depth32Bit;

               this.pictureBox1.Image = (Image)this.imageList1.Images[0];
               this.pictureBox2.Image = (Image)this.imageList1.Images[1];
               this.pictureBox3.Image = (Image)this.imageList1.Images[2];
                    


                this.Refresh();
            }));
        }

        //강좌 등록 창
        private void button5_Click(object sender, EventArgs e) {
            FormAddLecture fal = new FormAddLecture(ba);
            fal.ShowDialog();
        }
    }
}
