using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Controls;


namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void Table(int k, double[] u, int[] n, double sumN)
        {
            dataGridView1.Size = new Size(500, 150);

            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = k;

            dataGridView1.Rows[0].HeaderCell.Value = "u[i]";
            dataGridView1.Rows[1].HeaderCell.Value = "n[i]";
            dataGridView1.Rows[2].HeaderCell.Value = "n[i]/n";

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = u[i];
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows[1].Cells[i].Value = n[i];
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Rows[2].Cells[i].Value = n[i] / sumN;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Empty field");
            else
            {
                int k = Convert.ToInt32(textBox1.Text);
                double[] u = new double[k];
                Random rnd = new Random();//Создание объекта для генерации чисел

                for (int j = 0; j < k; j++)
                {
                    //Получить очередное (в данном случае - первое) случайное число
                    double value = rnd.NextDouble();
                    
                    u[j] = Math.Round(value, 3);
                }

                Array.Sort(u);

                if ((textBox2.Text == "") || (textBox3.Text == ""))
                    MessageBox.Show("Empty field");
                else
                {
                    double p1 = Convert.ToDouble(textBox2.Text);
                    double p2 = Convert.ToDouble(textBox3.Text);

                    if ((p1 > 1) || (p2 > 1))
                        MessageBox.Show("Error");

                    int[] n = new int[k];
                    double sumN = 0;

                    for (int j = 0; j < k; j++)
                    {
                        double sum = p1;
                        int i = 1;
                        while (sum < u[j])
                        {
                            sum = sum + Math.Pow(1 - p1, i) * Math.Pow(1 - p2, i - 1) * (p1 + p2 - p1 * p2);
                            i++;
                        }
                        n[j] = i;
                        sumN = sumN + i;
                    }

                    Table(k, u, n, sumN);
                    //MessageBox.Show(sumN.ToString());
                }
            }
        }
    }
}
