using System;
using System.Windows.Forms;

namespace ContribuinteForm
{
    public partial class Contribuinte : Form
    {
        public Contribuinte()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Contribuinte_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pessoaJuridica.Checked = !pessoaJuridica.Checked;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pessoaFisica.Checked = !pessoaFisica.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
