//Class Wardobe
using System;

namespace ConsoleApp1
{
    class Wardrobe : Furniture // Шкаф
    {
        public event Action ColorWardobe;

        public void ColorSelection(string color)
        {
            if (color != null)
            {
                ColorWardobe?.Invoke();
            }

            
        }

        public Wardrobe()
        {
        }

        public Wardrobe(int a)
        {
            count = a;
        }

        string wardrobe_view;
        int number_of_doors;

        public string Wardrobe_view
        {
            set { wardrobe_view = value; }
            get { return wardrobe_view; }
        }

        public int Number_of_doors
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine(" Конструкции не существует! ");
                }
                else
                {
                    number_of_doors = value;
                }
            }
            get { return number_of_doors; }
        }

        public Wardrobe(string a, double b, double c, double d, double e, string wardrobe_view, int number_of_doors) : base(a, b, c, d, e)
        {
            Wardrobe_view = wardrobe_view;
            Number_of_doors = number_of_doors;
        }

        public void ShowWardrobe()
        {
            base.ShowInfo();
            Console.WriteLine("Вид шкафа - {0}, кол-во дверей - {1}", wardrobe_view, number_of_doors);
        }
    }
}
