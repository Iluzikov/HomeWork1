﻿using System;

// Задание 3
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле
// r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
// Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//
// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
//
// Лузиков Иван

namespace Distance
{
    class Program
    {
        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            var x1 = 10;
            var y1 = 20;

            var x2 = 40;
            var y2 = 50;

            // вариант а
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками = {0:f2}", distance);

            // вариант б
            Console.WriteLine("Расстояние между точками = {0:f2}", CalculateDistance(x1, y1, x2, y2));

            Console.ReadKey();
        }
    }
}
