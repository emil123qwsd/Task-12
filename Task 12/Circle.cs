using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    static class Circle
    {
        static public double GetLength(double r)
        {
            return 2*Math.PI*r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r*r;
        }
        static public bool GetAppertain(bool answer, double r, double x0, double y0, double x, double y)
        {
            double r1 = Math.Sqrt(Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2));
            return answer=r1== r;
            //    if (Math.Sqrt(Math.Pow(2, (x - x0)) + Math.Pow(2, (y - y0))) == r)
            //{
                
            //    return answer = 1; 
            //    Console.WriteLine("Точка принадлежит окружности");
            //}
            //else
            //{
            //    return answer = 0; 
            //    Console.WriteLine("Точка не принадлежит окружности");
            //}
                
        }
    }
}
