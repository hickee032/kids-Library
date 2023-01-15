using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1_Project.ui {
    public partial class FormIDPermitted : MetroFramework.Forms.MetroForm {
        
        public FormIDPermitted() {
            InitializeComponent();
        }

        public FormIDPermitted(string dalg) {
            InitializeComponent();
            labelSignCK.Text = dalg.ToString();
            
        }

        private void btnConform_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
