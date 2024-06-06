using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FibonMaxMulti
{
    class Tasks
    {
        public void Task1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int [n];
            fib[0] = 0; fib[1] = 1;
            Console.WriteLine(1 + ": " + fib[0]);
            Console.WriteLine(2 + ": " + fib[1]);
            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i-2] + fib[i - 1];
                Console.WriteLine(i + 1 + ": " + fib[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Вывод на экран всех компонентов последовательности с порядковым номером, кратным 3:");
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine(i + 1 + ": " + fib[i]);
                }
            }
        }

        public void Task2()
        {
            int[] arr = new int[100000];
            Random rng = new Random();
            for (int i = 0; i < 100000; i++)
            {
                if (rng.Next(100000) > 0)
                {
                    arr[i] = rng.Next(100000);
                    Console.Write(arr[i] + " ");
                }
            }
            int max_product = 0;
            for (int i = 0; i < 100000; ++i)
            {
                for (int j = i + 8; j < 100000; ++j)
                {
                    max_product = Math.Max(max_product, arr[i] * arr[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное произведение двух элементов, номера которых различаются не менее, чем на 8:");
            Console.WriteLine(max_product);
        }

    }
}



