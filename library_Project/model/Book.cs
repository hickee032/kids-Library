using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Project.model {
    internal class Book {
        string bnum;
        string bname;
        string baut;
        string bpub;
        string byear;
        string bcat;
        string bdiv;
        string bdcount;

        public Book(string bnum, string bname, string baut, string bpub,
            string byear, string bcat, string bdiv, string bdcount) {
            this.bnum = bnum;
            this.bname = bname;
            this.baut = baut;
            this.bpub = bpub;
            this.byear = byear;
            this.bcat = bcat;
            this.bdiv = bdiv;
            this.bdcount = bdcount;
        }

        public string Bnum { get => bnum; set => bnum = value; }
        public string Bname { get => bname; set => bname = value; }
        public string Baut { get => baut; set => baut = value; }
        public string Bpub { get => bpub; set => bpub = value; }
        public string Byear { get => byear; set => byear = value; }
        public string Bcat { get => bcat; set => bcat = value; }
        public string Bdiv { get => bdiv; set => bdiv = value; }
        public string Bdcount { get => bdcount; set => bdcount = value; }
    }
}
