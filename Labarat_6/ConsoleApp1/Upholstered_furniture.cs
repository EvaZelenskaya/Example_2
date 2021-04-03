//Class Upholostered_furniture
using System;

namespace ConsoleApp1
{
    class Upholstered_furniture : Furniture // Мягкая мебель
    {
        public event Action Wholesale; // опт
        public event Action RetailSales; //розница
        public void Sale (int count)
        {
            if (count>= 99)
            {
                Wholesale?.Invoke();
            }

            else
            {
                RetailSales?.Invoke();
            }
        }
         public Upholstered_furniture()
        {
        }
        public Upholstered_furniture(int a)
        {
            count = a;
        }

        string upholstered_furniture_view;
        int number_of_upfur_legs;

        public string Upholstered_furniture_view
        {
            set { upholstered_furniture_view = value; }
            get { return upholstered_furniture_view; }
        }

        public int Number_of_upfur_legs
        {
            set
            {
                if (value < 4)
                {
                    Console.WriteLine(" Конструкции не существует! ");
                }
                else
                {
                    number_of_upfur_legs = value;
                }
            }
            get { return number_of_upfur_legs; }
        }

        public Upholstered_furniture(string a, double b, double c, double d, double e, string upholstered_furniture_view,
            int number_of_upfur_legs) : base(a, b, c, d, e)
        {
            Upholstered_furniture_view = upholstered_furniture_view;
            Number_of_upfur_legs = number_of_upfur_legs;
        }

        public void Show_Upholstered_furniture()
        {
            base.ShowInfo();
            Console.WriteLine("Вид мягкой мебели - {0}, кол-во ножек - {1}", upholstered_furniture_view, number_of_upfur_legs);
        }
    }
}
