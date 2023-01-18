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
    partial class FormMdCustomer : MetroFramework.Forms.MetroForm {

        BaseAdapter ba;
        string originCname;

        public FormMdCustomer(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;

            cbFindOption.SelectedIndex = 0; // 콤보박스 초기값 설정
        }

        private void CustomerListView() {
            DaoOra ora = ba.Ora;
            List<Customer> list = ora.customerDataShow();
            updateListView(list);
        }

        private void FormMdCustomer_Load(object sender, EventArgs e) {
            CustomerListView();
        }

        private void updateListView(List<Customer> list) {
            cusLView.BeginUpdate();
            cusLView.Items.Clear();
#if true
            for (int i = 0; i < list.Count; i++) {

                Console.WriteLine(list[i].Cname);
                cusLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Cnum,
                        list[i].Cname,
                        list[i].Cage,
                        list[i].Cgen,
                        list[i].Ctel,
                        list[i].Clast,
                        list[i].Ctype,
                        list[i].Pnum,
                        list[i].Tnum,
                        list[i].Cschool,
                        list[i].Cint,
                        list[i].Lnum
                    }));
            }
#else
            int num = 1;
            foreach(var n in list)
            {
                cusLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        n.Cnum,
                        n.Cname,
                        n.Cage,
                        n.Cgen,
                        n.Ctel,
                        n.Clast,
                        n.Ctype,
                        n.Pnum,
                        n.Tnum,
                        n.Cschool,
                        n.Cint,
                        n.Lnum
                    }));
            }
#endif
            cusLView.EndUpdate();
        }

        private void tbMemView_Click(object sender, EventArgs e) {
            tbFindCus.Clear();
        }

        private void tbMemView_Leave(object sender, EventArgs e) {
            //tbFindCus.Text = "검색어를 입력하세요.";
        }

        private void isChecked() {
            DaoOra ora = ba.Ora;
            string cusType;

            if (chkChild.Checked && chkParent.Checked) {
                List<Customer> list = ora.customerDataShow();
                updateListView(list);
            }
            else if (chkChild.Checked) {
                cusType = chkChild.Text;
                List<Customer> list = ora.customerDataType(cusType);
                updateListView(list);
            }
            else if (chkParent.Checked) {
                cusType = chkParent.Text;
                List<Customer> list = ora.customerDataType(cusType);
                updateListView(list);
            }
            else {
                List<Customer> list = ora.customerDataShow();
                updateListView(list);
            }

        }
        private void chkChild_CheckedChanged(object sender, EventArgs e) {
            isChecked();
        }
        private void chkParent_CheckedChanged(object sender, EventArgs e) {
            isChecked();
        }

        private void btnCusFind_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            List<Customer> list = null;

            if (ora != null) {
                list = ora.customerSearch(cbFindOption.Text, tbFindCus.Text);
            }
            cusLView.BeginUpdate();
            cusLView.Items.Clear();
#if true
            for (int i = 0; i < list.Count; i++) {
                cusLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Cnum,
                        list[i].Cname,
                        list[i].Cage,
                        list[i].Cgen,
                        list[i].Ctel,
                        list[i].Clast,
                        list[i].Ctype,
                        list[i].Pnum,
                        list[i].Tnum,
                        list[i].Cschool,
                        list[i].Cint,
                        list[i].Lnum
                    }));
            }
#else
            int num = 1;
            foreach(var n in list)
            {
                cusLView.Items.Add(new ListViewItem(
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
            cusLView.EndUpdate();

        }

        private void btnFindInit_Click(object sender, EventArgs e) {
            cbFindOption.SelectedIndex = 0;
            tbFindCus.Text = string.Empty;
            cusLView.Items.Clear();
            CustomerListView();
        }

        private void cusLView_SelectedIndexChanged(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;

            if (cusLView.SelectedItems.Count != 0) {

                int n = cusLView.SelectedItems[0].Index;
                string cnum = cusLView.Items[n].SubItems[0].Text;
                string cname = cusLView.Items[n].SubItems[1].Text;
                string cage = cusLView.Items[n].SubItems[2].Text;
                string cgen = cusLView.Items[n].SubItems[3].Text;
                string ctel = cusLView.Items[n].SubItems[4].Text;
                string clast = cusLView.Items[n].SubItems[5].Text;
                string ctype = cusLView.Items[n].SubItems[6].Text;
                string pnum = cusLView.Items[n].SubItems[7].Text;
                string tnum = cusLView.Items[n].SubItems[8].Text;
                string cschool = cusLView.Items[n].SubItems[9].Text;
                string cint = cusLView.Items[n].SubItems[10].Text;
                string lnum = cusLView.Items[n].SubItems[11].Text;
                Console.WriteLine("번호:" + cnum);
                Console.WriteLine("이름:" + cname);
                Console.WriteLine("별명:" + cgen);
                Console.WriteLine("생일:" + ctel);
                tbModCnum.Text = cnum;
                tbModCname.Text = cname;
                tbModCage.Text = cage;
                tbModCgen.Text = cgen;
                tbModCtel.Text = ctel;
                tbModClast.Text = clast;
                tbModCtype.Text = ctype;
                tbModPnum.Text = pnum;
                tbModTnum.Text = tnum;
                tbModCschool.Text = cschool;
                tbModCint.Text = cint;
                tbModLnum.Text = lnum;
                originCname = cname;

                /*
                if (picview.Image != null) {
                    picview.Image.Dispose();
                    picview.Image = null;
                }

                ora.getImg(picview, cnum.ToString());
                */
            }
        }

        private void btnCusDel_Click(object sender, EventArgs e) {
            List<Customer> list = null;
            DaoOra ora = ba.Ora;
            if (ora != null) {
                list = ora.customerDelete(originCname, new Customer(tbModCnum.Text, tbModCname.Text, tbModCage.Text, tbModCgen.Text, tbModCtel.Text, tbModClast.Text, tbModCtype.Text, tbModPnum.Text, tbModTnum.Text, tbModCschool.Text, tbModCint.Text, tbModLnum.Text));
            }
            updateListView(list);
        }

        private void btnCusMod_Click(object sender, EventArgs e) {
            List<Customer> list = null;
            DaoOra ora = ba.Ora;
            if (ora != null) {
                list = ora.customerUpdate(originCname, new Customer(tbModCnum.Text, tbModCname.Text, tbModCage.Text, tbModCgen.Text, tbModCtel.Text, tbModClast.Text, tbModCtype.Text, tbModPnum.Text, tbModTnum.Text, tbModCschool.Text, tbModCint.Text, tbModLnum.Text));
            }
            updateListView(list);
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
