using System;
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организовать в центре экрана.
//в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

// Лузиков Иван

namespace _5_Programm
{
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Вариант в) " + msg);
        }

        static void Main(string[] args)
        {
            Tools tools = new Tools();

            Console.WriteLine("Введите ваше имя:");
            var userName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            var userLastname = Console.ReadLine();
            Console.WriteLine("Введите город проживания:");
            var userCity = Console.ReadLine();
            Console.WriteLine();
            string msg = $"имя: {userName}, фамилия: {userLastname}, город проживания: {userCity}";

            // вариант а
            Console.WriteLine("Вариант а) " + msg);

            // вариант б
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, 10);
            Console.WriteLine("Вариант б) " + msg);

            // вариант в
            Print(msg, 10, 15);
            Console.WriteLine();

            // Задание 6
            var mess = "Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause)";
            tools.PrintAll(mess);
            tools.Pause();
        }
    }
}
