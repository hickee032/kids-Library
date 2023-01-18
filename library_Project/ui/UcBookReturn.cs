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
    partial class UcBookReturn : UserControl {

        BaseAdapter ba;
        string id;
        int checkType;

        public UcBookReturn(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
        }

        public UcBookReturn(BaseAdapter ba, string id) {
            InitializeComponent();
            this.ba = ba;
            this.id = id;
            Console.WriteLine(id);
        }

        public UcBookReturn(BaseAdapter ba, string id,int checkType) {
            InitializeComponent();
            this.ba = ba;
            this.id = id;

            Console.WriteLine(id);

            this.checkType = checkType;
            this.Load += UcBookReturn_Load;
        }

        private void UcBookReturn_Load(object sender, EventArgs e) {
            //this.Refresh();
            DaechulBookListView();
        }

        private void DaechulBookListView() {
            DaoOra ora = ba.Ora;
            List<DaechulBook> list = ora.DaechulShow(id);
            updateDCBookLView(list);
        }

        private void updateDCBookLView(List<DaechulBook> list) {
            daechulBookLView.BeginUpdate();
            daechulBookLView.Items.Clear();
#if true
            for (int i = 0; i < list.Count; i++) {
                daechulBookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Bnum,
                        list[i].Bname,
                        list[i].Baut,
                        list[i].Ddate,
                        list[i].Dreturn,
                        list[i].Dnum
                    }));
            }
#else
            int num = 1;
            foreach(var n in list)
            {
                daechulBookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        n.Bnum,
                        n.Bname,
                        n.Baut,
                        n.Bdate,
                        n.Breturn,
                        n.Bnum
                    }));
            }
#endif
            daechulBookLView.EndUpdate();
        }

        private void searchDCBookbtn_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            List<DaechulBook> list = null;

            if (ora != null) {
                list = ora.DaechulSearch(searchBookComboBox.Text,
                    searchBookTextBox.Text,id);
            }
            daechulBookLView.BeginUpdate();
            daechulBookLView.Items.Clear();
#if true
            for (int i = 0; i < list.Count; i++) {
                daechulBookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Bnum,
                        list[i].Bname,
                        list[i].Baut,
                        list[i].Ddate,
                        list[i].Dreturn,
                        list[i].Dnum
                    }));
            }
#else
            int num = 1;
            foreach(var n in list)
            {
                daechulBookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        n.Bnum,
                        n.Bname,
                        n.Baut,
                        n.Bdate,
                        n.Breturn,
                        n.Bnum
                    }));
            }
#endif
            daechulBookLView.EndUpdate();
        }

        private void selectDCBookbtn_Click(object sender, EventArgs e) {
            if (daechulBookLView.SelectedItems.Count != 0) {
                for (int i = 0; i < daechulBookLView.SelectedItems.Count; i++) {
                    int n = daechulBookLView.SelectedItems[i].Index;
                    string bnum = daechulBookLView.Items[n].SubItems[0].Text;
                    string bname = daechulBookLView.Items[n].SubItems[1].Text;
                    string bauthor = daechulBookLView.Items[n].SubItems[2].Text;
                    string ddate = daechulBookLView.Items[n].SubItems[3].Text;
                    string dreturn = daechulBookLView.Items[n].SubItems[4].Text;
                    string dnum = daechulBookLView.Items[n].SubItems[5].Text;

                    selectedDCBookLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        bnum,bname,bauthor,ddate,dreturn,dnum
                    }));
                }
            }
        }

        private void cancelDCBookbtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("선택하신 항목이 삭제 됩니다." +
                "\r계속 하시겠습니까?", "항목 삭제",
                MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (selectedDCBookLView.SelectedItems.Count != 0) {
                    /* 멀티 셀렉트 없이 하나씩 삭제
                    int n = selectedDCBookLView.SelectedItems[0].Index;
                    selectedDCBookLView.Items.RemoveAt(n);
                    */
                    /* SelectedItem 대신 FocusedItem 사용
                    int n = selectedDCBookLView.FocusedItem.Index;
                    selectedDCBookLView.Items.RemoveAt(n);
                    */
                    int cancelCount = selectedDCBookLView.SelectedItems.Count;
                    Console.WriteLine(cancelCount);
                    for (int i = 0; i < cancelCount; i++) {
                        int n = selectedDCBookLView.SelectedItems[0].Index;
                        selectedDCBookLView.Items.RemoveAt(n);
                    }
                }
                else {
                    MessageBox.Show("선택된 항목이 없습니다.");
                }
            }
        }

        private void ReturnDCBookbtn_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            //DateTime nowDate;

            if (MessageBox.Show("담아두신 도서들을 반납하시겠습니까?." +
                    "\r계속 하시겠습니까?", "도서 반납",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {
                for (int i = 0; i < selectedDCBookLView.Items.Count; i++) {
                    string dbdnum = selectedDCBookLView.Items[i].SubItems[5].Text;
                    string dbdreturned = DateTime.Now.ToString("yyyy년MM월dd일");

                    ora.DaechulReturn(new Daechul(dbdnum, dbdreturned));

                    string dbbnum = selectedDCBookLView.Items[i].SubItems[0].Text;
                    string dbbnobob = ora.SubBnobob(dbbnum);
                    /*DB book table에서 dbbnum으로 bnobob 찾은다음 
                     * int화 시키고 -1계산한 다음 스트링화해서 반환하는 메쏘드*/

                    ora.returnBnobob(dbbnum, dbbnobob);
                    /*ora.SubBnobob에서 만든 dbbnobob를 book table에서 dbbnum로 검색해
                     업데이트 하는 메쏘드*/

                    //List<NOBooks> bnobobBdcount = ora.addBnobobBdcount(dbbnum);
                    //ora.updateBnobBdcount(bnobobBdcount);
                    searchDCBookReset();
                }
                if (selectedDCBookLView.Items.Count != 0) {
                    int cancelCount = selectedDCBookLView.Items.Count;
                    for (int i = 0; i < cancelCount; i++) {
                        int index = selectedDCBookLView.Items[0].Index;
                        selectedDCBookLView.Items.RemoveAt(index);
                    }
                }
                else {
                    MessageBox.Show("선택된 항목이 없습니다.");
                }
                DaechulBookListView();
            }
        }

        private void cancelAllDCBookbtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("선택하신 모든 항목이 삭제 됩니다." +
                    "\r계속 하시겠습니까?", "항목 삭제",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (selectedDCBookLView.Items.Count != 0) {
                    selectedDCBookLView.Items.Clear();
                }
                else {
                    MessageBox.Show("선택된 항목이 없습니다.");
                }
            }
        }

        private void searchDCBookResetbtn_Click(object sender, EventArgs e) {
            searchDCBookReset();
        }

        private void daechulBookLView_SelectedIndexChanged(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            if (daechulBookLView.SelectedItems.Count != 0) {
                int n = daechulBookLView.SelectedItems[0].Index;
                string bnum = daechulBookLView.Items[n].SubItems[0].Text;
                string bname = daechulBookLView.Items[n].SubItems[1].Text;
                string baut = daechulBookLView.Items[n].SubItems[2].Text;
                string bpub = daechulBookLView.Items[n].SubItems[3].Text;

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

        private void searchDCBookReset() {
            searchBookComboBox.Text = "검색 선택";
            searchBookTextBox.Text = string.Empty;
            daechulBookLView.Items.Clear();
            DaechulBookListView();
        }
    }
}
