using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_StaticClass
{
    internal static class MathHelper
    {
        internal static int Addition(int a, int b)
        {
            return a + b;
        }

        internal static int Subtraction(int a, int b)
        {
            return a - b;
        }

        internal static int Multiplication(int a, int b)
        {
            return a * b;
        }

        internal static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.Write("Деление на ноль невозможно. ");
                return 0;
            }

            return a / b;



        }

    }
}
