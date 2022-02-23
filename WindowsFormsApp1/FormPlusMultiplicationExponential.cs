using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPlusMultiplicationExponential : Form
    {
        public string numberOne { get; set; }
        public string numberTwo { get; set; }
        public string numberThree { get; set; }
        public string numberFour { get; set; }
        public string numberFive { get; set; }
        public string numberExponentiator { get; set; }
        public FormPlusMultiplicationExponential()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void number1_TextChanged(object sender, EventArgs e)
        {
            numberOne = number1.Text;
        }

        private void number2_TextChanged(object sender, EventArgs e)
        {
            numberTwo = number2.Text;
        }

        private void number3_TextChanged(object sender, EventArgs e)
        {
            numberThree = number3.Text;
        }

        private void number4_TextChanged(object sender, EventArgs e)
        {
            numberFour = number4.Text;
        }

        private void number5_TextChanged(object sender, EventArgs e)
        {
            numberFive = number5.Text;
        }

        private void numberExponentiator_TextChanged(object sender, EventArgs e)
        {
            numberExponentiator = number6.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int resultExponentiator = exponentiation(Int32.Parse(numberFive), Int32.Parse(numberExponentiator));
            string resultOperation = Convert.ToString(operation(Int32.Parse(numberOne), Int32.Parse(numberTwo), Int32.Parse(numberThree), Int32.Parse(numberFour), resultExponentiator));
            this.resultCalc.Text = resultOperation;
        }

        private int exponentiation(int numberFive, int numberExponentiator)
        {
            int result = 1;
            for (int i = 0; i < numberExponentiator; i++)
            {
                result *= numberFive;
            }
            return result;
        }

        private int operation(int numberOne, int numberTwo, int numberThree, int numberFour, int resultExponentiator)
        {
            int resultCalcOperation = numberOne * numberTwo * numberThree + numberFour * resultExponentiator;
            return resultCalcOperation;
        }
    }
}
