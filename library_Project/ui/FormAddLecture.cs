using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library_Project.adapter;

namespace library_Project.ui {
    partial class FormAddLecture : MetroFramework.Forms.MetroForm {

        int n = 1;
        BaseAdapter ba;
        
        public FormAddLecture(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            dateTimePickerSetting();
            

        }

        //dateTimePicker 설정
        public void dateTimePickerSetting() {

            PickerStartDay.Format = DateTimePickerFormat.Custom;
            PickerStartDay.CustomFormat = "yy-MM-dd";

            PickerEndDay.Format = DateTimePickerFormat.Custom;
            PickerEndDay.CustomFormat = "yy-MM-dd";

            PickerStartTime.Format = DateTimePickerFormat.Custom;
            PickerStartTime.ShowUpDown = true;
            PickerStartTime.CustomFormat = "HH:mm";

            PickerEndTime.Format = DateTimePickerFormat.Custom;
            PickerEndTime.ShowUpDown = true;
            PickerEndTime.CustomFormat = "HH:mm";
        }

        //번호 자동부여
        public string LectNum(int n) {

            string lNum = "L" + n.ToString("000.");
            Console.WriteLine(lNum);

            return lNum;
        }

    }
}
