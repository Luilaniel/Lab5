namespace Lab5
{
    partial class fCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tbVideoFormat = new TextBox();
            tbLensType = new TextBox();
            tbSensorResolution = new TextBox();
            tbSensorType = new TextBox();
            tbCountry = new TextBox();
            tbModel = new TextBox();
            tbBrand = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            hasWeatheSealing = new CheckBox();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbVideoFormat);
            groupBox1.Controls.Add(tbLensType);
            groupBox1.Controls.Add(tbSensorResolution);
            groupBox1.Controls.Add(tbSensorType);
            groupBox1.Controls.Add(tbCountry);
            groupBox1.Controls.Add(tbModel);
            groupBox1.Controls.Add(tbBrand);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Загальні дані";
            // 
            // tbVideoFormat
            // 
            tbVideoFormat.Location = new Point(240, 242);
            tbVideoFormat.Name = "tbVideoFormat";
            tbVideoFormat.Size = new Size(125, 27);
            tbVideoFormat.TabIndex = 13;
            // 
            // tbLensType
            // 
            tbLensType.Location = new Point(240, 209);
            tbLensType.Name = "tbLensType";
            tbLensType.Size = new Size(125, 27);
            tbLensType.TabIndex = 12;
            // 
            // tbSensorResolution
            // 
            tbSensorResolution.Location = new Point(240, 176);
            tbSensorResolution.Name = "tbSensorResolution";
            tbSensorResolution.Size = new Size(125, 27);
            tbSensorResolution.TabIndex = 11;
            // 
            // tbSensorType
            // 
            tbSensorType.Location = new Point(240, 143);
            tbSensorType.Name = "tbSensorType";
            tbSensorType.Size = new Size(125, 27);
            tbSensorType.TabIndex = 10;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(240, 110);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 9;
            tbCountry.TextChanged += textBox3_TextChanged;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(240, 77);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(125, 27);
            tbModel.TabIndex = 8;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(240, 42);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(125, 27);
            tbBrand.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 245);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 6;
            label7.Text = "Формат відео";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 212);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "Тип лінзи";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 179);
            label5.Name = "label5";
            label5.Size = new Size(205, 20);
            label5.TabIndex = 4;
            label5.Text = "Роздільна здатність сенсору";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 146);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Тип сенсору";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 113);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Країна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Модель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Бренд";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hasWeatheSealing);
            groupBox2.Location = new Point(12, 326);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 112);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Додаткові дані";
            // 
            // hasWeatheSealing
            // 
            hasWeatheSealing.AutoSize = true;
            hasWeatheSealing.Location = new Point(20, 50);
            hasWeatheSealing.Name = "hasWeatheSealing";
            hasWeatheSealing.Size = new Size(279, 24);
            hasWeatheSealing.TabIndex = 0;
            hasWeatheSealing.Text = "Камера має захист від води та пилу";
            hasWeatheSealing.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(397, 57);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(397, 92);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fCamera
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(501, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "fCamera";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Дані про нову камеру";
            Load += fCamera_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbVideoFormat;
        private TextBox tbLensType;
        private TextBox tbSensorResolution;
        private TextBox tbSensorType;
        private TextBox tbCountry;
        private TextBox tbModel;
        private TextBox tbBrand;
        private GroupBox groupBox2;
        private CheckBox hasWeatheSealing;
        private Button btnOk;
        private Button btnCancel;
    }
}