using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_WF_Örnek
{
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

           
                if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtTCKNO.Text) || comboDepartman.SelectedIndex == -1 || (!radioErkek.Checked && !radioKadin.Checked))
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun");
                    return;
                }
                

            
                string cinsiyet = radioErkek.Checked ? "Erkek" : "Kadın"; // radıo butonu kontrol et


                string hobiler = "";
                foreach (var item in clbHobiler.CheckedItems)
                {
                    hobiler += item.ToString();
                }


                string personelBilgileri = $"Ad: {txtAd.Text}, Soyad: {txtSoyad.Text}, TCKNO: {txtTCKNO.Text}, Departmanı: {comboDepartman.SelectedItem.ToString()}, Cinsiyeti: {cinsiyet}, Hobileri: {hobiler}";


                lstPersonelBilgileri.Items.Add(personelBilgileri);


                txtAd.Clear();
                txtSoyad.Clear();
                txtTCKNO.Clear();
                comboDepartman.SelectedIndex = -1;
                radioErkek.Checked = false;
                radioKadin.Checked = false;

                for (int i = 0; i < clbHobiler.Items.Count; i++)
                {
                    clbHobiler.SetItemChecked(i, false);
                }
            }
        

        private void AnaMenü_Load(object sender, EventArgs e)
        {
            // ana menü yüklenince bunları combo boxe ekle
            comboDepartman.Items.Add("Muhasebe");
            comboDepartman.Items.Add("İnsan Kaynakları");
            comboDepartman.Items.Add("Bilgi Teknojileri");
            comboDepartman.Items.Add("Şatış");
            comboDepartman.Items.Add("Pazarlama");
            comboDepartman.Items.Add("Üretim");
            comboDepartman.Items.Add("Lojistik");
            comboDepartman.Items.Add("AR-GE");
            comboDepartman.Items.Add("Hukuk");
            comboDepartman.Items.Add("Müşteri Hizmetleri");

        }
    }
}

