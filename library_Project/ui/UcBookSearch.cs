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
     partial class UcBookSearch : UserControl {

        BaseAdapter ba;

        public UcBookSearch() {
            InitializeComponent();
        }

        public UcBookSearch(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
        }

        private void BookListView() {
            DaoOra ora = ba.Ora;
            List<Book> list = ora.bookShow();
            updateListView(list);
        }

        private void SearchBook_Load(object sender, EventArgs e) {
            BookListView();
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
                        list[i].Bdcount
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
                        n.Bdcount
                    }));
            }
#endif
            bookLView.EndUpdate();
        }

        private void searchBookbtn_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            List<Book> list = null;

            if (ora != null) {
                list = ora.bookSearch(searchBookComboBox.Text,
                    searchBookTextBox.Text);
            }
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
                        list[i].Bdcount
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
                        n.Bdcount
                    }));
            }
#endif
            bookLView.EndUpdate();
        }

        private void searchBookResetbtn_Click(object sender, EventArgs e) {
            searchBookComboBox.Text = "검색 선택";
            searchBookTextBox.Text = string.Empty;
            bookLView.Items.Clear();
            BookListView();
        }

        private void selectBookbtn_Click(object sender, EventArgs e) {
            if (bookLView.SelectedItems.Count != 0) {
                for (int i = 0; i < bookLView.SelectedItems.Count; i++) {
                    int n = bookLView.SelectedItems[i].Index;
                    string num = bookLView.Items[n].SubItems[0].Text;
                    string name = bookLView.Items[n].SubItems[1].Text;
                    string author = bookLView.Items[n].SubItems[2].Text;
                    string pub = bookLView.Items[n].SubItems[3].Text;
                    string year = bookLView.Items[n].SubItems[4].Text;
                    string cat = bookLView.Items[n].SubItems[5].Text;
                    string div = bookLView.Items[n].SubItems[6].Text;

                    selectedBookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        num,name,author,pub,year,cat,div
                    }));
                }
            }
        }

        private void cancelBookbtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("선택하신 항목이 삭제 됩니다." +
                "\r계속 하시겠습니까?", "항목 삭제",
                MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (selectedBookLView.SelectedItems.Count != 0) {
                    /* 멀티 셀렉트 없이 하나씩 삭제
                    int n = selectedBookLView.SelectedItems[0].Index;
                    selectedBookLView.Items.RemoveAt(n);
                    */
                    /* SelectedItem 대신 FocusedItem 사용
                    int n = selectedBookLView.FocusedItem.Index;
                    selectedBookLView.Items.RemoveAt(n);
                    */
                    int cancelCount = selectedBookLView.SelectedItems.Count;
                    Console.WriteLine(cancelCount);
                    for (int i = 0; i < cancelCount; i++) {
                        int n = selectedBookLView.SelectedItems[0].Index;
                        selectedBookLView.Items.RemoveAt(n);
                    }
                }
                else {
                    MessageBox.Show("선택된 항목이 없습니다.");
                }
            }
        }

        private void RecommendBookbtn_Click(object sender, EventArgs e) {

        }

        private void cancelAllBookbtn_Click(object sender, EventArgs e) {
            {
                if (MessageBox.Show("선택하신 모든 항목이 삭제 됩니다." +
                    "\r계속 하시겠습니까?", "항목 삭제",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    if (selectedBookLView.Items.Count != 0) {
                        int cancelCount = selectedBookLView.Items.Count;
                        for (int i = 0; i < cancelCount; i++) {
                            int index = selectedBookLView.Items[0].Index;
                            selectedBookLView.Items.RemoveAt(index);
                        }
                    }
                    else {
                        MessageBox.Show("선택된 항목이 없습니다.");
                    }
                }
            }
        }
    }
}
