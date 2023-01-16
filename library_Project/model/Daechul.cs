using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Project.model {
    internal class Daechul {

        string dnum;
        string cnum;
        string bnum;
        string ddate;
        string dreturn;
        string dreturned;

        public Daechul(string dnum, string cnum, string bnum,
            string ddate, string dreturn, string dreturned) {
            this.dnum = dnum;
            this.cnum = cnum;
            this.bnum = bnum;
            this.ddate = ddate;
            this.dreturn = dreturn;
            this.dreturned = dreturned;
        }

        public Daechul(string dnum, string dreturned) {
            this.dnum = dnum;
            this.dreturned = dreturned;
        }

        public string Dnum { get => dnum; set => dnum = value; }
        public string Cnum { get => cnum; set => cnum = value; }
        public string Bnum { get => bnum; set => bnum = value; }
        public string Ddate { get => ddate; set => ddate = value; }
        public string Dreturn { get => dreturn; set => dreturn = value; }
        public string Dreturned { get => dreturned; set => dreturned = value; }

    }
}
