using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Заполнить одномерный массив из 8 целых чисел с клавиатуры и вывести его на экран.
            //int[] omas = new int[8];
            //Console.WriteLine("Заполнение одномерного массива");
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write($"omas=[{i}]=");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Вывод одномерного массива");
            /*Вариант 1 *///for(int i=0;i<8;i++)
                          //{
                          //    Console.WriteLine($"omas [{i}]={omas[i]}");
                          //}
            /* Вариант 2  *///foreach(var i in omas)
                            //{
                            //    Console.Write(i);
                            //}


            //Задача 2.Составьте программу ввода(без клавиатуры) и вывода массива: 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3.
            //int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };
            //Console.WriteLine("Вывод одномерного массива");
            //for(int i=0;i<omas.Length;i++)
            //{
            //    Console.WriteLine($"omas [{i}]={omas[i]}");
            //}


            //Задача 3.Массив предназначен для хранения значений ростов двенадцати человек.С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
            //int[] omas = new int[12];
            //Random rnd = new Random();
            //for(int i =0;i<omas.Length;i++)
            //{
            //    omas[i] = rnd.Next(163, 190);
            //}
            //foreach(var element in omas)
            //{
            //    Console.Write($"{element}\n");
            //}


            //Задача А. Найти среднюю температуру воздуха за октябрь месяц.
            //int[] omas = new int[31];
            //Console.WriteLine("Вывод средней температуру воздуха");
            //for(int i=0;i<omas.Length;i++)
            //{
            //   Console.WriteLine($"omas [{i}]={omas[i]}");
            //}
            Console.Read();

        }
    }
}
