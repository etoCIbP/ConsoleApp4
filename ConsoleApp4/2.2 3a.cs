using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите двузначное число");
            string x = Console.ReadLine();
            char a = '7';
            if (x.Contains('3') || x.Contains(a))
                Console.WriteLine("Число " + x + " с цифрой 3 и/или 7");
            else
                Console.WriteLine("Ошибка");

        }
    }
}
