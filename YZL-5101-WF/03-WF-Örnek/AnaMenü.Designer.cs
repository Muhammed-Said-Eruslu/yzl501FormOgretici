namespace _03_WF_Örnek
{
    partial class AnaMenü
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
            lblPersonelBilgileri = new Label();
            lblAD = new Label();
            lblSoyAd = new Label();
            lblTCKNO = new Label();
            txtAd = new TextBox();
            txtTCKNO = new TextBox();
            txtSoyad = new TextBox();
            lblDepratman = new Label();
            comboDepartman = new ComboBox();
            radioErkek = new RadioButton();
            radioKadin = new RadioButton();
            clbHobiler = new CheckedListBox();
            lstPersonelBilgileri = new ListBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lblPersonelBilgileri
            // 
            lblPersonelBilgileri.AutoSize = true;
            lblPersonelBilgileri.Location = new Point(12, 29);
            lblPersonelBilgileri.Name = "lblPersonelBilgileri";
            lblPersonelBilgileri.Size = new Size(94, 15);
            lblPersonelBilgileri.TabIndex = 0;
            lblPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // lblAD
            // 
            lblAD.AutoSize = true;
            lblAD.Location = new Point(3, 75);
            lblAD.Name = "lblAD";
            lblAD.Size = new Size(28, 15);
            lblAD.TabIndex = 1;
            lblAD.Text = "Adı ";
            // 
            // lblSoyAd
            // 
            lblSoyAd.AutoSize = true;
            lblSoyAd.Location = new Point(3, 131);
            lblSoyAd.Name = "lblSoyAd";
            lblSoyAd.Size = new Size(47, 15);
            lblSoyAd.TabIndex = 2;
            lblSoyAd.Text = "Soy Adı";
            // 
            // lblTCKNO
            // 
            lblTCKNO.AutoSize = true;
            lblTCKNO.Location = new Point(3, 189);
            lblTCKNO.Name = "lblTCKNO";
            lblTCKNO.Size = new Size(45, 15);
            lblTCKNO.TabIndex = 3;
            lblTCKNO.Text = "TCKNO";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.SeaShell;
            txtAd.Location = new Point(56, 72);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 1;
            // 
            // txtTCKNO
            // 
            txtTCKNO.BackColor = Color.SeaShell;
            txtTCKNO.Location = new Point(56, 186);
            txtTCKNO.Name = "txtTCKNO";
            txtTCKNO.Size = new Size(100, 23);
            txtTCKNO.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.SeaShell;
            txtSoyad.Location = new Point(56, 128);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 2;
            // 
            // lblDepratman
            // 
            lblDepratman.AutoSize = true;
            lblDepratman.Location = new Point(-1, 239);
            lblDepratman.Name = "lblDepratman";
            lblDepratman.Size = new Size(66, 15);
            lblDepratman.TabIndex = 7;
            lblDepratman.Text = "Departman";
            // 
            // comboDepartman
            // 
            comboDepartman.BackColor = Color.SeaShell;
            comboDepartman.FormattingEnabled = true;
            comboDepartman.Location = new Point(71, 239);
            comboDepartman.Name = "comboDepartman";
            comboDepartman.Size = new Size(121, 23);
            comboDepartman.TabIndex = 4;
            // 
            // radioErkek
            // 
            radioErkek.AutoSize = true;
            radioErkek.ForeColor = Color.Firebrick;
            radioErkek.Location = new Point(12, 296);
            radioErkek.Name = "radioErkek";
            radioErkek.Size = new Size(53, 19);
            radioErkek.TabIndex = 5;
            radioErkek.TabStop = true;
            radioErkek.Text = "Erkek";
            radioErkek.UseVisualStyleBackColor = true;
            // 
            // radioKadin
            // 
            radioKadin.AutoSize = true;
            radioKadin.ForeColor = Color.Firebrick;
            radioKadin.Location = new Point(85, 296);
            radioKadin.Name = "radioKadin";
            radioKadin.Size = new Size(55, 19);
            radioKadin.TabIndex = 6;
            radioKadin.TabStop = true;
            radioKadin.Text = "Kadın";
            radioKadin.UseVisualStyleBackColor = true;
            // 
            // clbHobiler
            // 
            clbHobiler.BackColor = Color.LightSkyBlue;
            clbHobiler.ForeColor = Color.Firebrick;
            clbHobiler.FormattingEnabled = true;
            clbHobiler.Items.AddRange(new object[] { "Futbol", "Müzik Dinlemek", "Yürüyüş", "Yüzmek", "Kitap Okumak" });
            clbHobiler.Location = new Point(12, 335);
            clbHobiler.Name = "clbHobiler";
            clbHobiler.Size = new Size(120, 94);
            clbHobiler.TabIndex = 7;
            // 
            // lstPersonelBilgileri
            // 
            lstPersonelBilgileri.BackColor = Color.LightSkyBlue;
            lstPersonelBilgileri.FormattingEnabled = true;
            lstPersonelBilgileri.HorizontalScrollbar = true;
            lstPersonelBilgileri.ItemHeight = 15;
            lstPersonelBilgileri.Location = new Point(344, 12);
            lstPersonelBilgileri.Name = "lstPersonelBilgileri";
            lstPersonelBilgileri.Size = new Size(337, 379);
            lstPersonelBilgileri.TabIndex = 8;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.LightSteelBlue;
            btnKaydet.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnKaydet.ForeColor = Color.Red;
            btnKaydet.Location = new Point(448, 409);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(113, 29);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // AnaMenü
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(lstPersonelBilgileri);
            Controls.Add(clbHobiler);
            Controls.Add(radioKadin);
            Controls.Add(radioErkek);
            Controls.Add(comboDepartman);
            Controls.Add(lblDepratman);
            Controls.Add(txtSoyad);
            Controls.Add(txtTCKNO);
            Controls.Add(txtAd);
            Controls.Add(lblTCKNO);
            Controls.Add(lblSoyAd);
            Controls.Add(lblAD);
            Controls.Add(lblPersonelBilgileri);
            Name = "AnaMenü";
            Text = "AnaMenü";
            Load += AnaMenü_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPersonelBilgileri;
        private Label lblAD;
        private Label lblSoyAd;
        private Label lblTCKNO;
        private TextBox txtAd;
        private TextBox txtTCKNO;
        private TextBox txtSoyad;
        private Label lblDepratman;
        private ComboBox comboDepartman;
        private RadioButton radioErkek;
        private RadioButton radioKadin;
        private CheckedListBox clbHobiler;
        private ListBox lstPersonelBilgileri;
        private Button btnKaydet;
    }
}