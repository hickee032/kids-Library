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
    partial class FormMdBook : MetroFramework.Forms.MetroForm {

        BaseAdapter ba;
        string originBname;

        public FormMdBook(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            searchBookComboBox.SelectedIndex = 1;
        }

        private void BookListView() {
            DaoOra ora = ba.Ora;
            List<Book> list = ora.bookShow();
            updateListView(list);
        }

        private void FormMdBook_Load(object sender, EventArgs e) {
            BookListView();
        }

        private void bookLView_SelectedIndexChanged(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;

            if (bookLView.SelectedItems.Count != 0) {
                int n = bookLView.SelectedItems[0].Index;
                string bnum = bookLView.Items[n].SubItems[0].Text;
                string bname = bookLView.Items[n].SubItems[1].Text;
                string baut = bookLView.Items[n].SubItems[2].Text;
                string bpub = bookLView.Items[n].SubItems[3].Text;
                string byear = bookLView.Items[n].SubItems[4].Text;
                string bcat = bookLView.Items[n].SubItems[5].Text;
                string bdiv = bookLView.Items[n].SubItems[6].Text;
                string bnob = bookLView.Items[n].SubItems[7].Text;

                Console.WriteLine("도서 번호 :" + bnum);
                Console.WriteLine("  도서명  :" + bname);
                Console.WriteLine("   저자   :" + baut);
                Console.WriteLine("  출판사  :" + bpub);
                Console.WriteLine(" 장서수 :" + bnob);

                tbModBnum.Text = bnum;
                tbModBname.Text = bname;
                tbModBaut.Text = baut;
                tbModBpub.Text = bpub;
                tbModByear.Text = byear;
                tbModBcat.Text = bcat;
                tbModBdiv.Text = bdiv;
                tbModBnob.Text = bnob;
                originBname = bname;

                if (picview.Image != null) {
                    picview.Image.Dispose();
                    picview.Image = null;
                }

                ora.bookGetImg(picview, bname.ToString());
            }
        }

        private void updateListView(List<Book> list) {
            bookLView.BeginUpdate();
            bookLView.Items.Clear();
#if true
            for (int i = 0; i < list.Count; i++) {
                bookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Bnum,
                        list[i].Bname,
                        list[i].Baut,
                        list[i].Bpub,
                        list[i].Byear,
                        list[i].Bcat,
                        list[i].Bdiv,
                        list[i].Bnob
                    }));
            }
#else
            int num = 1;
            foreach(var n in list)
            {
                bookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        n.Bnum,
                        n.Bname,
                        n.Baut,
                        n.Bpub,
                        n.Byear,
                        n.Bcat,
                        n.Bdiv,
                        n.Bnob,
                        n.Bdcount
                    }));
            }
#endif
            bookLView.EndUpdate();
        }

        #region 버튼 이벤트

        private void btnModify_Click(object sender, EventArgs e) {
            List<Book> list = null;
            DaoOra ora = ba.Ora;
            if (ora != null) {
                //list = ora.updateBook(originBname, new Book(tbModBnum.Text, tbModBname.Text, tbModBaut.Text, tbModBpub.Text, tbModByear.Text, tbModBcat.Text, tbModBdiv.Text, tbModBnob.Text));
                list = ora.updateBook(originBname, new Book(tbModBnum.Text, tbModBname.Text, tbModBaut.Text, tbModBpub.Text, tbModByear.Text, tbModBcat.Text, tbModBdiv.Text, tbModBnob.Text, openFileImg.FileName));
            }
            updateListView(list);

            //ora.saveImg(tbModBname.Text, openFileImg.FileName);
        }


        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e) {
            List<Book> list = null;
            DaoOra ora = ba.Ora;
            if (ora != null) {
                list = ora.deleteBook(originBname, new Book(tbModBnum.Text, tbModBname.Text, tbModBaut.Text, tbModBpub.Text, tbModByear.Text, tbModBcat.Text, tbModBdiv.Text, tbModBnob.Text));
            }
            updateListView(list);
        }

        private void saveImg_Click(object sender, EventArgs e) {
            //DaoOra ora = ba.Ora;
            openFileImg.InitialDirectory = @"C:\";
            openFileImg.Filter = "jpeg 파일(*.jpg)|*.jpg|" +
                "png 파일(*.png)|*.png|" +
                "gif 파일(*.gif)|*.gif|" +
                "모든 파일(*.*)|*.*";
            openFileImg.FilterIndex = 0;
            openFileImg.RestoreDirectory = true;
            openFileImg.ShowDialog();
            string imgPath = openFileImg.FileName;
            /*saveImgName.Text =
                Path.GetFileNameWithoutExtension(imgPath);*/

            Image img = Image.FromFile(imgPath);
            picview.SizeMode = PictureBoxSizeMode.StretchImage;
            picview.Image = img;
            /*           ora.saveImg(saveImgName.Text, openFileImg.FileName);
                       List<string> list = ora.getImgName();
                       cbImgName.Items.Clear();
                       foreach (var n in list) cbImgName.Items.Add(n);
                       cbImgName.Text = "이미지 선택";
                       tbImgName.Text = "";*/
        }

        private void btnModiFind_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            List<Book> list = null;

            if (ora != null) {
                list = ora.searchBook(searchBookComboBox.Text, searchBookTextBox.Text);
            }
            updateListView(list);
        }

    }
}
