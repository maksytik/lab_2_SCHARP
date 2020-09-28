using System;

namespace ConsoleApp2
{
    class che
    {

        //(x,y) 
        public readonly double[] kords = { 1, 1,/**/ 1, -1,/**/ -1, -1, /**/ -1, 1 };
        public readonly double s0, s1, s2, s3, d1, d2;
        public readonly double perim;
        public readonly double plosh;


        public che(double[] kords)
        {
            for (int i = 0; i != 8; i++)
            {
                this.kords[i] = kords[i];
            }

            s0 = storona(0, 1);
            s1 = storona(1, 2);
            s2 = storona(2, 3);
            s3 = storona(3, 0);
            d1 = storona(0, 2);
            d2 = storona(1, 3);
            perim = perimetr();
            plosh = ploshad();
        }

        private double storona(int a, int b)
        {
            if (a > 3 || a < 0 || b > 3 || b < 0) return -1;

            double x1, y1, x2, y2;
            x1 = kords[a * 2];
            y1 = kords[a * 2 + 1];
            x2 = kords[b * 2];
            y2 = kords[b * 2 + 1];

            double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

            return result;
        }


        private double perimetr()
        {

            double result = s0 + s1 + s2 + s3;


            return result;
        }


        private double ploshad()
        {

            double a, b, c, d, e, f, s;
            a = s0;
            b = s1;
            c = s2;
            d = s3;
            e = d1;
            f = d2;
            s = perim / 2;
            double result = (s - a) * (s - b) * (s - c) * (s - d) - (1 / 4) * (a * c + b * d + e * f) * (a * c + b * d - e * f);
            result = Math.Sqrt(result);

            return result;
        }

        public bool equal(che b)
        {

            for (int i = 0; i != 8; i++)
            {
                if (kords[i] != b.kords[i]) return false;
            }

            return true;
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