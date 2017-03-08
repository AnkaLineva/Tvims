using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double u;
        double res;
        int segm;

        private void button1_Click(object sender, EventArgs e)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            //Получить очередное (в данном случае - первое) случайное число
            double value = rnd.NextDouble();

            textBox1.Text = String.Format("u={0}", value);

            u = value;

            //return value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] tb = new TextBox[10];
            for (int i = 0; i < tb.Length; i++)
            {
                tb[i] = new System.Windows.Forms.TextBox();
                tb[i].Location = new System.Drawing.Point(101, 50 + i * 30);
                tb[i].Name = "textBox" + i.ToString();
                tb[i].Size = new System.Drawing.Size(75, 23);
                tb[i].TabIndex = i;
                tb[i].Text = "textBox" + i.ToString();
                Controls.Add(tb[i]);
            }

            /*Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("--------------------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
                for (int j = 1; j <= 10; j++)
                    Console.Write("{0}\t", i * j);*
            for (int i = 1 ; i < 11; i++)
        {
            Console.WriteLine(string.Format("{0}*{1}={2}",7,i,7*i));
        }
        Console.ReadKey();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double p1 = 0.5;//Convert.ToDouble(textBox2.Text);
            double p2 = 0.3;//Convert.ToDouble(textBox3.Text);

            double sum = p1;
            int i = 1;

            while (sum < u)
            {
                sum = sum + Math.Pow(1 - p1, i) * Math.Pow(1 - p2, i - 1) * (p1 + p2 - p1 * p2);
                i++;
            }

            segm = i;

        }       
    }
}
