using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_StaticClass
{
    internal static class StringUtils
    {

        //метод с сайта "Stackverflow"
        public static string ReverseString()
        {
            string  MyName = "Лебедь Александр";

            char[] MyNameForReverse = MyName.ToCharArray();
            string NameReverse = new string (MyNameForReverse.Reverse().ToArray());
            return NameReverse;

        }

        //реализация реверса через цикл
        public static string ReverseString2()
        {
            Console.WriteLine("Введите свою строку для реверса: ");
            string MyName = Console.ReadLine();

            char[] MyNameForReverse = MyName.ToCharArray();
            char[] ReverseName = new char [MyNameForReverse.Length];

            for (int i = 0, j = MyNameForReverse.Length - 1; i < MyNameForReverse.Length; i++, j--) 
            {

                ReverseName [i] = MyNameForReverse[j];
            }


            return  new string(ReverseName);

        }


    }
}
