using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Initialization
    {
        internal Initialization()
        {
            var exitFromProgramm = false;
            var calculation = new Calculation();
            Stopwatch stopwatch = new Stopwatch();

            while (!exitFromProgramm)
            {
                ShowMenu();
                Console.WriteLine();
                var key = Console.ReadKey().Key;
                int quantityElement = GetQuantityElement();
                switch (key)
                {
                    case ConsoleKey.F1:
                        stopwatch.Start();
                        calculation.IterativeCalculation(quantityElement);
                        stopwatch.Stop();
                        Console.WriteLine("Время работы: " + stopwatch.ElapsedMilliseconds);
                        stopwatch.Reset();
                        break;

                    case ConsoleKey.F2:
                        stopwatch.Start();
                        calculation.RecursionCalculation(quantityElement);
                        stopwatch.Stop();
                        Console.WriteLine("Время работы: " + stopwatch.ElapsedMilliseconds);
                        stopwatch.Reset();
                        break;

                    case ConsoleKey.F3:
                        stopwatch.Start();
                        calculation.RecursionCalculationWithCash(quantityElement);
                        stopwatch.Stop();
                        Console.WriteLine("Время работы: " + stopwatch.ElapsedMilliseconds);
                        stopwatch.Reset();
                        break;

                    case ConsoleKey.Escape:
                        exitFromProgramm = true;
                        break;
                }
            }
            
        }
        private int GetQuantityElement()
        {
            Console.WriteLine("Введите количество членов последовательности фибоначчи (от 2х до 45ти):");
            int quanityElements = int.Parse(Console.ReadLine());
            return quanityElements;
        }
        private void ShowMenu()
        {
            Console.WriteLine("F1 - иттеративный вариант");
            Console.WriteLine("F2 - рекурсивный вариант");
            Console.WriteLine("F3 - рекурсивный вариант с кэшированием");
            Console.WriteLine("Escape - закончить работу");
        }
    }
}
