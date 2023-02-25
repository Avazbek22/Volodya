using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Volodya // Пространство имен (название проекта)
{
    internal class Program // Класс - ООП
    {
        public static void Main(string[] args) // Метод Маин - точка входа в программу
        {
            // string str = "Hello World";
            Console.Write("Введите N: ");
            byte n = Byte.Parse(Console.ReadLine());
            Console.WriteLine((char)n);
        }
    }
}