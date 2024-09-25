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
    public partial class _1frmKullanıcıKaydet : Form
    {
        public _1frmKullanıcıKaydet()
        {
            InitializeComponent();
            MasterDoldur();
        }

        private void nudYaş_ValueChanged(object sender, EventArgs e)
        {

        }
        private void MasterDoldur()
        {
            string[] üniversiteler = {"İTÜ","YTÜ","BOUN","ÖDTÜ","İSTÜ","KATÜ" };
            comboBoxMaster.Items.AddRange(üniversiteler);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adı = txtAdSoyad.Text;
            string yas = nudYaş.Value.ToString();
            string cinsiyet = rdrbtnErkek.Checked ? "Erkek" : "Kadın";
            string adres = txtAçıkAdres.Text;
            string liseAdı = txtliseAdı.Text;
            string universiteAdı = (comboUniversite.SelectedIndex != -1) ? comboUniversite.SelectedItem.ToString() : "";

            string bilgi = $"Adı: {adı} Yaşı: {yas} Cinsiyet: {cinsiyet} Adres: {adres} Lise Adı:{liseAdı} Üniversite Adı : {universiteAdı} ";
            
            if(checkBoxOnay.Checked)
            {
                listBox1.Items.Add(bilgi);
            }
            else
            {
                MessageBox.Show("Lütfen Onaylayınız");
            }

            listBox1.Items.Add(bilgi);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void _1frmKullanıcıKaydet_Load(object sender, EventArgs e)
        {

        }
    }
}
