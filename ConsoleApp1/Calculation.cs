using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculation
    {
        internal void IterativeCalculation(int quanityElements)
        {
            int beforePreviousElement = 1;
            int previuosElement = 1;
            for (int i = 0; i <= quanityElements - 1; i++)
            {
                // Первые два элемента последовательности дожны быть равны единицу,
                // для математического расчёта, поэтому в первой иттерации мы выводим только один из них.
                if (i == 0)
                {
                    Console.WriteLine(beforePreviousElement);
                    continue;
                }

                int sumBothElement = previuosElement + beforePreviousElement;
                beforePreviousElement = previuosElement;
                previuosElement = sumBothElement;

                Console.WriteLine(sumBothElement);
            }
        }
        internal void RecursionCalculation(int quanityElements, int count = 1, int beforePreviousElement = 0, int previuosElement = 1)
        {
            if(count > quanityElements)
            {
                return;
            }
            if (beforePreviousElement == 0 && previuosElement == 1)
            {
                Console.WriteLine(previuosElement);
                beforePreviousElement = 1;
                count++;
                RecursionCalculation(quanityElements, count, beforePreviousElement, previuosElement);

                // Здесь return служит для избегания повторного обхода веток,
                // после завершения действи функции
                return;
            }
            int sumBothElement = previuosElement + beforePreviousElement;
            beforePreviousElement = previuosElement;
            previuosElement = sumBothElement;

            Console.WriteLine(sumBothElement);
            count++;
            RecursionCalculation(quanityElements, count, beforePreviousElement, previuosElement);
        }
        internal void RecursionCalculationWithCash(int quanityElements, int count = 1)
        {
            if (count > quanityElements)
            {
                return;
            }
            Console.WriteLine(CacheManager.GetOrCreate(count));

            count++;
            RecursionCalculationWithCash(quanityElements, count);
        }
    }
}
