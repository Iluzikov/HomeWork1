using System;

// Задание 2
// Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле:
// I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

// Лузиков Иван

namespace IMT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост(см):");
            var userHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес(кг):");
            var userWeight = double.Parse(Console.ReadLine());

            userHeight = userHeight / 100.0;
            var imt = userWeight / (userHeight * userHeight);

            Console.WriteLine("Ваш индекс масы тела = " + imt.ToString("##.##"));
            
            Console.ReadKey();
        }
    }
}
