using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, r = 0;
            string st, stm;
            Console.WriteLine("Введите N");
            st = Console.ReadLine();
            if (int.TryParse(st, out n))
            {
                n = Convert.ToInt32(st);
                if (n > 0)
                {
                    int[,] mas = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if ((i + j + 1) % 2 == 1)
                            {
                                mas[i, j] = 1;
                            }
                            else
                            {
                                mas[i, j] = 0;
                            }
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write($"{mas[i, j]} \t");
                        }
                        Console.WriteLine();
                    }
                }
                else
                { Console.WriteLine("Введенное N<=0"); }
            }
            else { Console.WriteLine("Введенное N не является целым число"); }
            Console.ReadKey();
        }
    }
}
