using System;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите <№> и любое число :");
            string str = Console.ReadLine();
            
            while (str.Contains("№"))
            {
                str = str.Replace("№", "номер по порядку ");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
