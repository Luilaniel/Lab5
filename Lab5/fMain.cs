namespace Lab5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCameras.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Brand";
            column.Name = "Brand";
            gvCameras.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Model";
            gvCameras.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CountryOfOrigin";
            column.Name = "Country";
            gvCameras.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SensorType";
            column.Name = "Sensor type";
            gvCameras.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SensorResolution";
            column.Name = "Sensor resolution";
            gvCameras.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LensType";
            column.Name = "Lens type";
            column.Width = 180;
            gvCameras.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "VideoFormat";
            column.Name = "Video format";
            gvCameras.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "WeatherSealing";
            column.Name = "Weather sealing";
            gvCameras.Columns.Add(column);

            bindSrcCameras.Add(new Camera("Canon", "EOS R5", "Japan", "CMOS", 45, "Interchangeable lens", "8K DCI", true));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();

            fCamera ft = new fCamera(camera);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcCameras.Add(camera);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Camera camera = (Camera)bindSrcCameras.List[bindSrcCameras.Position];

            fCamera ft = new fCamera(camera);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcCameras.List[bindSrcCameras.Position] = camera;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete the current record?", "Delete record",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcCameras.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear the table?\n\nAll data will be lost", "Data cleaning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcCameras.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the application?", "Exit the program",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
