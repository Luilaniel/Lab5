namespace Lab5
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            tsSeparator1 = new ToolStripSeparator();
            btnDel = new ToolStripButton();
            btnClear = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnSaveAsText = new ToolStripButton();
            btnSaveAsBinary = new ToolStripButton();
            btnOpenFromText = new ToolStripButton();
            btnOpenFromBinary = new ToolStripButton();
            tsSeparator2 = new ToolStripSeparator();
            btnExit = new ToolStripButton();
            bindSrcCameras = new BindingSource(components);
            gvCameras = new DataGridView();
            saveFileDialog = new SaveFileDialog();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcCameras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCameras).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, tsSeparator1, btnDel, btnClear, toolStripSeparator1, btnSaveAsText, btnSaveAsBinary, btnOpenFromText, btnOpenFromBinary, tsSeparator2, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 24);
            btnAdd.Text = "Додати запис про камеру";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(29, 24);
            btnEdit.Text = "Редагувати запис";
            btnEdit.Click += btnEdit_Click;
            // 
            // tsSeparator1
            // 
            tsSeparator1.Name = "tsSeparator1";
            tsSeparator1.Size = new Size(6, 27);
            // 
            // btnDel
            // 
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageTransparentColor = Color.Magenta;
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(29, 24);
            btnDel.Text = "Видалити запис";
            btnDel.Click += btnDel_Click;
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(29, 24);
            btnClear.Text = "Очистити дані";
            btnClear.Click += btnClear_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnSaveAsText
            // 
            btnSaveAsText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveAsText.Image = (Image)resources.GetObject("btnSaveAsText.Image");
            btnSaveAsText.ImageTransparentColor = Color.Magenta;
            btnSaveAsText.Name = "btnSaveAsText";
            btnSaveAsText.Size = new Size(29, 24);
            btnSaveAsText.Text = "toolStripButton4";
            btnSaveAsText.ToolTipText = "Зберегти у текстовому форматі";
            btnSaveAsText.Click += btnSaveAsText_Click;
            // 
            // btnSaveAsBinary
            // 
            btnSaveAsBinary.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveAsBinary.Image = (Image)resources.GetObject("btnSaveAsBinary.Image");
            btnSaveAsBinary.ImageTransparentColor = Color.Magenta;
            btnSaveAsBinary.Name = "btnSaveAsBinary";
            btnSaveAsBinary.Size = new Size(29, 24);
            btnSaveAsBinary.Text = "toolStripButton2";
            btnSaveAsBinary.TextAlign = ContentAlignment.BottomRight;
            btnSaveAsBinary.ToolTipText = "Зберегти у бінарному форматі";
            btnSaveAsBinary.Click += btnSaveAsBinary_Click;
            // 
            // btnOpenFromText
            // 
            btnOpenFromText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpenFromText.Image = (Image)resources.GetObject("btnOpenFromText.Image");
            btnOpenFromText.ImageTransparentColor = Color.Magenta;
            btnOpenFromText.Name = "btnOpenFromText";
            btnOpenFromText.Size = new Size(29, 24);
            btnOpenFromText.Text = "toolStripButton1";
            btnOpenFromText.ToolTipText = "Зчитати текстові дані";
            btnOpenFromText.Click += btnOpenFromText_Click;
            // 
            // btnOpenFromBinary
            // 
            btnOpenFromBinary.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpenFromBinary.Image = (Image)resources.GetObject("btnOpenFromBinary.Image");
            btnOpenFromBinary.ImageTransparentColor = Color.Magenta;
            btnOpenFromBinary.Name = "btnOpenFromBinary";
            btnOpenFromBinary.Size = new Size(29, 24);
            btnOpenFromBinary.Text = "toolStripButton3";
            btnOpenFromBinary.ToolTipText = "Зчитати бінарні дані";
            btnOpenFromBinary.Click += btnOpenFromBinary_Click;
            // 
            // tsSeparator2
            // 
            tsSeparator2.Name = "tsSeparator2";
            tsSeparator2.Size = new Size(6, 27);
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 24);
            btnExit.Text = "Вийти з програми";
            btnExit.Click += btnExit_Click;
            // 
            // gvCameras
            // 
            gvCameras.AllowUserToAddRows = false;
            gvCameras.AllowUserToDeleteRows = false;
            gvCameras.AutoGenerateColumns = false;
            gvCameras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCameras.DataSource = bindSrcCameras;
            gvCameras.Dock = DockStyle.Fill;
            gvCameras.Location = new Point(0, 27);
            gvCameras.Name = "gvCameras";
            gvCameras.ReadOnly = true;
            gvCameras.RowHeadersWidth = 51;
            gvCameras.Size = new Size(800, 423);
            gvCameras.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvCameras);
            Controls.Add(toolStrip1);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №5";
            Load += fMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcCameras).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvCameras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnEdit;
        private ToolStripSeparator tsSeparator1;
        private ToolStripButton btnDel;
        private ToolStripButton btnClear;
        private ToolStripSeparator tsSeparator2;
        private ToolStripButton btnExit;
        private BindingSource bindSrcCameras;
        private DataGridView gvCameras;
        private ToolStripButton btnOpenFromText;
        private ToolStripButton btnSaveAsBinary;
        private ToolStripButton btnOpenFromBinary;
        private ToolStripButton btnSaveAsText;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAdd;
        private SaveFileDialog saveFileDialog;
    }
}
