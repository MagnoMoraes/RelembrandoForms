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
    public partial class FormHome : Form
    {
        FormPlusExponential chamaPlusExponential = new FormPlusExponential();
        FormPlusMultiplicationExponential chamaPlusMultiplication = new FormPlusMultiplicationExponential();
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chamaPlusExponential.ShowDialog();
        }

        private void buttonPlusMultiplicationExponential_Click(object sender, EventArgs e)
        {
            chamaPlusMultiplication.ShowDialog();
        }
    }
}
