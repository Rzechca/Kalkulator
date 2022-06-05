using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double wartosc = 0;
        double wynik = 0;
        double? wartosc2 = null;
        double resultValue = 0;
        string operacjaperform = "";
        bool costam = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (costam))
            {
                textBox.Clear();
            }
            costam = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBox.Text.Contains(","))
                    textBox.Text = textBox.Text + button.Text;
            }
            else
                textBox.Text = textBox.Text + button.Text;
        }

        private void operacja(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button20.PerformClick();
                operacjaperform = button.Text;
                label.Text = resultValue + " " + operacjaperform;
                costam = true;
            }
            else
            {
                operacjaperform = button.Text;
                resultValue = Double.Parse(textBox.Text);
                if (wartosc2 != null)
                    label.Text = resultValue + " " + operacjaperform + " " + wartosc;
                else
                    label.Text = resultValue + " " + operacjaperform;
                costam = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }
        private void button6_Click(object sender, EventArgs e)
        {

            textBox.Clear();
            textBox.Text = "0";
            resultValue = 0;
            label.Text = "";
            wynik = 0;

        }

        private int silnia(double a)
        {
            silspr(Double.Parse(textBox.Text));

            if (resultValue >= 0)
            {
                int s = 1;
                if (a == 0)
                    return s;
                for (int i = 1; i <= a; i++)
                {
                    s = s * i;
                }
                return s;
            }
            else
            {
                return 0;
            }
        }

        private void silspr( double h)
        {
            if (h < 0)
            {
                textBox.Text = "Nie";

                Application.DoEvents();
                Thread.Sleep(3000);

                textBox.Clear();
                textBox.Text = "0";
                resultValue = 0;
                label.Text = "";
                wynik = 0;
            }
            textBox.Text = "0";
        }
      
        private void button20_click(object sender, EventArgs e)
        {
            if (wynik != Double.Parse(textBox.Text))
            {
                wartosc = Double.Parse(textBox.Text);
                wartosc2 = wartosc;
            }
            switch (operacjaperform)
            {
                case "+":
                    textBox.Text = (resultValue + wartosc).ToString();
                    wynik = (resultValue + wartosc);
                    break;
                case "-":
                    textBox.Text = (resultValue - wartosc).ToString();
                    wynik = (resultValue - wartosc);
                    break;
                case "*":
                    textBox.Text = (resultValue * wartosc).ToString();
                    wynik = (resultValue * wartosc);
                    break;
                case "/":
                    if (wartosc != 0)
                    {
                        textBox.Text = (resultValue / wartosc).ToString();
                        wynik = (resultValue / wartosc);
                    }
                    else
                    {
                        textBox.Text = "nie_przez_zero";
                        
                        Application.DoEvents();
                        Thread.Sleep(3000);

                        textBox.Clear();
                        textBox.Text = "0";
                        resultValue = 0;
                        label.Text = "";
                        wynik = 0;
                    }
                    break;
                case "%":
                    textBox.Text = (resultValue % wartosc).ToString();
                    wynik = (resultValue % wartosc);
                    break;
                case "√":
                    textBox.Text = (Math.Sqrt(resultValue)).ToString();
                    wynik = (Math.Sqrt(resultValue));
                    break;
                case "^2":
                    textBox.Text = (resultValue * resultValue).ToString();
                    wynik = (resultValue * resultValue);
                    break;
                case "!":
                    textBox.Text = (silnia(resultValue)).ToString();
                    wynik = (silnia(resultValue));
                    break;
                default:
                    break;

            }
            label.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}