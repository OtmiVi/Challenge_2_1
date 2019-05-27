using System;
using System.Linq;

namespace Challenge_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            Random random = new Random();
            int[][] mas = new int[random.Next(2, n)][];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new int[random.Next(1, n)];
                for (int j = 0; j < mas[i].Length; j++)
                {
                    mas[i][j] = random.Next(n);
                }
            }

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    Console.Write($" {mas[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            int[] five = new int[n / 5];
            for (int i = 0,  j = 5;i< n/5;j +=5 ,i++)
            {
                five[i] = j ;
            }
            
            var result = mas[1].Except(five);
            for (int i = 0; i < mas.Length; i++)
            {
                result = mas[i].Union(result);
            }
            result = result.Except(five);

            int[] sort = result.ToArray();
            for (int i = 0; i < sort.Length - 1; i++)
            {
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (sort[i] > sort[j])
                    {
                        (sort[i], sort[j]) = (sort[j], sort[i]);
                    }
                }
            }

            foreach (int q in sort)
            {
                Console.Write($" {q}");
            }

            Console.ReadKey();
        }
    }
}
