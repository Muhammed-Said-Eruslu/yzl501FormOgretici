namespace _03_WF_Örnek
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtKullanıcıAdı = new TextBox();
            txtboxSifre = new TextBox();
            btnGönder = new Button();
            lblBılgı = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 137);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.BackColor = Color.SeaShell;
            txtKullanıcıAdı.Location = new Point(113, 81);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(100, 23);
            txtKullanıcıAdı.TabIndex = 2;
            // 
            // txtboxSifre
            // 
            txtboxSifre.BackColor = Color.SeaShell;
            txtboxSifre.Location = new Point(113, 137);
            txtboxSifre.Name = "txtboxSifre";
            txtboxSifre.Size = new Size(100, 23);
            txtboxSifre.TabIndex = 3;
            // 
            // btnGönder
            // 
            btnGönder.Location = new Point(270, 105);
            btnGönder.Name = "btnGönder";
            btnGönder.Size = new Size(75, 23);
            btnGönder.TabIndex = 4;
            btnGönder.Text = "Gönder";
            btnGönder.UseVisualStyleBackColor = true;
            btnGönder.Click += btnGönder_Click;
            // 
            // lblBılgı
            // 
            lblBılgı.AutoSize = true;
            lblBılgı.ForeColor = Color.Red;
            lblBılgı.Location = new Point(12, 200);
            lblBılgı.Name = "lblBılgı";
            lblBılgı.Size = new Size(159, 15);
            lblBılgı.TabIndex = 5;
            lblBılgı.Text = "Kullanıcı Adı Veya Şifre Yanlış";
            lblBılgı.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(429, 450);
            Controls.Add(lblBılgı);
            Controls.Add(btnGönder);
            Controls.Add(txtboxSifre);
            Controls.Add(txtKullanıcıAdı);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullanıcıAdı;
        private TextBox txtboxSifre;
        private Button btnGönder;
        private Label lblBılgı;
    }
}
