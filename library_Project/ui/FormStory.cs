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
    public partial class FormStory : MetroFramework.Forms.MetroForm {

        List<Bitmap> pageS = new List<Bitmap> { Properties.Resources._0, Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4 };

        int i = 0;

        public FormStory() {
            InitializeComponent();
            btnStoryBack.Visible = false;
        }

        private void FormStory_Load(object sender, EventArgs e) {
            picStroy.BackgroundImage = pageS[i];
        }



        private void btnStoryBack_Click(object sender, EventArgs e) {
       
            i--;
                picStroy.BackgroundImage = pageS[i];
            if (i == 0) {
                btnStoryBack.Visible = false;
            }
        }

        private void btnStoryNext_Click(object sender, EventArgs e) {
  
            i++;
            picStroy.BackgroundImage = pageS[i];
            btnStoryBack.Visible = true;

            if (i==(pageS.Count - 1)) {
                btnStoryNext.Visible = false;
            }
            

            Console.WriteLine("i :" + i);
            Console.WriteLine(pageS.Count-1);


        }

        private void btnStoryExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnStoryExit1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
