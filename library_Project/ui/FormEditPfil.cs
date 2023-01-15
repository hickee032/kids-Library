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
using Team1_Project.ui;

namespace Team1_Project.ui {
    partial class FormEditPfil : MetroFramework.Forms.MetroForm {

        BaseAdapter ba;

        //string loginId = string.Empty;

        public FormEditPfil(BaseAdapter ba) {

            InitializeComponent();
            this.ba = ba;
            //List<Customer> prof = ba.Ora.showProfile(UcLogin.ID);
        }

        public FormEditPfil(BaseAdapter ba, string id) {

            InitializeComponent();
            this.ba = ba;
            //this.loginId = id;
            profileCnum.Text= id;
            Console.WriteLine("로그인된 아이디 : "+ id);

            List<Customer> prof = ba.Ora.showProfile(id);

            string cpw = prof[0].Cpw;
            string cname = prof[0].Cname;
            string cage = prof[0].Cage;
            string cgen = prof[0].Cgen;
            string ctel = prof[0].Ctel;
            string clast = prof[0].Clast;
            string ctype = prof[0].Ctype;
            string pnum = prof[0].Pnum;
            string tnum = prof[0].Tnum;
            string cshool = prof[0].Cschool;
            string cint = prof[0].Cint;
            string lnum = prof[0].Lnum;
            modCpw.Text = cpw;
            modCname.Text = cname;
            modCage.Text = cage;
            if (cgen == "남") { modCgenM.Checked = true; }
            else if (cgen == "여") { modCgenF.Checked = true; }
            if (ctype == "어린이") { modCtype.SelectedItem = modCtype.Items[0]; }
            else if (ctype == "성인") { modCtype.SelectedItem = modCtype.Items[1]; }
            else if (ctype == "학부모") { modCtype.SelectedItem = modCtype.Items[2]; }
            else if (ctype == "선생님") { modCtype.SelectedItem = modCtype.Items[3]; }
            modPnum.Text = pnum;
            modCschool.Text = cshool;
            if (cint == "기술과학") { modCint.SelectedItem = modCint.Items[0]; }
            else if (cint == "문학") { modCint.SelectedItem = modCint.Items[1]; }
            else if (cint == "사회과학") { modCint.SelectedItem = modCint.Items[2]; }
            else if (cint == "역사") { modCint.SelectedItem = modCint.Items[3]; }
            else if (cint == "자연과학") { modCint.SelectedItem = modCint.Items[4]; }
            else if (cint == "철학") { modCint.SelectedItem = modCint.Items[5]; }
        }

        private void modCtype_SelectedIndexChanged(object sender, EventArgs e) {
            modCtype.Text = modCtype.SelectedItem.ToString();
        }

        private void modCint_SelectedIndexChanged(object sender, EventArgs e) {
            modCint.Text = modCint.SelectedItem.ToString();
        }

        private void UpdateProfile_Click(object sender, EventArgs e) {
            List<Customer> list = null;
            DaoOra ora = ba.Ora;
            string cnum = profileCnum.Text;
            string modCgen = string.Empty;
            if (modCgenM.Checked) { modCgen = "남"; }
            else if (modCgenF.Checked) { modCgen = "여"; }
            string modCtel = modCtel1.SelectedItem + "-" + modCtel2.Text + "-" + modCtel3.Text;
            if (ora != null) {
                list = ora.updateProfile(cnum,
                    new Customer(cnum, modCpw.Text, modCname.Text, modCage.Text, modCgen, modCtel, modCtype.Text, modPnum.Text, modCschool.Text, modCint.Text));
            }
        }

        private void labelFormEditClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
