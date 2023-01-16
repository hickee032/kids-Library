using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_Project.model {
    internal class Recommend {

        string tnum;
        string bnum;

        public Recommend(string tnum, string bnum) {
            this.tnum = tnum;
            this.bnum = bnum;
        }

        public string Tnum { get => tnum; set => tnum = value; }
        public string Bnum { get => bnum; set => bnum = value; }

    }
}
