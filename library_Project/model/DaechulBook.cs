using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Project.model {
    internal class DaechulBook {

        string bnum;
        string bname;
        string baut;
        string ddate;
        string dreturn;
        string dnum;

        public DaechulBook(string bnum, string bname, string baut,
            string ddate, string dreturn, string dnum) {
            this.bnum = bnum;
            this.bname = bname;
            this.baut = baut;
            this.ddate = ddate;
            this.dreturn = dreturn;
            this.dnum = dnum;
        }

        public string Bnum { get => bnum; set => bnum = value; }
        public string Bname { get => bname; set => bname = value; }
        public string Baut { get => baut; set => baut = value; }
        public string Ddate { get => ddate; set => ddate = value; }
        public string Dreturn { get => dreturn; set => dreturn = value; }
        public string Dnum { get => dnum; set => dnum = value; }

    }
}
