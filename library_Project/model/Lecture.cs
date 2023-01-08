using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_Project.model {
    internal class Lecture {

        string lNum;
        string lName;
        string lLoc;
        string lTar;
        string lPer;
        string lTime;
        string lDay;

        public Lecture(string lNum, string lName, string lLoc, string lTar, string lPer, string lTime, string lDay) {
            this.lNum = lNum;
            this.lName = lName;
            this.lLoc = lLoc;
            this.lTar = lTar;
            this.lPer = lPer;
            this.lTime = lTime;
            this.lDay = lDay;
        }

        public string LNum { get => lNum; set => lNum = value; }
        public string LName { get => lName; set => lName = value; }
        public string LLoc { get => lLoc; set => lLoc = value; }
        public string LTar { get => lTar; set => lTar = value; }
        public string LPer { get => lPer; set => lPer = value; }
        public string LTime { get => lTime; set => lTime = value; }
        public string LDay { get => lDay; set => lDay = value; }
    }
}
