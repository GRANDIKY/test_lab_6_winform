using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_lab_6_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int quantity = 0;
        private int result = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text) & quantity < 5)
            {
                result += SumDigit(int.Parse(textBox.Text));
                textBox.Text = null;
                quantity++;
            }
            if (quantity == 5)
            {
                resultLabel.Text = "Результат: " + result.ToString();
                quantity = 0;
                result = 0;
            }
        }

        private static int SumDigit(int N)
        {
            int S = 0;
            while (N > 0)
            {
                S += N % 10;
                N /= 10;
            }
            return S;
        }

        
    }
}
