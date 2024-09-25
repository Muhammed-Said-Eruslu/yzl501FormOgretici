namespace _04_WF_RuntimeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniFormEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SayfaForm()
            SayfaForm sayfaForm = new SayfaForm();

            sayfaForm.MdiParent = this; // ana formuma bağlı olsun

            sayfaForm.Show();

            yeniNotEkleToolStripMenuItem.Enabled = true;
        }

        private void yeniNotEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotForm notForm = new NotForm();
            notForm.MdiParent = this;
            notForm.Show();
        }
    }
}
