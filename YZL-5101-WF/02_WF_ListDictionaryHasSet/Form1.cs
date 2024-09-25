using System.Collections;

namespace _02_WF_ListDictionaryHasSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Collection
            // Diziler : Tip ve Eleman Değeri

            //string[] sehirler = new string[] { "İstanbul", "Afyon", "Ankara" };

            // Listeler : Tip
            // List<string> sehirlerList = new List<string>() { "İstanbul", "Afyon", "Ankara" };

            //sehirlerList.Add("Bursa");
            // sehirlerList.Add("Samsun");
            // sehirlerList.Insert(3, "Kocaeli"); // eklemek

            // sehirlerList.ForEach(x => MessageBox.Show(x)); // Lambda Expression // ifade demek iciçnde ki her bir değer x e atanır

            // ArrayList
            /* Şu zamana kadar gördüğümüz ilkel dizilerin iki ozelliği VERİ TİPİ VE ELEMAN SAYISI zorunluluğu idi.Ancak ArrayList zorunluluklar ortdan kalkmıştır */

            /* Dezavantajı
             * ArrayList içerisndeki elemanları otomatık olarak object veri tipine döndürme özelliğine sahiptir.Dolasıyla bu verileri geri almak istediğimizde cast veya conver işleimne gerek duymaktayız
             
             */
            // Bu da eksta iki kat iş demektir(Boxing,Unboxing)
            // Boxing: Bilinen Tipten => Object
            // Unboxing: object => Boxing // bnunu eğer cıkara bilirsem unboxing olur

            //  ArrayList yeniDizi = new ArrayList() { sehirlerList,sehirler,'F',34};
            //  yeniDizi.Add("Kars");
            // yeniDizi.Add(4);
            //  yeniDizi.Add(true);
            // yeniDizi.Insert(3,"YZL 5101");

            // Diğer Array Sınıfları
            //yeniDizi.Sort();
            // yeniDizi.Remove("Kars");

            // yeniDizi.Clear();

            /*
             Collectıon (Koleksiyon),programlamada veri gruplaranı depolamak ve yönetmek için kullanılan bir terimdir.Verileri bir düzen içerisınde sakalr.Veriler üzerinde
            gruplama, işleme ve yonetme mekanızmalarını kazandırır


            ->IEnumrable: Collectıon tiplerinin en tepesinde bulunur, tüm collecitıon alt yapı sağlar  Foreach için temel alt yapıyı sağlar. (İterasyon) // teker teker eklemek demek

            -> ICollection: Eleman ekleme,silme işlemlerini yönetir
            -> IList: Sıralama işlemlerini yapra
            -> IDictionary : Key-Value (Anahtar-Değer) çifrlerinin depolayan bri koleksıyon

             
             */

            #endregion

            #region Queue
            /*// QUEUE<T> sınıfı, ,lk giren ilk çıkar (FIFO) düzelmiş bir nesneler kolekysiyonudur.Öğeleri belirli bri sırayla işlemek istediğinizde kullanılışlıdır

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Coffee"); // sıranın sonuna bir öğe ekler
            queue.Enqueue("Tea");
            queue.Enqueue("İce Tea");

            MessageBox.Show(queue.Dequeue()); // sıranın başında kı öğeyi kaldırır ve döndürür
            MessageBox.Show(queue.Peek()); // Sıranın başında ki elemanı çıkarmadan döndürür

            */
            #endregion

            #region Stack
            // Stack,son giren ilk çıkar (LIFO) düzeninde düzenlenmiş bir nesneler koleksıyondur
            /* Stack<string> stack = new Stack<string>();
             stack.Push("Home"); // Yığının en üstüne ekliyor
             stack.Push("Contact");
             stack.Push("About");

             stack.Pop(); // Yığın en üstünde ki öğeyi kaldırır ve döndürür 
             stack.Peek(); // Yığının en üstünde ki öğeyi çıkarmadan döndürür
            */

            #endregion

            #region HashSet
            // HashSet belirli bir sırası olmıyan benzersiz bir koleksıyondur öğelerin benzersiz olduğundan emin olmak istediğimiz durumda kullanışlıdır
            /*
            HashSet<string> hashset = new HashSet<string>();

            hashset.Add("Said"); // Halihazırda yoksa HshSete'e bir öğe ekler
            hashset.Add("Muhammed");
            hashset.Add("Eruslu");
            hashset.Add("Muhammed"); // Muhammed koleksiyonda bulunduğu için eklenmedi
            */
            #endregion

            #region Dictionary // sözlük demek
            //Key-Value (Anahtar-Değer) çiftleri ile ilişkilendirmiş bir kolekysıyon türüdür
            // Anahtara dayalı olarak değerin hızlı aranmasını sağlayan bir key-ValeuTask koleksıyondur
            /*
            Dictionary<string,int> personAge = new Dictionary<string,int>();
            personAge.Add("Zafer", 34);
            personAge.Add("Said", 19);
            personAge.Add("Zeynep",21);

            MessageBox.Show(personAge["Said"].ToString());*/

            Dictionary<string,string> dic = new Dictionary<string,string>();

            dic.Add("ı", "i");
            dic.Add("a", "a");
            dic.Add("b", "b");
            dic.Add("c", "c");
            dic.Add("d", "d");
            foreach (KeyValuePair<string, string> item in dic)
            {
                MessageBox.Show(item.Key + " -> " + item.Value);
            }

            #endregion




        }
    }
}
