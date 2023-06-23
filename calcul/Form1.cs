using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calcul

{
    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                textBox1.Clear();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }


        

        private void button19_Click(object sender, EventArgs e)
        {
            char[] signs = { '+', '-', '*', '/' };
            string[] numbers = textBox1.Text.Split(signs);
            double number1 = Double.Parse(numbers[0]);
            double number2 = Double.Parse(numbers[1]);
            char sign = '+';
            foreach (char item in signs)
            {
                if (textBox1.Text.IndexOf(item) >= 0)
                {
                    sign = item;
                    break;
                }
            }
            switch (sign)
            {
                case '+':
                    textBox1.Text = (number1 + number2).ToString();
                    break;
                case '-':
                    textBox1.Text = (number1 - number2).ToString();
                    break;
                case '*':
                    textBox1.Text = (number1 * number2).ToString();
                    break;
                case '/':
                    textBox1.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Contains(',') ? textBox1.Text : textBox1.Text + ',';

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            if (textBox1.Text[0] == '-') textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
