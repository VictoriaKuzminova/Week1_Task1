using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void res_button_Click(object sender, EventArgs e)
        {
            if (Num_textBox.Text == "")
            {
                MessageBox.Show("Введены не все данные");
            }
            else
            {
                try
                {
                    num = int.Parse(Num_textBox.Text);
                    if (num > 0)
                    {
                        if (num <= 10 || num >= 100)
                        {
                            MessageBox.Show("Число должно быть двузначным!");
                            return;
                        }
                    }
                    else
                    {
                        if (num <= -100 || num >= -10)
                        {
                            MessageBox.Show("Число должно быть двузначным!");
                            return;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод! Доступен только ввод чисел, запятой и знака \"минус\"");
                }
                int num1;
                if (num < 0)
                {
                    num1 = -1 * (num / 10);
                }
                else
                {
                    num1 = num / 10;
                }
                int num2;
                if (num > 0)
                {
                    num2 = num % 10;
                }
                else
                {
                    num2 = -1 * (num % 10);
                }
                if (num1 > num2) res_textBox.Text = "Первое число " + num1 + " " + "\nВторое число " + num2 + "\nПервое число больше второго";
                else if (num1 < num2) res_textBox.Text = "Первое число " + num1 + " " + "\nВторое число " + num2 + "\nПервое число меньше второго";
                else res_textBox.Text = "Первое число " + num1 + " " + "\nВторое число " + num2 + "\nЧисла равны";

            }
        }

        private void Num_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowSymbol = "-\b";
            if (!allowSymbol.Contains(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }
}

