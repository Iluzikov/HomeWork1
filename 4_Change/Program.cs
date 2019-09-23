using System;

//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

// Лузиков Иван

namespace _4_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            // вариант а (с добавлением временной переменной)
            Console.WriteLine($" a = {a} b = {b}");
            Console.WriteLine("Меняем переменные местами используя временную переменную");
            int x = a;
            a = b;
            b = x;
            Console.WriteLine($"a = {a} b = {b}");
            Console.WriteLine();

            // вариант б (арифметический метод)
            a = 3;
            b = 4;

            Console.WriteLine($" a = {a} b = {b}");
            Console.WriteLine("Меняем переменные местами с помощью арифметики");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($" a = {a} b = {b}");
            Console.ReadKey();
        }
    }
}
