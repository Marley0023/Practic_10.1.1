using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main (string[] args)
        {
            //18
            try
            {
                Console.Write("Введите кол-во строк у двумерном массиве: ");
                int str = int.Parse(Console.ReadLine());
                Console.Write("Введите кол-во столбцов у двумерном массиве: ");
                int stol = int.Parse(Console.ReadLine());
                int[,] M = new int[str, stol];
                Random rnd = new Random();
                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        M[i, j] = rnd.Next(-10, 10);
                    }
                }
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        Console.Write($"{M[i, j],4}");
                    }
                    Console.WriteLine();
                }
                Console.Write("Введите число k: ");
                int k = int.Parse(Console.ReadLine());
                if (k > 0)
                {
                    Console.Write("Введите k1: ");
                    int k1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите k2: ");
                    int k2 = int.Parse(Console.ReadLine());
                    int count = 0;
                    int sum = 0;
                    for (int i = 0; i < str; i++)
                    {
                        for (int j = 0; j < stol; j++)
                        {
                            if (M[i, j] > 0 && M[i, j] % k == 0)
                            {
                                count++;
                            }
                            if (i >= k1 - 1 && i <= k2 - 1)
                            {
                                sum += M[i, j];
                            }
                        }

                    }
                    Console.WriteLine($"Кол-во положительных чисел кратных {k}: {count}");
                    Console.WriteLine($"Сумма чисел в промежутке от {k1} до {k2}: {sum}");
                }
                else
                {
                    Console.WriteLine("K должно быть больше 0");
                }

            }
            catch
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();

            //19
            //try
            //{
            //    int str, b, a, k1, k2, c = 0, x = 1, stol;
            //    Console.Write("Введите кол-во строк в массиве: ");
            //    str = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введите кол-во столбцов в массиве: ");
            //    stol = Convert.ToInt32(Console.ReadLine());
            //    if (str > 0 && stol > 0)
            //    {
            //        Console.Write("Введите a: ");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Введите b: ");
            //        b = Convert.ToInt32(Console.ReadLine());

            //        Console.Write("Введите k1: ");
            //        k1 = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Введите k2: ");
            //        k2 = Convert.ToInt32(Console.ReadLine());
            //        int[,]M = new int[str, stol];
            //        Random rnd = new Random();
            //        for (int i = 0; i < M.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < M.GetLength(1); j++)
            //            {
            //                 M[i, j] = rnd.Next(-10, 10);
            //                Console.Write($"{M[i, j], 4}");
            //            }
            //            Console.WriteLine();
            //        }


            //        for (int i = 0; i < M.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < M.GetLength(1); j++)
            //            {

            //                if (M[i, j] % a == 0 || M[i, j] % b == 0)
            //                {
            //                    c++;
            //                }
            //                if (i >= k1 && i <= k2 && M[i, j] < 0)
            //                {
            //                    x *= M[i, j];
            //                }



            //                Console.WriteLine($"Кол-во элементов кратных a или b = {c}");
            //                Console.WriteLine($"Произведение отрицательных элементов элементов из столбцов {k1}-{k2} = {x}");
            //                Console.ReadKey();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Размеры массива не могут быть меньше 0");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Неверный тип данных");
            //}

        }
    }
}
