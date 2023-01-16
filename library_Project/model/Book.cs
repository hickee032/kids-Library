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
        string bnob;
        string bnobob;
        string bdcount;
        string path;

        public Book(string bnum, string bname, string baut, string bpub, string byear, string bcat, string bdiv, string bnob, string bnobob, string bdcount) {
            this.bnum = bnum;
            this.bname = bname;
            this.baut = baut;
            this.bpub = bpub;
            this.byear = byear;
            this.bcat = bcat;
            this.bdiv = bdiv;
            this.bnob = bnob;
            this.bnobob = bnobob;
            this.bdcount = bdcount;
        }

        public Book(string bnum, string bname, string baut, string bpub, string byear, string bcat, string bdiv, string bnob) // 변수 7개 : 수정할 때 사용
        {
            this.bnum = bnum;
            this.bname = bname;
            this.baut = baut;
            this.bpub = bpub;
            this.byear = byear;
            this.bcat = bcat;
            this.bdiv = bdiv;
            this.bnob = bnob;
        }

        public Book(string bnum, string bname, string baut, string bpub, string byear, string bcat, string bdiv, string bnob, string path) // 변수 7개 : 수정할 때 사용
        {
            this.bnum = bnum;
            this.bname = bname;
            this.baut = baut;
            this.bpub = bpub;
            this.byear = byear;
            this.bcat = bcat;
            this.bdiv = bdiv;
            this.bnob = bnob;
            this.path = path;
        }

        public Book(string bnum, string bname, string baut, string bpub, string byear, string bcat, string bdiv, string bnob, string bnobob, string bdcount, string path) // 변수 11개 :  책 추가할 때 사용함
        {
            this.bnum = bnum;
            this.bname = bname;
            this.baut = baut;
            this.bpub = bpub;
            this.byear = byear;
            this.bcat = bcat;
            this.bdiv = bdiv;
            this.bnob = bnob;
            this.bnobob = bnobob;
            this.bdcount = bdcount;
            this.path = path;
        }

        public string Bnum { get => bnum; set => bnum = value; }
        public string Bname { get => bname; set => bname = value; }
        public string Baut { get => baut; set => baut = value; }
        public string Bpub { get => bpub; set => bpub = value; }
        public string Byear { get => byear; set => byear = value; }
        public string Bcat { get => bcat; set => bcat = value; }
        public string Bdiv { get => bdiv; set => bdiv = value; }
        public string Bnob { get => bnob; set => bnob = value; }
        public string Bnobob { get => bnobob; set => bnobob = value; }
        public string Bdcount { get => bdcount; set => bdcount = value; }
        public string Path { get => path; set => path = value; }
    }
}
