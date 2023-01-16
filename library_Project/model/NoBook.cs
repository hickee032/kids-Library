using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Project.model {

    internal class NoBook {
        string bnum;
        string bnobob;
        string bdcount;

        public NoBook(string bnum, string bnobob, string bdcount) {
            this.bnum = bnum;
            this.bnobob = bnobob;
            this.bdcount = bdcount;
        }

        public string Bnum { get => bnum; set => bnum = value; }
        public string Bnobob { get => bnobob; set => bnobob = value; }
        public string Bdcount { get => bdcount; set => bdcount = value; }
    }
}
