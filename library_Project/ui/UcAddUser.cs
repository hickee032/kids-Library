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

    partial class UcAddUser : UserControl {

        BaseAdapter ba;

        #region
        #endregion

        #region 생성자
        
        public UcAddUser(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
        }

        #endregion

        private void btnAddProfile_Click(object sender, EventArgs e) {
            DaoOra ora = ba.Ora;
            string cgen = string.Empty;
            if (newCgenM.Checked) { cgen = "남"; }
            else if (newCgenF.Checked) { cgen = "여"; }
            string ctel = ctel1.SelectedItem.ToString() + "-" + ctel2.Text + "-" + ctel3.Text;
            string ctype = string.Empty;
            if (ctypeC.Checked) { ctype = "어린이"; }
            else if (ctypeA.Checked) { ctype = "성인"; }
            else if (ctypeP.Checked) { ctype = "학부모"; }
            else if (ctypeT.Checked) { ctype = "선생님"; }
            string cint = string.Empty;
            if (newCint1.Checked) { cint = "문학"; }
            else if (newCint2.Checked) { cint = "자연과학"; }
            else if (newCint3.Checked) { cint = "사회과학"; }
            else if (newCint4.Checked) { cint = "역사"; }
            else if (newCint5.Checked) { cint = "기술과학"; }
            else if (newCint6.Checked) { cint = "철학"; }
            string clast = DateTime.Now.ToString("yyyy년MM월dd일");
            string tnum = string.Empty;
            string lnum = string.Empty;
            ora.insertProfile(new Customer(tbxCnum.Text, cpw.Text, cname.Text, NewCage.Text, cgen, ctel, clast, ctype, pnum.Text, tnum, cschool.Text, cint, lnum));
            MessageBox.Show(" 회원정보가 등록되었습니다.");
        }

        private void btnIdCheck_Click(object sender, EventArgs e) {

            // DaoOra ora = ba.Ora;

            Form FormIDPermitted;

            if (tbxCnum.Text == string.Empty) {

                FormIDPermitted = new FormIDPermitted("아이디를 입력해주세요.");
                FormIDPermitted.ShowDialog();
                FormIDPermitted.StartPosition = FormStartPosition.CenterParent;
                tbxCnum.Focus();
            }
            else {
                if (ba.Ora.searchProfile(tbxCnum.Text) == tbxCnum.Text) {
                    FormIDPermitted = new FormIDPermitted();
                    FormIDPermitted.StartPosition = FormStartPosition.CenterParent;
                    FormIDPermitted.ShowDialog();
                }
                else if (ba.Ora.searchProfile(tbxCnum.Text) == "0") {
                    FormIDPermitted = new FormIDPermitted("사용불가능한 아이디 입니다.");
                    FormIDPermitted.StartPosition = FormStartPosition.CenterParent;
                    FormIDPermitted.ShowDialog();
                    tbxCnum.Focus();

                }

            }





            
            
        }
    }
}
