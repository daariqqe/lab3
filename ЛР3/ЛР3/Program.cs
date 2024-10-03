using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //task 1 
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Завдання 1");
                Console.WriteLine("Введіть ціле число n");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть дійсне число х");
                int x = Convert.ToInt32(Console.ReadLine());
                double s = 0;
                int i = 1;
                while ( i <= n )
                {
                    s += (Math.Cos(i * x) / i);
                    i++;

                }
                Console.WriteLine("sum={0}", Math.Round(s, 2));
                Console.ReadKey();
            }
            {
                //task 2
                Console.WriteLine("__________________________________________");
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Завдання 2");
                int i = 1;
                double fault = 1;
                double e = Math.Pow(10, -4);
                double x = Math.PI / 2;
                double sum = 0;
                double a = 0;
                do
                {
                    a = Math.Pow(-1, i) * (Math.Pow(2, i) / (i * x + Math.Pow(5, i)));
                    sum += a;
                    fault = Math.Abs(a/sum);
                    i++;
                } while (fault > e );
                Console.WriteLine();
                Console.WriteLine("Номер ітерації: " + i );
                Console.WriteLine("Величина поточного члену ряду: " + a);
                Console.WriteLine("Величина накопиченої суми ряду: " + sum);
                Console.WriteLine("Досягнута на поточній ітеріції похибка: " + fault);
                Console.ReadLine();
            }
            {
                //task 3
                Console.WriteLine("x\t\ty\t\tz");
                double x1 = -4;
                double x2 = 10;
                double h = 0.4;
                double pi = Math.PI;
                for ( double i = x1; i <= x2; i += h)
                {
                    double y1 = Math.Sqrt (Math.Abs(i + (pi / 4)));
                    double y2 = Math.Sin(Math.Pow(i, 2)) + Math.Cos(i);
                    Console.WriteLine($"{i,4:F1} |{y1,12:F4} |{y2,12:F4}");
                }
                Console.ReadKey();

            }
        }
    }
}
