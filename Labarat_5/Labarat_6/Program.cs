using System;
using System.Reflection;

namespace Labarat_6
{
    interface IPoFany // объявление интерфейса
    {
        double Delivery { get; set; } // свойство доставка мебели
        void Print_the_receipt(); //  метод печать чека
    }
    interface ISquare
    {
        double Square();
    }
   /* public interface ICloneable
    {
        object Clone();
    }*/
    class Furniture : IPoFany, ISquare, ICloneable //Мебель!
    { 
        
        string material;
        double weight; // вес
        double price;
        double height; // высота
        double width; // ширина
        public int count;
        
        public object Clone()
        {
            return new Furniture {Title = this.Title };
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
            set {
                
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
            weight =b;
            price = c;
            height = d;
            width = e;
        }
        public Furniture()
        {
        }
       
        public Furniture( int a)
        {
            count = a;
        }

        //отразить
        public void ShowInfo()
        {
            Console.WriteLine("Характеристика: материал - {0}, вес - {1} кг., цена - {2} руб., размер - {3}*{4} см^2",
                         material, weight, price, height, width);
        }

       
    }
    class Table : Furniture // Стол!

    {
        public Table()
        {
        }
        
        public Table(int a)
        {
            count = a;
        }
        
        public Table(string a)
        {
            table_view = a;
        }
        
        string table_view;
        int number_of_table_legs;

        public string Table_view
        {
            set { table_view = value;}
            get { return table_view; }
        }
        
        public int Number_of_table_legs
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine(" У стола как мин. 1 ножка! ");
                }
                else
                {
                    number_of_table_legs = value;
                }
            }
            get { return number_of_table_legs; }
        }

        public Table(string a, double b, double c, double d, double e, string table_view, int number_of_table_legs) : base(a, b, c, d, e)
        {
            Number_of_table_legs = number_of_table_legs;
            Table_view = table_view;
        }
        
        public void ShowTable()
        {
            base.ShowInfo();
            Console.WriteLine("Вид стола - {0}, кол-во ножек стола - {1}", table_view, number_of_table_legs);
        }
    }

    class Upholstered_furniture : Furniture // Мягкая мебель
    {
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
            get { return number_of_upfur_legs;  }
        }

        public Upholstered_furniture(string a, double b, double c, double d, double e , string upholstered_furniture_view, 
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
    class Wardrobe : Furniture // Шкаф
    {
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

        public Wardrobe(string a, double b, double c, double d, double e, string wardrobe_view, int number_of_doors ) : base(a, b, c, d, e)
        {
            Wardrobe_view = wardrobe_view;
            Number_of_doors= number_of_doors;
        }

        public void ShowWardrobe()
        {
            base.ShowInfo();
            Console.WriteLine("Вид шкафа - {0}, кол-во дверей - {1}", wardrobe_view, number_of_doors);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
       
            Furniture lampa = new Furniture("пластмасса", 0.2, 1500, 70,50);
            
            Table steklo = new Table("дерево", 5, 5600, 150, 100 , "кухонный",4);
            
            Upholstered_furniture divan = new Upholstered_furniture("ткань", 10, 7000, 150, 200, "раскладной" , 4);
           
            Wardrobe bogem = new Wardrobe("дерево", 24, 13499, 210, 0.7, "книжный",6);
            
            //для клонирования
            Furniture lampa_2 = new Furniture { Title = "for-night"}; 
            Furniture lampa_3 = new Furniture { Title = "for-eat"}; 
            Table steklo_2 = new Table("Luna");
            Upholstered_furniture divan_2 = new Upholstered_furniture();
            Wardrobe bogem_2 = new Wardrobe(3);

            lampa.ShowInfo();  
            Console.WriteLine();
            
            steklo.ShowTable(); 
            Console.WriteLine();
            
            divan.Show_Upholstered_furniture();  
            Console.WriteLine();
            
            bogem.ShowWardrobe();
            Console.WriteLine();
            
            //проверка интерфейса подсчета площади
            Console.WriteLine("S = {0} см^2", steklo.Square());
            Console.WriteLine("S = {0} см^2", divan.Square());
            Console.WriteLine("S = {0} см^2", lampa.Square());
            Console.WriteLine("S = {0} см^2", bogem.Square());
            
            //само клонирование
            lampa_2 = (Furniture)lampa_3.Clone();
            Console.WriteLine(lampa_2.Title); 

            Console.WriteLine("---------------ИНТЕРФЕЙС-------------");
            

            //проверка свойства
            lampa_2.Delivery = 300;
            Console.WriteLine(lampa.Delivery);
            Console.WriteLine(steklo.Delivery);
            Console.WriteLine(divan.Delivery);
            Console.WriteLine(bogem.Delivery);
            
           
            bogem.Print_the_receipt(); // проверка метода
            Console.Read();
        }
    }
}