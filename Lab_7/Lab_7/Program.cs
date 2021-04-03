using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x_min,x_max, y,  x, h, k=0;
            string[] str = File.ReadAllLines(@"input.txt"); 
            x_min = Convert.ToDouble(str[0]); // x_min = -2
            x_max = Convert.ToDouble(str[1]); // x_max = 7
            x = Convert.ToDouble(str[2]); //x =3,14
            h = x_max/Convert.ToDouble(str[3]); // увеличиваем х на определенное значение 
            StreamWriter sr = new StreamWriter(@"output.txt");
            for (double i = x_min; i < x_max && k<8; i += 0.1)
            {
                y =Math.Pow(Math.E,-x)*Math.Sin((x*Math.PI)/2);
               
                sr.WriteLine( "y = " + y.ToString());

               x += h;
                k++;
            }
            sr.Close();
        }
    }
}
