using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, m;
            Console.WriteLine("Введите кол-во четырехугольников:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во квадратов:");

            m = Convert.ToInt32(Console.ReadLine());

            che[] nmass = new che[n];
            kvadr[] mmass = new kvadr[m];
            double[] kords = new double[8];

            Console.WriteLine("координаты вводятся в формате x1 [enter] y1 [enter] x2 [enter] y2 [enter] x3 [enter] y3 [enter] x4 [enter] y4");
            for (int i = 0; i != n; i++)
            {
                Console.WriteLine("Введите координаты точек " + (i + 1) + " четырехугольника");
                for (int j = 0; j != 8; j++)
                {
                    kords[j] = Convert.ToDouble(Console.ReadLine());
                }
                nmass[i] = new che(kords);

            }

            for (int i = 0; i != m; i++)
            {
                Console.WriteLine("Введите координаты точек " + (i + 1) + " квадрата");
                for (int j = 0; j != 8; j++)
                {
                    kords[j] = Convert.ToDouble(Console.ReadLine());
                }
                try
                {
                    mmass[i] = new kvadr(kords);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Это не квадрат, попробуйте еще раз");
                    i--;
                }

            }


            double min = Double.MaxValue, max = Double.MinValue;
            int minindex = -1, maxindex = -1;
            for (int i = 0; i != n; i++)
            {
                if (nmass[i].perim < min)
                {
                    min = nmass[i].perim;
                    minindex = i;
                }
                if (nmass[i].plosh > max)
                {
                    max = nmass[i].plosh;
                    maxindex = i;
                }
            }
            if (n > 0)
            {
                Console.WriteLine("Четырехугольник с минимальным периметром под номером " + (minindex + 1) + ", его периметр = " + nmass[minindex].perim);
                Console.WriteLine("Четырехугольник с максимальной площадью под номером " + (maxindex + 1) + ", его площадь = " + nmass[minindex].plosh);
            }

            if (m > 0)
            {
                for (int i = 0; i != m - 1; i++)
                {
                    Console.Write("Квадрату " + (i + 1) + " равны след.:");
                    for (int j = i + 1; j != m; j++)
                    {
                        if (mmass[i].equal(mmass[j]))
                        {
                            Console.Write(" " + (j + 1));
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("end");
            Console.ReadKey();

        }
    }
}

/*
 2 лаба  12. Создать класс четырехугольник, члены класса – координаты 4-х точек. Предусмотреть в классе
методы вычисления и вывода сведений о фигуре – длины сторон, диагоналей, периметр, площадь.
Создать производный класс – квадрат, предусмотреть в классе проверку, является ли фигура
квадратом. Написать программу, демонстрирующую работу с классом: дано N четырехугольников и M
квадратов, найти четырехугольники с минимальной и максимальной площадью и номера одинаковых
квадратов
 
 
 */
/*
3
3
0
0
0
1
1
1
1
0
0
0
0
2
2
2
2
0
0
0
0
0,5
0,5
0,5
0,5
0
0
0
0
1
1
1
1
0
0
0
0
2
2
2
2
0
0
0
0
1
1
1
1
0


 */