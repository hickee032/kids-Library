using GMap.NET;
using GMap.NET.MapProviders;
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
    public partial class FormMap : MetroFramework.Forms.MetroForm {

        public FormMap() {
            InitializeComponent();

        }

        private void FormMap_Load(object sender, EventArgs e) {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(37.500772, 127.029685);
            gMapControl1.Zoom = 19;
        }

        private void btnMapExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
