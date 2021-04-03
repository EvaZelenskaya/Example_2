using System;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Manager manager_1 = new Manager { name = "Petrova", isGood = false, age = 24 };
Manager manager_2 = new Manager { name = "Silkina", isGood = true, age = 54 };
Manager manager_3 = new Manager { name = "Korginov", isGood = false, age = 36 };
Manager manager_4 = new Manager { name = "Abramov", isGood = true, age = 36 };

manager_3.printAboutObject();
manager_4.printAboutObject();*/
            Console.Write("Стаж менежера №3: ");
            int stazh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Тип менеджера # 1 : ");
            Manager_10 bob = new Manager_10(Console.ReadLine());     //вызов 2-ого конструктора с одним параметром 
            Manager_10 bar = new Manager_10();          // вызов 1-ого конструктора без параметров
            Console.WriteLine();
            Console.Write("Тип менеджера # 3 : ");
            Manager_10 seo = new Manager_10(Console.ReadLine(), stazh); // вызов 3-его конструктора с двумя параметрами
            Manager_10 nik = new Manager_10(bob); // вызов 4-го консруктора копирования 
            //бар-менеджер, SEO-менеджер,  СТРАХОВОЙ менеджер 

            bob.GetInfo();          
            bar.GetInfo();          
            seo.GetInfo();
            nik.GetInfo();
            Console.ReadKey();

        }
    }
}
