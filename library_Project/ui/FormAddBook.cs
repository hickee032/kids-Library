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
using Team1_Project.dao;
using Team1_Project.model;

namespace Team1_Project.ui {
    partial class FormAddBook : MetroFramework.Forms.MetroForm {

        BaseAdapter ba;

        public FormAddBook(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;

            for (int i = 2023; i >= 1900; i--) {
                cbYear.Items.Add(i.ToString() + "년");
            }
        }

        #region 버튼 이벤트

        private void btnAddBook_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;

            string publishingDate = cbYear.SelectedItem.ToString();
            string category = cbCat.SelectedItem.ToString();
            string division = cbDiv.SelectedItem.ToString();
            //string seq = "seq_bnum.nextval";

            bool found = ora.duplicationFind(tbBname.Text);

            if (found) // ture = 이미 책이 있을 때, sql 업데이트문으로 bnob 증가 시키기.
            {
                string dbbnob = ora.AddBnob(tbBname.Text);
                /*DB book table에서 tbBname.Text로 bnob 찾은 다음 
                 * int화 시키고 +1 계산한 다음 스트링화해서 반환하는 메쏘드*/

                ora.returnBnob(tbBname.Text, dbbnob);
                /*ora.AddBnob에서 만든 dbbnob를 book table에서 tbBname.Text로 검색해
                 업데이트 하는 메쏘드*/
            }
            else {
                ora.insertBook(new Book(tbBnum.Text, tbBname.Text, tbBaut.Text, tbBpub.Text, publishingDate, category, division, tbBnob.Text, "0", "0", openFileImg.FileName));
            }

            MessageBox.Show("책이 추가되었습니다.");
        }

        private void addImg_Click(object sender, EventArgs e) {

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
            picview.SizeMode = PictureBoxSizeMode.StretchImage;
            picview.Image = img;
            
        }

        private void initImg_Click(object sender, EventArgs e) {
            if (picview.Image != null) {
                picview.Image.Dispose();
                picview.Image = Properties.Resources.pic_empty_lecture;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion
    }
}
