using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            double average = CalculateAverage(array);
            Console.WriteLine($"Элементы меньше среднего значения ({average}):");
            for (int i = 0; i < n; i++)
            {
                if (array[i] < average)
                {
                    Console.WriteLine($"Элемент {i + 1}: {array[i]}");
                }
            }
            Console.ReadKey();
        }
        static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            Console.ReadKey();
            return (double)sum / array.Length;
        }
    }
}

