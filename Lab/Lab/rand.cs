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
    public class RandU
    {

       public double u;
       public double res;
       public int segm;

       public RandU() { }

       public double genU()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            //Получить очередное (в данном случае - первое) случайное число
            double value = rnd.NextDouble();
            return value;

            
        }

        /*  static int GetRandom()
          {
              //Создание объекта для генерации чисел (с указанием начального значения)
              Random rnd = new Random(245);

              //Получить случайное число 
              int value = rnd.Next();

              //Вернуть полученное значение
              return value;
          }

          static void Main(string[] args)
          {
              //Вывод сгенерированных чисел в консоль
              Console.WriteLine(GetRandom());
              Console.WriteLine(GetRandom());
              Console.WriteLine(GetRandom());
          }*/
    }

}
