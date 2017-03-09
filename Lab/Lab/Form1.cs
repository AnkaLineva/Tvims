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
        /*создание таблицы*/
        void Funtcion(int rightgran)
        {
            dataGridView1.Size = new Size(400, 150);

            /*создание столбцов*/
            //1 столбец, текстовый
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "x";
            column0.HeaderText = "x";
            //Берем количество столбцов

            for (int i = 0; i < rightgran; i++) {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = "sv";
                column.HeaderText = ""+i;
                dataGridView1.Columns.AddRange(column);
                //создание ячейки для столбца
                DataGridViewCell id0 = new DataGridViewTextBoxCell();
                id0.Value = ""+i; // тут нужен набор данных
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        RandU lab = new RandU();

        private void button1_Click(object sender, EventArgs e)
        {
            lab.u = lab.genU();
            textBox1.Text = String.Format("u={0}", lab.u);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == null) || (textBox2.Text == null))
                MessageBox.Show("Field of p1 or p2 is empty");
            else
            {
                double p1 = Convert.ToDouble(textBox2.Text);
                double p2 = Convert.ToDouble(textBox3.Text);

                double sum = p1;
                int i = 1;

                if ((p1 > 1) || (p2 > 1) || ((p1 + p2) != 1))
                    MessageBox.Show("Defult. Please try again");

                while (sum < lab.u)
                {
                    sum = sum + Math.Pow(1 - p1, i) * Math.Pow(1 - p2, i - 1) * (p1 + p2 - p1 * p2);
                    i++;
                }

                lab.segm = i;
                Funtcion(lab.segm);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
