using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Project.model {
    internal class Customer {

        string cnum;
        string cpw;
        string cname;
        string cage;
        string cgen;
        string ctel;
        string clast;
        string ctype;
        string pnum;
        string tnum;
        string cschool;
        string cint;
        string lnum;

        public Customer(string cnum, string cname, string cage, string ctype, string ctel, string clast) {
            this.cnum = cnum;
            this.cname = cname;
            this.cage = cage;
            this.ctype = ctype;
            this.ctel = ctel;
            this.clast = clast;
        }

        /*
        public Customer(string cnum, string cname, string cage, string cgen, string ctel, 
            string ctype, string pnum, string tnum, string cschool, string cint, string lnum)
        {
            this.cnum = cnum;
            this.cname = cname;
            this.cage = cage;
            this.cgen = cgen;
            this.ctel = ctel;
            this.ctype = ctype;
            this.pnum = pnum;
            this.tnum = tnum;
            this.cschool = cschool;
            this.cint = cint;
            this.lnum= lnum;
        }*/

        public Customer(string cnum, string cpw, string cname, string cage, string cgen, string ctel,
            string ctype, string pnum, string cschool, string cint) {
            this.cnum = cnum;
            this.cpw = cpw;
            this.cname = cname;
            this.cage = cage;
            this.cgen = cgen;
            this.ctel = ctel;
            this.ctype = ctype;
            this.pnum = pnum;
            this.cschool = cschool;
            this.cint = cint;
        }
        public Customer(string cnum, string cpw, string cname, string cage, string cgen, string ctel,
            string clast, string ctype, string pnum, string tnum, string cschool, string cint) {
            this.cnum = cnum;
            this.cpw = cpw;
            this.cname = cname;
            this.cage = cage;
            this.cgen = cgen;
            this.ctel = ctel;
            this.clast = clast;
            this.ctype = ctype;
            this.pnum = pnum;
            this.tnum = tnum;
            this.cschool = cschool;
            this.cint = cint;
        }



        public Customer(string cnum, string cpw, string cname, string cage, string cgen, string ctel,
            string clast, string ctype, string pnum, string tnum, string cschool, string cint, string lnum) {
            this.cnum = cnum;
            this.cpw = cpw;
            this.cname = cname;
            this.cage = cage;
            this.cgen = cgen;
            this.ctel = ctel;
            this.clast = clast;
            this.ctype = ctype;
            this.pnum = pnum;
            this.tnum = tnum;
            this.cschool = cschool;
            this.cint = cint;
            this.lnum = lnum;
        }

        public string Cnum { get => cnum; set => cnum = value; }
        public string Cpw { get => cpw; set => cpw = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Cage { get => cage; set => cage = value; }
        public string Cgen { get => cgen; set => cgen = value; }
        public string Ctel { get => ctel; set => ctel = value; }
        public string Clast { get => clast; set => clast = value; }
        public string Ctype { get => ctype; set => ctype = value; }
        public string Pnum { get => pnum; set => pnum = value; }
        public string Tnum { get => tnum; set => tnum = value; }
        public string Cschool { get => cschool; set => cschool = value; }
        public string Cint { get => cint; set => cint = value; }
        public string Lnum { get => lnum; set => lnum = value; }

    }
}
