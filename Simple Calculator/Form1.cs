using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Calcu.getSum);


            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            textBox3.Text = delegateAnswer(num1, num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Calcu.getDifference);


            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            textBox3.Text = delegateAnswer(num1, num2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Calcu.getProduct);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            textBox3.Text = delegateAnswer(num1, num2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Calcu.getQuotient);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            textBox3.Text = delegateAnswer(num1, num2).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
