using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class Circle
    {


        public static double GetCircle(double r)//определение длины окружности по радиусу
        {
            return 2 * Math.PI * r;
        }
        public static double GetArea(double r)//определение площади по радиусу
        {
            return r * r * Math.PI;
        }
        public static bool IsBelong(double x0, double y0, double r, double x, double y)//x0,y0 - координаты центра круга, x,y - коордиаты точки
        {
            double a = x - x0;
            double b = y - y0;
            return (Math.Sqrt((a * a) + (b * b)) <= r);
           
        }


    }
}
