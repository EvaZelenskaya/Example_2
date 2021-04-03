using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Введите число X = ");
            int X = Convert.ToInt16(Console.ReadLine());

            List<int> numbers = new List<int>();
            numbers.Add(-10); numbers.Add(14); numbers.Add(0); numbers.Add(5); numbers.Add(X);
            Console.WriteLine("Исходный список!");
            foreach (object c in numbers)
            {
                Console.Write(c);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив!");
            foreach (object c in numbers)
             {
                object a = Convert.ToInt32(c);
                if (X.CompareTo(a)==1)
                                 Console.Write(c + " "); 
             }
            foreach (object c in numbers)
            {
                object a = Convert.ToInt32(c);
                if (X.CompareTo(a) == 0)
                    Console.Write(c + " ");
            }
                foreach (object c in numbers)
                {
                    object a = Convert.ToInt32(c);
                    if (X.CompareTo(a) == -1)
                        Console.Write(c + " ");
                }
                Console.ReadKey();
        }
    }
}
