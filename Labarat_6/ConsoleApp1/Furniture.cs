//Class Furniture
using System;

namespace ConsoleApp1
{
    class Furniture : IPoFany, ISquare, ICloneable, IComparable<Furniture>, IEquatable<Furniture> //Мебель!
    {
        string material;
        double weight, price, height, width; 
        public int count;
       
    public string Name{ get; set; }
    public string Material{ get; set; }
    public int Price { get; set; }

        public override string ToString()
        {
            return "PRICE: " + Price + "   NAME: " + Name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Furniture objAsPart = obj as Furniture;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public int SortByNameAscending(string name1, string name2)
        {
          return name1.CompareTo(name2);
        }
        public int CompareTo(Furniture comparePart)
        {
            
            if (comparePart == null)
                return 1;
            else
                return this.Price.CompareTo(comparePart.Price);
        }
        public override int GetHashCode()
        {
            return Price;
        }
        public bool Equals(Furniture other)
        {
            if (other == null) return false;
            return (this.Price.Equals(other.Price));
        }

        public event Action FreeDelivery;
        public event EventHandler PaidDelivery;
        
        public void TakeDelivery( int sum)
        {
            if (sum >= 3500)
            {
                FreeDelivery?.Invoke();
            }

            else 
            {              
                PaidDelivery?.Invoke(this, null);
            }
        }

        public object Clone()
        {
            return new Furniture { Title = this.Title };
        }

        public double Square()
        {
            return height * width;
        }

        public void Print_the_receipt()
        {
            Console.WriteLine(" Заберите чек на кассе! ");
        }

        public string Title { get; set; } // для клонирования

        public double Delivery
        {
            set
            {

                if (price <= 5000)
                {
                    Console.WriteLine(" Бесплатная доставка от 5000 рублей! ");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }
        public double Weight
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(" Мебель имеет вес! ");
                }
                else
                {
                    weight = value;
                }
            }
            get { return weight; }
        }

        public Furniture(string a, double b, double c, double d, double e)
        {
            material = a;
            weight = b;
            price = c;
            height = d;
            width = e;
        }
        public Furniture()
        {
        }

        public Furniture(int a)
        {
            count = a;
        }
        public Furniture(string a)
        {
            Name = a;
        }

        //отразить
        public void ShowInfo()
        {
            Console.WriteLine("Характеристика: материал - {0}, вес - {1} кг., цена - {2} руб., размер - {3}*{4} см^2",
                         material, weight, price, height, width);
        }
    }
}
