using System;

// Задание 1
// Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
// В результате вся информация выводится в одну строчку:

// Лузиков Иван

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа Анкета");

            Console.WriteLine("Введите имя:");
            var userName = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            var userLastName = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            var userAge = Console.ReadLine();
            Console.WriteLine("Введите рост(см):");
            var userHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес(кг):");
            var userWeight = double.Parse(Console.ReadLine());

            // используя  склеивание;
            Console.WriteLine("Ваши данные: имя - " + userName + ", фамилия - " + userLastName + ", возраст - " + userAge + ", рост - " + userHeight + ", вес - " + userWeight);
            
            // используя форматированный вывод;
            Console.WriteLine("Ваши данные: имя - {0}, фамилия - {1}, возраст - {2}, рост - {3}, вес - {4}", userName, userLastName, userAge, userHeight, userWeight);
            
            // используя вывод со знаком $ (интерполяцию строк).
            Console.WriteLine($"Ваши данные: имя - {userName}, фамилия - {userLastName}, возраст - {userAge}, рост - {userHeight}, вес - {userWeight}");
            
            Console.ReadKey();
        }
    }
}
