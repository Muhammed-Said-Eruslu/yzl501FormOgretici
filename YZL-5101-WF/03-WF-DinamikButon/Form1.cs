using System;

namespace _03_WF_DinamikButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 1; // global tanımlama oldu field
        // btnÜret ismindeki Buton tipindeki nesnenin click eventine tıkladığımda bir metod tetiklenıyor btnÜret_Click Butonuna Click'lendiğinde çalıştırılan metot
        private void btnÜret_Click(object sender, EventArgs e)
        {


            //int sayac = 1; local variable
                // Yapılacak işler buraya yazılır
                // Buton bir sınıftır buton sınıfından örnek cıkara bilirim
                // new Button(); // Buton sınıfndan bir nesne üretiyorum
                // Button sınıfından bir nesne üretmek için new keywordu ile birlikte sınıfın ibr constructor metodunu çağırıyoruz
                // new Console(); // static sınıfların örnekleri üretilemez

                // new MarshalByRefObject(); // Abstract sınıfların ya da interface'lerin instanc'ı olusturulamaz

                // new IList<int>(); Abstract sınıfların ya da interfacelerin instance'ı oluşturulamaz

                Button btn = new Button(); // Bir nesne oluştura bilmek için o sınıfın consturterini cağırmak grekıyor // şimşekler event

                btn.Width = 50;
                btn.Height = 50;
                
                Random random = new Random();
                btn.Text = sayac.ToString();
                sayac++;
                btn.Location = new Point(random.Next(0, ClientSize.Width - btn.Width), random.Next(ClientSize.Height - btn.Height));
                btn.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            btn.Click += Btn_Click; // btn nesnesinin Click event'ine Metot bağladık // cağırma yapmıyoruz atama yapıyoruz
            btn.MouseMove += Btn_MouseMove;
            btn.MouseEnter += Btn_MouseEnter;
            

                this.Controls.Add(btn);

            

        }

        private void Btn_MouseEnter(object? sender, EventArgs e)
        {
           // butonu yakala 
           // butonun lokasyonunu değiştir

           
            
        }

        private void Btn_MouseMove(object? sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            (sender as Button).BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            MessageBox.Show($"Ben {btn.Text}. Yeni Butonum");
        }
    }
}
