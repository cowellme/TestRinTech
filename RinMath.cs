using System;

namespace TestRinTech
{
   
    public static class RinMath
    {
       
        public static double circleArea(double radius)
        {
            var result = -1.0;

            if (radius <= 0)
                Console.WriteLine("Радиус должен быть положительный\n");
            else
                result = Math.PI * radius * radius;

            return result;
        }

        public static double triangleArea(double a, double b, double c)
        {
            var result = -1.0;
            if (!validTriangle(a, b, c))
                Console.WriteLine("Невозможно построить треугольник\n");
            else
            {
                double s = (a + b + c) / 2.0;
                result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }

            return result;
        }
        
        public static double sphereVolume(double radius)
        {
            var result = -1.0;
            if (radius <= 0)
                Console.WriteLine("Радиус должен быть положительный\n");
            else
                result = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            return result;
        }
        
        public static bool validTriangle(double a, double b, double c)
        {
            var result = true;
            if (a <= 0 || b <= 0 || c <= 0)
                result = false;
            else
                result = (a + b > c) && (a + c > b) && (b + c > a);
            return result;
        }
    }
}