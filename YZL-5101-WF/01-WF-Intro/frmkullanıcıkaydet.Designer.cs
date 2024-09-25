namespace _01_WF_Intro
{
    partial class _1frmKullanıcıKaydet
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            rdrbtnKadın = new RadioButton();
            rdrbtnErkek = new RadioButton();
            lblCinsiyet = new Label();
            nudYaş = new NumericUpDown();
            lblYaş = new Label();
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            groupBox2 = new GroupBox();
            txtAçıkAdres = new TextBox();
            lblAcıkAdres = new Label();
            btnKaydet = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            checkBoxOnay = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            txtliseAdı = new TextBox();
            tabPage2 = new TabPage();
            label2 = new Label();
            comboUniversite = new ComboBox();
            tabPage3 = new TabPage();
            comboBoxMaster = new ComboBox();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYaş).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdrbtnKadın);
            groupBox1.Controls.Add(rdrbtnErkek);
            groupBox1.Controls.Add(lblCinsiyet);
            groupBox1.Controls.Add(nudYaş);
            groupBox1.Controls.Add(lblYaş);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            // 
            // rdrbtnKadın
            // 
            rdrbtnKadın.AutoSize = true;
            rdrbtnKadın.Location = new Point(139, 112);
            rdrbtnKadın.Name = "rdrbtnKadın";
            rdrbtnKadın.Size = new Size(55, 19);
            rdrbtnKadın.TabIndex = 5;
            rdrbtnKadın.TabStop = true;
            rdrbtnKadın.Text = "Kadın";
            rdrbtnKadın.UseVisualStyleBackColor = true;
            // 
            // rdrbtnErkek
            // 
            rdrbtnErkek.AutoSize = true;
            rdrbtnErkek.Location = new Point(74, 112);
            rdrbtnErkek.Name = "rdrbtnErkek";
            rdrbtnErkek.Size = new Size(53, 19);
            rdrbtnErkek.TabIndex = 5;
            rdrbtnErkek.TabStop = true;
            rdrbtnErkek.Text = "Erkek";
            rdrbtnErkek.UseVisualStyleBackColor = true;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(6, 114);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(52, 15);
            lblCinsiyet.TabIndex = 4;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // nudYaş
            // 
            nudYaş.Location = new Point(74, 74);
            nudYaş.Name = "nudYaş";
            nudYaş.Size = new Size(120, 23);
            nudYaş.TabIndex = 3;
            nudYaş.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // lblYaş
            // 
            lblYaş.AutoSize = true;
            lblYaş.Location = new Point(6, 76);
            lblYaş.Name = "lblYaş";
            lblYaş.Size = new Size(27, 15);
            lblYaş.TabIndex = 2;
            lblYaş.Text = "Yaş:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(6, 38);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(66, 15);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "Adı Soyadı:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(74, 35);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(148, 23);
            txtAdSoyad.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAçıkAdres);
            groupBox2.Controls.Add(lblAcıkAdres);
            groupBox2.Location = new Point(1, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 163);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adres Bilgileri";
            // 
            // txtAçıkAdres
            // 
            txtAçıkAdres.Location = new Point(81, 35);
            txtAçıkAdres.Multiline = true;
            txtAçıkAdres.Name = "txtAçıkAdres";
            txtAçıkAdres.Size = new Size(168, 89);
            txtAçıkAdres.TabIndex = 1;
            // 
            // lblAcıkAdres
            // 
            lblAcıkAdres.AutoSize = true;
            lblAcıkAdres.Location = new Point(6, 38);
            lblAcıkAdres.Name = "lblAcıkAdres";
            lblAcıkAdres.Size = new Size(69, 15);
            lblAcıkAdres.TabIndex = 0;
            lblAcıkAdres.Text = "Açık Adres :";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MistyRose;
            btnKaydet.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKaydet.Location = new Point(57, 504);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(153, 44);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(329, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 417);
            panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 394);
            listBox1.TabIndex = 0;
            // 
            // checkBoxOnay
            // 
            checkBoxOnay.AutoSize = true;
            checkBoxOnay.Location = new Point(12, 465);
            checkBoxOnay.Name = "checkBoxOnay";
            checkBoxOnay.Size = new Size(298, 19);
            checkBoxOnay.TabIndex = 5;
            checkBoxOnay.Text = "Yukarida ki Bilgilerin Doğru Olduğunu Onaylıyorum";
            checkBoxOnay.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 322);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(250, 130);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(128, 64, 64);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtliseAdı);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(242, 102);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lise";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Lise Adı Giriniz";
            // 
            // txtliseAdı
            // 
            txtliseAdı.Location = new Point(107, 37);
            txtliseAdı.Name = "txtliseAdı";
            txtliseAdı.Size = new Size(100, 23);
            txtliseAdı.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(128, 64, 64);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(comboUniversite);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 102);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Üniversite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 40);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Üniversite Adı";
            // 
            // comboUniversite
            // 
            comboUniversite.FormattingEnabled = true;
            comboUniversite.Items.AddRange(new object[] { "Boğaziçi  Üniversitei", "İTÜ ", "ÖDTÜ" });
            comboUniversite.Location = new Point(113, 37);
            comboUniversite.Name = "comboUniversite";
            comboUniversite.Size = new Size(121, 23);
            comboUniversite.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(128, 64, 64);
            tabPage3.Controls.Add(comboBoxMaster);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(242, 102);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Master";
            // 
            // comboBoxMaster
            // 
            comboBoxMaster.FormattingEnabled = true;
            comboBoxMaster.Location = new Point(98, 37);
            comboBoxMaster.Name = "comboBoxMaster";
            comboBoxMaster.Size = new Size(121, 23);
            comboBoxMaster.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 40);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 0;
            label3.Text = "Master Seçiniz";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // _1frmKullanıcıKaydet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 571);
            Controls.Add(tabControl1);
            Controls.Add(checkBoxOnay);
            Controls.Add(panel1);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "_1frmKullanıcıKaydet";
            Text = "_1frmKullanıcıKaydet";
            Load += _1frmKullanıcıKaydet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYaş).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nudYaş;
        private Label lblYaş;
        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private RadioButton rdrbtnKadın;
        private RadioButton rdrbtnErkek;
        private Label lblCinsiyet;
        private GroupBox groupBox2;
        private TextBox txtAçıkAdres;
        private Label lblAcıkAdres;
        private Button btnKaydet;
        private Panel panel1;
        private ListBox listBox1;
        private CheckBox checkBoxOnay;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txtliseAdı;
        private Label label2;
        private ComboBox comboUniversite;
        private TabPage tabPage3;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBoxMaster;
        private Label label3;
    }
}