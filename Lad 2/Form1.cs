using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, s;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            char c = textBox3.Text[0];

            switch (c)
            {
                case '+':
                    s = a + b;
                    label4.Text = "Результат = " + s.ToString();
                    break;

                case '-':
                    s = a - b;
                    label4.Text = "Результат = " + s.ToString();
                    break;

                case '*':
                    s = a * b;
                    label4.Text = "Результат = " + s.ToString();
                    break;

                case '/':
                    if (b != 0)
                    {
                        s = a / b;
                        label4.Text = "Результат = " + s.ToString();
                    }
                    else
                    {
                        label4.Text = "Помилка: ділення на нуль!";
                    }
                    break;

                default:
                    label4.Text = "Помилка: невірна операція!";
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
