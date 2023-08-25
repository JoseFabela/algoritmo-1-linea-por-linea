using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmo_1_linea_por_linea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 12, 9, 20, 3, 15, 8 };

            int maxNumber = FindMaxLinear(numbers);

            Console.WriteLine($"The maximum number in the list is: {maxNumber}");
            Console.ReadLine();

        }
        static int FindMaxLinear(List<int> numbers)
        {
            if (numbers.Count == 0)
                throw new InvalidOperationException("The list is empty.");

            int max = numbers[0]; // Initialize max with the first element

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; // Update max if a larger number is found
                }
            }

            return max;
        }
    }
}
