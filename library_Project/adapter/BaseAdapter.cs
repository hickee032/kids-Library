using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library_Project.dao;

namespace library_Project.adapter {
    internal class BaseAdapter {

        DaoOra ora;

        public BaseAdapter() {
            ora = new DaoOra();
        }

        public DaoOra Ora { get => ora; set => ora = value; }
    }
}
