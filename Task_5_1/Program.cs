using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double summ = 0, resul = 0;
            double[] mas = new double[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент массива");
                mas[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 7; i++)
            {
                summ = summ + mas[i];
            }
            resul = summ / 7;
            double resul1 = Math.Round(resul, 2);
            Console.WriteLine("Среднее арифметическое =  " + resul1);
            Console.ReadKey();
        }
    }
}
