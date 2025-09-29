using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRinTech
{
    internal class Main
    {
        public void main()
        {
            int a = 1;
            int b = 1;
            int c = 66;

            int min = -1;
            int middle = -1;
            int max = -1;

            if (a >= b && b >= c)
            {
                max = a;
                if (c >= b)
                {
                    middle = c;
                    min = b;
                }
                else
                {
                    middle = b;
                    min = c;
                }
            }
            else if (c >= a && a >= b)
            {
                max = c;
                if (b >= a)
                {
                    middle = b;
                    min = a;
                }
                else
                {
                    middle = a;
                    min = b;
                }
            }
            else
            {
                max = b;
                if (c >= a)
                {
                    middle = c;
                    min = a;
                }
                else
                {
                    middle = a;
                    min = c;
                }
            }

            Console.WriteLine($"max = {max} mid = {middle} min = {min}");
        }
    }
}