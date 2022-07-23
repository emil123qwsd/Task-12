using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            bool answer=true;
            double square = Circle.GetSquare(r);
            double lenght = Circle.GetLength(r);
            Console.WriteLine("Площадь= {0} \nДлина окружности={1}", square,lenght);
            Console.WriteLine("Введите координату x0 центра окружности");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y0 центра окружности");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x проверяемой точки");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y проверяемой точки");
            double y = Convert.ToDouble(Console.ReadLine());
            bool app = Circle.GetAppertain(answer, r, x0, y0, x, y);
            Console.WriteLine(app? "Точка принадлежит окружности" : "Точка не принадлежит окружности");
            Console.ReadKey();
        }
    }
}
