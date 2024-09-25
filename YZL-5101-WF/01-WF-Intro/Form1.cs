namespace _01_WF_Intro
{
    public partial class Form1 : Form // form1 den miras alm?? 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Abdest Alindi!";
            textBox1.Visible = !textBox1.Visible;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abdestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
