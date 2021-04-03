using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////////TASK#2///////////////////////////
            Console.Write(" Введите значение M : ");
            double M = Double.Parse(Console.ReadLine());
            double e = 0.01, F = 5555;
            
            int n = 1;
            int i = 0;
            while (F > e)
            {
                F = Math.Abs((1 / 2) - ((M + 1) / (2 * M + 4)));

                Console.WriteLine("Primerno: {0}", F);
                M--;
            }
            Console.WriteLine("Результат: {0}", F);
           
            double E = Math.Pow((-1), (n-1))/(2*n-1);
            Console.WriteLine("E = " + E);

            Console.ReadLine();
        }
    }
}

