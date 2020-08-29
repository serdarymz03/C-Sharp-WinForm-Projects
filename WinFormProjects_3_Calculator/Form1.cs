using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProjects_3_Calculator
{
    public partial class Form1 : Form
    {
        int number1, number2, result;
        bool isSecondNumber, isFinish;
        string secondNumber, process;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isSecondNumber = false;
            isFinish = false;           
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            RchResult.Clear();
            isFinish = false;

        }

        void SecondNumberValue(string number)
        {
            if (isSecondNumber)
            {
                secondNumber += number;
            }
        }

        void MathProcess(string symbol, string processText)
        {
            if (isFinish) { return; }
            number1 = int.Parse(RchResult.Text);
            isSecondNumber = true;
            RchResult.Text += symbol;
            process = processText;
        }

        #region ButtonNumbers
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "1";
            SecondNumberValue("1");
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "2";
            SecondNumberValue("2");
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "3";
            SecondNumberValue("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "4";
            SecondNumberValue("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "5";
            SecondNumberValue("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "6";
            SecondNumberValue("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "7";
            SecondNumberValue("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "8";
            SecondNumberValue("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "9";
            SecondNumberValue("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (isFinish) { return; }
            RchResult.Text += "0";
            SecondNumberValue("0");
        }
        #endregion

        #region ButtonMathProcess
        private void BtnTopla_Click(object sender, EventArgs e)
        {
            MathProcess("+", "Topla");
        }

        private void BtnCikar_Click(object sender, EventArgs e)
        {
            MathProcess("-", "Çıkar");
        }
        private void BtnCarp_Click(object sender, EventArgs e)
        {
            MathProcess("X", "Çarp");
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            MathProcess("/", "Böl");
        }
        #endregion

        private void BtnResult_Click(object sender, EventArgs e)
        {
            isSecondNumber = false;
            number2 = Convert.ToInt32(secondNumber);
            switch (process)
            {
                case "Topla":
                    result = number1 += number2;
                    break;
                case "Çıkar":
                    result = number1 - number2;
                    break;
                case "Çarp":
                    result = number1 * number2;
                    break;
                case "Böl":
                    result = number1 / number2;
                    break;
                default:
                    result = 0;
                    break;
            }

            RchResult.Text += "\n" + result;
            isFinish = true;
        }

    }
}
