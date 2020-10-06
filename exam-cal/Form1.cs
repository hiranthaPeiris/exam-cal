using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_cal
{
    public partial class Form1 : Form,CalculatorWindow
    {
        Calculator calculator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculator = new Calculator(this);
        }
        public void onValueChange(string value)
        {
            textBox1.Text = value;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("3");
        }


        private void btn5_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("5");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("4");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("9");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calculator.onInsertValue("6");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calculator.onInsertOperator(Calculator.OPERATORS.ADD);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calculator.onInsertOperator(Calculator.OPERATORS.SUB);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            calculator.onInsertOperator(Calculator.OPERATORS.MPY);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculator.onInsertOperator(Calculator.OPERATORS.DIV);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            calculator.onInsertOperator(Calculator.OPERATORS.EQL);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            calculator.onClear();
        }
    }
}
