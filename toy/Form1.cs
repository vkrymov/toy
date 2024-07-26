
using System;

namespace toy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string list = "0";

        public int act = 0;

        public string exitAction;

        public int b;
        private void button1_Click(object sender, EventArgs e)
        {
            int one = 1;

            list = textBox1.Text += one.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int two = 2;

            list = textBox1.Text += two.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int three = 3;

            list = textBox1.Text += three.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int four = 4;

            list = textBox1.Text += four.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int five = 5;

            list = textBox1.Text += five.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int six = 6;

            list = textBox1.Text += six.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int seven = 7;

            list = textBox1.Text += seven.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int eight = 8;

            list = textBox1.Text += eight.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int nine = 9;

            list = textBox1.Text += nine.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int zero = 0;

            list = textBox1.Text += zero.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Text = null;
            list = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // действие плюс +
            int act = 1;

            textBox1.Text = null;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // действие минус -
            int act = 2;

            textBox1.Text = null;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            // действие умножить x 
            int act = 3;

            textBox1.Text += null;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // действие разделить %
            int act = 4;

            textBox1.Text += null;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            // действие равно 
            switch (act)
            {
                case 1:
                    exitAction = textBox1.Text = ("плюс!");
                    break;

                case 2:
                    exitAction = textBox1.Text = ("минус!");
                    break;

                case 3:
                    exitAction = textBox1.Text = list;
                    break;

                case 5:
                    exitAction = textBox1.Text = ("разделить!");
                    break;

            }






        }
        
    }
}

