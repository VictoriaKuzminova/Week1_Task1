using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        double a, b;

        private void res_button_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(zn_a_textBoxs.Text);
                if (a <= 0)
                {
                    MessageBox.Show("Значение катета а не может быть меньше или равно 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введено неверное значение у катета а!");
                return;
            }

            try
            {
                b = double.Parse(zn_b_textBox.Text);
                if (b <= 0)
                {
                    MessageBox.Show("Значение катета b не может быть меньше или равно 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введено неверное значение у катета а\b!");
                return;
            }
            res.Text = $"Площадь прямоугольного треугольника с катетами {a} и {b} равна {a * b / 2.0}";
        }

        private void zn_a_textBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowSymbol = "-\b,";
            if (!allowSymbol.Contains(e.KeyChar) && !char.IsNumber(e.KeyChar))
            e.Handled = true;
        }

        private void zn_b_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowSymbol = "-\b,";
            if (!allowSymbol.Contains(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
