using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WF_Intro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Kullanici Adi Ve Şifre Gonderildi!");

           lblBılgı.Text = string.Empty;
            lblBılgı.Visible = false;

            if(txtSIFRE == null)
            {
                MessageBox.Show("Şifre Boş Birakilamaz");
            }
            if(txtKA.Text == "")
            {
                lblBılgı.Visible = true;
                lblBılgı.Text = "Kullanıcı Adı Boş Geçilemez";
            }
            else if(txtSIFRE.Text == "")
            {
                lblBılgı.Visible = true;
                lblBılgı.Text = "Şifre Kısmı Boş Geçilemez";
            }
            else
            {
                bool result = Login(txtKA.Text, txtSIFRE.Text);

                if(result)
                {
                    _1frmKullanıcıKaydet _1FrmKullanıcıKaydet = new _1frmKullanıcıKaydet(); // _1FrmKullanıcıKaydet  nesnesi oluşturur
                    _1FrmKullanıcıKaydet.Show();  // _1FrmKullanıcıKaydet gosterir
                    this.Hide(); // ilgili formun gizlenmesini sağlar
                }
            }

        }

        private bool Login(string kullanıcıAdı, string sifre)
        {
            if (kullanıcıAdı == "Admin" && sifre == "123")
            {
                return true;
            }
            lblBılgı.Visible = true;
            lblBılgı.Text = "Kullanıcı Adı Veya Şifre Hatalı";

            return false;
        }
    }
}
