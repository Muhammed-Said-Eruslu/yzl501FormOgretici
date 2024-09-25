namespace _01_WF_Intro
{
    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {  
            ApplicationConfiguration.Initialize(); // de?er ata in?a et
            Application.Run(new Form2()); // form1 ad?nda nesne üret ve çal??t?r
        }
    }
}