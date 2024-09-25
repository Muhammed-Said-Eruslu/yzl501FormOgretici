namespace _01_WF_Intro
{
    partial class Form2
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
            lblKa = new Label();
            lblSıfre = new Label();
            txtKA = new TextBox();
            txtSIFRE = new TextBox();
            btnKullanıcıGirişi = new Button();
            lblBılgı = new Label();
            SuspendLayout();
            // 
            // lblKa
            // 
            lblKa.AutoSize = true;
            lblKa.Location = new Point(31, 59);
            lblKa.Name = "lblKa";
            lblKa.Size = new Size(73, 15);
            lblKa.TabIndex = 0;
            lblKa.Text = "Kullanıcı Adı";
            // 
            // lblSıfre
            // 
            lblSıfre.AutoSize = true;
            lblSıfre.Location = new Point(50, 107);
            lblSıfre.Name = "lblSıfre";
            lblSıfre.Size = new Size(30, 15);
            lblSıfre.TabIndex = 1;
            lblSıfre.Text = "Şifre";
            // 
            // txtKA
            // 
            txtKA.Location = new Point(130, 56);
            txtKA.Name = "txtKA";
            txtKA.PlaceholderText = "Kullanıcı Adı";
            txtKA.Size = new Size(100, 23);
            txtKA.TabIndex = 2;
            // 
            // txtSIFRE
            // 
            txtSIFRE.Location = new Point(130, 99);
            txtSIFRE.Name = "txtSIFRE";
            txtSIFRE.PasswordChar = '*';
            txtSIFRE.PlaceholderText = "Şifre";
            txtSIFRE.Size = new Size(100, 23);
            txtSIFRE.TabIndex = 3;
            // 
            // btnKullanıcıGirişi
            // 
            btnKullanıcıGirişi.Location = new Point(276, 74);
            btnKullanıcıGirişi.Name = "btnKullanıcıGirişi";
            btnKullanıcıGirişi.Size = new Size(99, 23);
            btnKullanıcıGirişi.TabIndex = 4;
            btnKullanıcıGirişi.Text = "Kullanıcı Girişi";
            btnKullanıcıGirişi.UseVisualStyleBackColor = true;
            btnKullanıcıGirişi.Click += button1_Click;
            // 
            // lblBılgı
            // 
            lblBılgı.AutoSize = true;
            lblBılgı.ForeColor = Color.IndianRed;
            lblBılgı.Location = new Point(50, 160);
            lblBılgı.Name = "lblBılgı";
            lblBılgı.Size = new Size(38, 15);
            lblBılgı.TabIndex = 5;
            lblBılgı.Text = "label1";
            lblBılgı.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 203);
            Controls.Add(lblBılgı);
            Controls.Add(btnKullanıcıGirişi);
            Controls.Add(txtSIFRE);
            Controls.Add(txtKA);
            Controls.Add(lblSıfre);
            Controls.Add(lblKa);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKa;
        private Label lblSıfre;
        private TextBox txtKA;
        private TextBox txtSIFRE;
        private Button btnKullanıcıGirişi;
        private Label lblBılgı;
    }
}