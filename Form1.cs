namespace C___Individual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sortare form1 = new Sortare();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cautare form2 = new Cautare();
            form2.Show();
        }
    }
}