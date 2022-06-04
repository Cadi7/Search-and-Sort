using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C___Individual
{
    public partial class rezultat : Form
    {
        public rezultat()
        {
            InitializeComponent();

            label3.Text = temp.asortare;
            label6.Text = temp.tipsortare;
            label8.Text = temp.tipparcurgere;
            richTextBox1.Text = temp.initial();
            richTextBox1.ReadOnly = true;

            richTextBox2.Text = temp.sortat();
            richTextBox2.ReadOnly = true;
        }

        private void rezultat_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
