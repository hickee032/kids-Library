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
        string id = string.Empty;

        int checkType = 0;

        public UcBookSearch(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            //enalbeRecommendBookbtn(로그인아이디번호)
        }

        public UcBookSearch(BaseAdapter ba, string id,int checkType) {
            InitializeComponent();
            this.ba = ba;
            this.checkType = checkType;
            this.id= id;

            if (checkType == 5) {
                RecommendBookbtn.Visible = true;
                BorrowBookbtn.Visible = false;
            }
            else if (checkType == 2) {
                RecommendBookbtn.Visible = true;
                BorrowBookbtn.Visible = true;
            }
            else if (checkType == 0) {
                RecommendBookbtn.Visible = false;
                BorrowBookbtn.Visible = false;
            }
            else {
                RecommendBookbtn.Visible = false;
                BorrowBookbtn.Visible = true;
            }
        }

        public UcBookSearch(BaseAdapter ba ,int checkType) {
            InitializeComponent();
            this.ba = ba;
            this.checkType = checkType;
            //enalbeRecommendBookbtn(로그인아이디번호)
            if (checkType == 5) {
                RecommendBookbtn.Visible = true;
                BorrowBookbtn.Visible=false;
            }
            else if (checkType == 2) {
                RecommendBookbtn.Visible = true;
                BorrowBookbtn.Visible = true;
            }
            else if (checkType == 0) {
                RecommendBookbtn.Visible = false;
                BorrowBookbtn.Visible = false;
            }
            else {
                RecommendBookbtn.Visible = false;
                BorrowBookbtn.Visible = true;
            }
        }

        private void UcBookSearch_Load(object sender, EventArgs e) {
            Console.WriteLine("검색에 들어옴");
            BookListView();
        }

        #region 도서 리스트 뷰

        private void BookListView() {
            Console.WriteLine("검색 list 들어옴");
            DaoOra ora = ba.Ora;
            List<Book> list = ora.bookShow();
            updatebookLView(list);
        }


        private void updatebookLView(List<Book> list) {
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
                        list[i].Bnob,
                        list[i].Bnobob,
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
                        n.Bnob,
                        n.Bnobob,
                        n.Bdcount
                    }));
            }
#endif
            bookLView.EndUpdate();
        }

        private void bookLView_SelectedIndexChanged(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            if (bookLView.SelectedItems.Count != 0) {
                int n = bookLView.SelectedItems[0].Index;
                string bnum = bookLView.Items[n].SubItems[0].Text;
                string bname = bookLView.Items[n].SubItems[1].Text;
                string baut = bookLView.Items[n].SubItems[2].Text;
                string bpub = bookLView.Items[n].SubItems[3].Text;

                Console.WriteLine("도서 번호 :" + bnum);
                Console.WriteLine("  도서명  :" + bname);
                Console.WriteLine("   저자   :" + baut);
                Console.WriteLine("  출판사  :" + bpub);


                if (picview.Image != null) {
                    picview.Image.Dispose();
                    picview.Image = null;
                }

                ora.bookGetImg(picview, bname.ToString());
            }
        }

        #endregion

        #region 버튼이벤트

        private void searchBookbtn_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            List<Book> list = null;

            if (ora != null) {
                list = ora.searchBook(searchBookComboBox.Text, searchBookTextBox.Text);
            }

            updatebookLView(list);
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
                    string nob = bookLView.Items[n].SubItems[7].Text;
                    string nobob = bookLView.Items[n].SubItems[8].Text;

                    Console.WriteLine(bookLView.Items[n].SubItems[7].Text);

                    Console.WriteLine(bookLView.Items[n].SubItems[8].Text);


                    int nobInt = int.Parse(nob);

                    int nobobInt = int.Parse(nobob);

                    if (nobInt - nobobInt <= 0) {
                        MessageBox.Show("잔여 장서량이 부족한 도서가 포함되어있습니다.", "잔여 도서 부족");
                        return;
                    }

                    selectedBookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        num,name,author,pub,year,cat,div,nob,nobob
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

        private void BorrowBookbtn_Click(object sender, EventArgs e) {

            DaoOra ora = ba.Ora;

                if (MessageBox.Show("담아두신 도서들을 대출하시겠습니까?." +
                   "\r계속 하시겠습니까?", "도서 대출",
                   MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    for (int i = 0; i < selectedBookLView.Items.Count; i++) {
                        string dbdnum = ora.borrowBook();
                        string dbcnum = id;   

                        string dbbnum = selectedBookLView.Items[i].SubItems[0].Text;
                        string dbddate = DateTime.Now.ToString("yyyy년MM월dd일");
                        string dbdreturn = DateTime.Now.AddDays(7).ToString("yyyy년MM월dd일");
                        string dbdreturned = string.Empty;
                        ora.insertDaechul(new Daechul(dbdnum, dbcnum, dbbnum, dbddate,
                            dbdreturn, dbdreturned));

                        List<NoBook> bnobobBdcount = ora.addBnobobBdcount(dbbnum);
                        ora.updateBnobBdcount(bnobobBdcount);
                    }

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
                    BookListView();
                }
        }

        private void RecommendBookbtn_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;

            if (MessageBox.Show("담아두신 도서들을 추천하시겠습니까?." +
                    "\r계속 하시겠습니까?", "도서 추천",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {
                for (int i = 0; i < selectedBookLView.Items.Count; i++) {
                    string dbtnum = "C0146";    // 이후 로그인한 계정의 CNUM으로 수정
                    string dbbnum = selectedBookLView.Items[i].SubItems[0].Text;
                    ora.insertRecommend(new Recommend(dbtnum, dbbnum));
                }

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

        private void cancelAllBookbtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("선택하신 모든 항목이 삭제 됩니다." +
                    "\r계속 하시겠습니까?", "항목 삭제",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (selectedBookLView.Items.Count != 0) {
                    selectedBookLView.Items.Clear();
                }
                else {
                    MessageBox.Show("선택된 항목이 없습니다.");
                }
            }
        }

        #endregion


    }
}
