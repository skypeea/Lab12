using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты центра окружности");
            Console.WriteLine("x0:");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y0:");
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки");
            Console.WriteLine("x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина окружности - " +Circle.GetCircle(r));
            Console.WriteLine("Площадь круга - " +Circle.GetArea(r));
           if (Circle.IsBelong(x0,y0,r,x,y))
                {
                Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит окружности");
            }
            Console.ReadKey();
        }
    }
}
