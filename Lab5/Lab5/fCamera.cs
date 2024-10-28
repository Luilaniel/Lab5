using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class fCamera : Form
    {
        public fCamera(Camera t)
        {
            TheCamera = t;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void fCamera_Load(object sender, EventArgs e)
        {
            if(TheCamera != null)
            {
                tbBrand.Text = TheCamera.Brand;
                tbModel.Text = TheCamera.Model;
                tbCountry.Text = TheCamera.CountryOfOrigin;
                tbSensorType.Text = TheCamera.SensorType;
                tbSensorResolution.Text = TheCamera.SensorResolution.ToString();
                tbLensType.Text = TheCamera.LensType;
                tbVideoFormat.Text = TheCamera.VideoFormat;
                hasWeatheSealing.Checked = TheCamera.WeatherSealing;
            }
        }

        public Camera TheCamera;

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheCamera.Brand = tbBrand.Text.Trim();
            TheCamera.Model = tbModel.Text.Trim();
            TheCamera.CountryOfOrigin = tbCountry.Text.Trim();
            TheCamera.SensorType = tbSensorType.Text.Trim();
            TheCamera.SensorResolution = int.Parse(tbSensorResolution.Text.Trim());
            TheCamera.LensType = tbLensType.Text.Trim();
            TheCamera.VideoFormat = tbVideoFormat.Text.Trim();
            TheCamera.WeatherSealing = hasWeatheSealing.Checked;
            
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
