
namespace _03_WF_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Login işlemi yapılcak Admin ve şifre alıcak "Admin" ve "123" ise personel giriş
            // sayfasına yonelecek // Personel Bilgileri : Adı,Soyadı,TCKNO,Departmanı (5-10),Cinsiyet, Hobleri ibren fazla seçebilir // ekleme yaparken alanların boş geçilmemesine dikkat edin
            // Listbox verileri yaz
            // Kaydedilinci tüm alanları default değerlerine getir
            Login("Admin", "123");

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

        private void btnGönder_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtboxSifre.Text))
            {
                lblBılgı.Visible = true;
                lblBılgı.Text = "Şifre Boş Bırakılamaz";
                return;
            }


            if (string.IsNullOrEmpty(txtKullanıcıAdı.Text))
            {
                lblBılgı.Visible = true;
                lblBılgı.Text = "Kullanıcı Adı Boş Geçilemez";
                return;
            }


            bool result = Login(txtKullanıcıAdı.Text, txtboxSifre.Text);
            if (result)
            {

                AnaMenü anaMenü = new AnaMenü();
                anaMenü.Show();
                this.Hide();
            }
        }
    }
}
