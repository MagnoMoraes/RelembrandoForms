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
    public partial class FormPlusExponential : Form
    {        
        public string numberOne { get; set; }
        public string numberTwo { get; set; }
        public string numberExponentiator { get; set; }
        public FormPlusExponential()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            numberOne = textBox1.Text;
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            numberTwo = textBox2.Text;
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            numberExponentiator = textBox3.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //faz as textBox aceitarem apenas números
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string convertResult = Convert.ToString(exponentiation(Int32.Parse(numberOne), Int32.Parse(numberTwo), Int32.Parse(numberExponentiator)));
            this.textBox4.Text = convertResult;
        }

        private int exponentiation(int numberSumsOne, int numberSumsTwo, int numberExponentiator)
        {
            int exponentiationResult = 1;
            int sumResult = numberSumsOne + numberSumsTwo;
            for (int i = 0; i < numberExponentiator; i++)
            {                
                exponentiationResult *= sumResult;
            }
            return exponentiationResult;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {            
        }

        private void FormPlusExponential_Load(object sender, EventArgs e)
        {

        }
    }
}
