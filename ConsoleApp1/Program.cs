using System.Xml.Linq;

namespace HomeWork_StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red; 
            Console.WriteLine("ЗАДАНИЕ ПЕРВОЕ");
            Console.ResetColor();
            Console.WriteLine($"Результат 2 + 4: {MathHelper.Addition(2, 4)}");
            Console.WriteLine($"Результат 10 - 3: {MathHelper.Subtraction(10, 3)}");
            Console.WriteLine($"Результат 5 * 6: {MathHelper.Multiplication(5, 6)}");
            Console.WriteLine($"Результат 10 / 2: {MathHelper.Division(10, 2)}"); 
            Console.WriteLine($"Результат 10 / 0: {MathHelper.Division(10, 0)}"); // Пример деления на ноль
            Console.WriteLine("_______________________________________________");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("ЗАДАНИЕ ВТОРОЕ");
            Console.ResetColor();
            Console.WriteLine("Начальная строка: Лебедь Александр");
            Console.WriteLine($"Реверсная строка: {StringUtils.ReverseString()}");
            Console.WriteLine(StringUtils.ReverseString2());

        }
    }
}

