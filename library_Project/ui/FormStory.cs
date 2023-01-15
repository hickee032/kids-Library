using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Team1_Project.ui {
    public partial class FormStory : MetroFramework.Forms.MetroForm {

        List<string> pageUrl = new List<string> {
        "https://raw.githubusercontent.com/hickee032/ImageRepo/main/storyPage/Librarystory_0.jpg",
        "https://raw.githubusercontent.com/hickee032/ImageRepo/main/storyPage/Librarystory_1.jpg",
        "https://raw.githubusercontent.com/hickee032/ImageRepo/main/storyPage/Librarystory_2.jpg",
        "https://raw.githubusercontent.com/hickee032/ImageRepo/main/storyPage/Librarystory_3.jpg",
        "https://raw.githubusercontent.com/hickee032/ImageRepo/main/storyPage/Librarystory_4.jpg",
        "https://raw.githubusercontent.com/hickee032/ImageRepo/main/storyPage/Librarystory_5.jpg"
        };

        int i = 0;

        public FormStory() {
            InitializeComponent();
            btnStoryBack.Visible = false;
        }

        private void FormStory_Load(object sender, EventArgs e) {
            picStroy.Load(pageUrl[i]);
            picStroy.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void btnStoryBack_Click(object sender, EventArgs e) {
       
            i--;
            picStroy.Load(pageUrl[i]);
            if (i == 0) {
                btnStoryBack.Visible = false;
            }
        }

        private void btnStoryNext_Click(object sender, EventArgs e) {
  
            i++;
            picStroy.Load(pageUrl[i]); ;
            btnStoryBack.Visible = true;

            if (i==(pageUrl.Count - 1)) {
                btnStoryNext.Visible = false;
            }
            

            Console.WriteLine("i :" + i);
            Console.WriteLine(pageUrl.Count-1);


        }

        private void btnStoryExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnStoryExit1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
