using System;
using System.Windows.Forms;

namespace KNU.TOKT.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var expression = textBox1.Text.Replace(" ", string.Empty);
            var result = Calculator.Evaluate(expression);
            label1.Text = result.ToString();
        }
    }
}
