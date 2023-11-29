using System.Data;

namespace exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            BackColor = default(Color);
            textBox1.BackColor = default(Color); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkRed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Isto é uma caixa de texto";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
        }
    }
}