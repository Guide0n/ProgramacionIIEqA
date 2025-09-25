using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int cantidad1;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        String operador="";
        Double num1 = 0;
        Double num2 = 0;


        private void button5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            num1 = 0;
            num2 = 0;   
            operador = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void btpunto_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ",";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtScreen.Text);
            switch (operador)
            {
                case "+":
                    txtScreen.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    txtScreen.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    txtScreen.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        txtScreen.Text = "Error";
                    }
                    else
                    {
                        txtScreen.Text = Convert.ToString(num1 / num2);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btmulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }
    }
}
