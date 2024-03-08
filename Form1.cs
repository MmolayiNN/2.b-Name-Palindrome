using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                bool isPalindrome = IsPalindrome(number);
                if (isPalindrome)
                {
                    MessageBox.Show($"The number '{number}' is a palindrome.", "Palindrome Checker");
                }
                else
                {
                    MessageBox.Show($"The number '{number}' is not a palindrome.", "Palindrome Checker");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer number.", "Palindrome Checker");
            }

        }


        private bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number = number / 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}
