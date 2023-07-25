namespace Zoo
{
    partial class MainForm
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
            lsTigers = new ListBox();
            btnGetDummyD = new Button();
            label1 = new Label();
            lsEagles = new ListBox();
            label2 = new Label();
            lbName = new Label();
            label3 = new Label();
            label4 = new Label();
            lbAddress = new Label();
            label5 = new Label();
            label6 = new Label();
            lbTName = new Label();
            lbTWeight = new Label();
            gvInfo = new DataGridView();
            gvEagles = new DataGridView();
            panel1 = new Panel();
            btnTAdd = new Button();
            cbTAnimalType = new ComboBox();
            cbTColor = new ComboBox();
            txtTSpeed = new TextBox();
            nmTCrateSize = new NumericUpDown();
            cbTEnhabitat = new ComboBox();
            txtTNailLength = new TextBox();
            nmTAge = new NumericUpDown();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            cbTSex = new ComboBox();
            label9 = new Label();
            nmTStriper = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            nmTWeight = new NumericUpDown();
            txtTName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvEagles).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmTCrateSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmTAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmTStriper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmTWeight).BeginInit();
            SuspendLayout();
            // 
            // lsTigers
            // 
            lsTigers.FormattingEnabled = true;
            lsTigers.ItemHeight = 15;
            lsTigers.Location = new Point(7, 135);
            lsTigers.Name = "lsTigers";
            lsTigers.Size = new Size(120, 214);
            lsTigers.TabIndex = 0;
            lsTigers.SelectedIndexChanged += lsTigers_SelectedIndexChanged;
            // 
            // btnGetDummyD
            // 
            btnGetDummyD.Location = new Point(8, 12);
            btnGetDummyD.Name = "btnGetDummyD";
            btnGetDummyD.Size = new Size(170, 39);
            btnGetDummyD.TabIndex = 1;
            btnGetDummyD.Text = "Load Dummy Data";
            btnGetDummyD.UseVisualStyleBackColor = true;
            btnGetDummyD.Click += btnGetDummyD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 117);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Tigers:";
            // 
            // lsEagles
            // 
            lsEagles.FormattingEnabled = true;
            lsEagles.ItemHeight = 15;
            lsEagles.Location = new Point(133, 135);
            lsEagles.Name = "lsEagles";
            lsEagles.Size = new Size(125, 214);
            lsEagles.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 117);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Eagles";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(251, 12);
            lbName.Name = "lbName";
            lbName.Size = new Size(0, 15);
            lbName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 12);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 36);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Address: ";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(258, 37);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(0, 15);
            lbAddress.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 56);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 84);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 10;
            label6.Text = "Weight:";
            // 
            // lbTName
            // 
            lbTName.AutoSize = true;
            lbTName.Location = new Point(55, 56);
            lbTName.Name = "lbTName";
            lbTName.Size = new Size(0, 15);
            lbTName.TabIndex = 11;
            // 
            // lbTWeight
            // 
            lbTWeight.AutoSize = true;
            lbTWeight.Location = new Point(61, 84);
            lbTWeight.Name = "lbTWeight";
            lbTWeight.Size = new Size(0, 15);
            lbTWeight.TabIndex = 12;
            // 
            // gvInfo
            // 
            gvInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInfo.Location = new Point(7, 392);
            gvInfo.Name = "gvInfo";
            gvInfo.RowTemplate.Height = 25;
            gvInfo.Size = new Size(1014, 128);
            gvInfo.TabIndex = 13;
            // 
            // gvEagles
            // 
            gvEagles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gvEagles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvEagles.Location = new Point(9, 527);
            gvEagles.Name = "gvEagles";
            gvEagles.RowTemplate.Height = 25;
            gvEagles.Size = new Size(1012, 150);
            gvEagles.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTAdd);
            panel1.Controls.Add(cbTAnimalType);
            panel1.Controls.Add(cbTColor);
            panel1.Controls.Add(txtTSpeed);
            panel1.Controls.Add(nmTCrateSize);
            panel1.Controls.Add(cbTEnhabitat);
            panel1.Controls.Add(txtTNailLength);
            panel1.Controls.Add(nmTAge);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbTSex);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(nmTStriper);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(nmTWeight);
            panel1.Controls.Add(txtTName);
            panel1.Location = new Point(796, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 370);
            panel1.TabIndex = 15;
            // 
            // btnTAdd
            // 
            btnTAdd.Location = new Point(44, 328);
            btnTAdd.Name = "btnTAdd";
            btnTAdd.Size = new Size(163, 39);
            btnTAdd.TabIndex = 27;
            btnTAdd.Text = "Add Tiger";
            btnTAdd.UseVisualStyleBackColor = true;
            btnTAdd.Click += btnTAdd_Click;
            // 
            // cbTAnimalType
            // 
            cbTAnimalType.FormattingEnabled = true;
            cbTAnimalType.Location = new Point(86, 183);
            cbTAnimalType.Name = "cbTAnimalType";
            cbTAnimalType.Size = new Size(121, 23);
            cbTAnimalType.TabIndex = 26;
            // 
            // cbTColor
            // 
            cbTColor.FormattingEnabled = true;
            cbTColor.Location = new Point(86, 299);
            cbTColor.Name = "cbTColor";
            cbTColor.Size = new Size(121, 23);
            cbTColor.TabIndex = 25;
            // 
            // txtTSpeed
            // 
            txtTSpeed.Location = new Point(86, 270);
            txtTSpeed.Name = "txtTSpeed";
            txtTSpeed.Size = new Size(121, 23);
            txtTSpeed.TabIndex = 24;
            // 
            // nmTCrateSize
            // 
            nmTCrateSize.Location = new Point(86, 154);
            nmTCrateSize.Name = "nmTCrateSize";
            nmTCrateSize.Size = new Size(121, 23);
            nmTCrateSize.TabIndex = 23;
            // 
            // cbTEnhabitat
            // 
            cbTEnhabitat.FormattingEnabled = true;
            cbTEnhabitat.Location = new Point(86, 212);
            cbTEnhabitat.Name = "cbTEnhabitat";
            cbTEnhabitat.Size = new Size(121, 23);
            cbTEnhabitat.TabIndex = 18;
            // 
            // txtTNailLength
            // 
            txtTNailLength.Location = new Point(86, 125);
            txtTNailLength.Name = "txtTNailLength";
            txtTNailLength.Size = new Size(121, 23);
            txtTNailLength.TabIndex = 16;
            // 
            // nmTAge
            // 
            nmTAge.Location = new Point(86, 96);
            nmTAge.Name = "nmTAge";
            nmTAge.Size = new Size(121, 23);
            nmTAge.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(39, 75);
            label17.Name = "label17";
            label17.Size = new Size(41, 15);
            label17.TabIndex = 14;
            label17.Text = "Striper";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(52, 104);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 13;
            label16.Text = "Age";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 133);
            label15.Name = "label15";
            label15.Size = new Size(68, 15);
            label15.TabIndex = 12;
            label15.Text = "Nail Length";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 162);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 11;
            label14.Text = "Crate Size";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 191);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 10;
            label13.Text = "Animal Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 220);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 9;
            label12.Text = "Enhabitat";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 249);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 8;
            label11.Text = "Sex";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 278);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 7;
            label10.Text = "Speed";
            // 
            // cbTSex
            // 
            cbTSex.FormattingEnabled = true;
            cbTSex.Location = new Point(86, 241);
            cbTSex.Name = "cbTSex";
            cbTSex.Size = new Size(121, 23);
            cbTSex.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 307);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 6;
            label9.Text = "Color";
            // 
            // nmTStriper
            // 
            nmTStriper.Location = new Point(86, 67);
            nmTStriper.Name = "nmTStriper";
            nmTStriper.Size = new Size(121, 23);
            nmTStriper.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 46);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 3;
            label8.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 17);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 2;
            label7.Text = "Name:";
            // 
            // nmTWeight
            // 
            nmTWeight.Location = new Point(86, 38);
            nmTWeight.Name = "nmTWeight";
            nmTWeight.Size = new Size(121, 23);
            nmTWeight.TabIndex = 1;
            // 
            // txtTName
            // 
            txtTName.Location = new Point(86, 9);
            txtTName.Name = "txtTName";
            txtTName.Size = new Size(121, 23);
            txtTName.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 759);
            Controls.Add(panel1);
            Controls.Add(gvEagles);
            Controls.Add(gvInfo);
            Controls.Add(lbTWeight);
            Controls.Add(lbTName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbName);
            Controls.Add(label2);
            Controls.Add(lsEagles);
            Controls.Add(label1);
            Controls.Add(btnGetDummyD);
            Controls.Add(lsTigers);
            Name = "MainForm";
            Text = "Zoo";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)gvInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvEagles).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmTCrateSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmTAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmTStriper).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmTWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsTigers;
        private Button btnGetDummyD;
        private Label label1;
        private ListBox lsEagles;
        private Label label2;
        private Label lbName;
        private Label label3;
        private Label label4;
        private Label lbAddress;
        private Label label5;
        private Label label6;
        private Label lbTName;
        private Label lbTWeight;
        private DataGridView gvInfo;
        private DataGridView gvEagles;
        private Panel panel1;
        private TextBox txtTName;
        private NumericUpDown nmTWeight;
        private Label label8;
        private Label label7;
        private ComboBox cbTSex;
        private Button btnAdd;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private ComboBox cbTEnhabitat;
        private NumericUpDown numericUpDown4;
        private TextBox txtTNailLength;
        private NumericUpDown nmTAge;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private NumericUpDown nmTStriper;
        private NumericUpDown nmTCrateSize;
        private ComboBox cbTColor;
        private TextBox txtTSpeed;
        private ComboBox cbTAnimalType;
        private Button btnTAdd;
    }
}