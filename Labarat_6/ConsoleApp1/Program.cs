//Class Program
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IComparer
    {
        int Compare(object o1, object o2);
    }
    interface IPoFany 
    {
        double Delivery { get; set; } // свойство доставка мебели
        void Print_the_receipt(); //  метод печать чека
    }
    interface ISquare
    {
        double Square();
    }
    public interface ICloneable
    {
        object Clone();
    }
    
    public class MyList<T> :  IList // generic - класс
    {
     
        private object[] _contents = new object[8];
        private int _count;
               
        public MyList()
        {
            _count = 0;
        }

    public int Add(object value)
    {
            if (_count < _contents.Length)
            {
                _contents[_count] = value;
               
                _count++;

                return (_count - 1);
            }

            return -1;
    }

        public void Clear()
        {
            _count = 0;
        }
         public int Sort(string[] o1, string[] o2)
        {
            if(o1.Length > o2.Length)
            {
                return 1;
            }
            else if (o1.Length < o2.Length)
            {
                return -1;
            }
            return 0;
        }

        public void Insert(int index, object value)
        {
            if ((_count + 1 <= _contents.Length) && (index < Count) && (index >= 0))
            {
                _count++;

                for (int i = Count - 1; i > index; i--)
                {
                    _contents[i] = _contents[i - 1];
                }
                _contents[index] = value;
            }
        }
        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _contents[i] = _contents[i + 1];
                }
                _count--;
            }
        }
        ///////// НАДО - ТАК НАДО
        public bool Contains(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_contents[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_contents[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool IsFixedSize
        {
            get
            {
                return true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

       
       
        public object this[int index]
        {
            get
            {
                return _contents[index];
            }
            set
            {
                _contents[index] = value;
            }
        }
        
        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(_contents[i], index++);
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public object SyncRoot
        {
            get
            {
                return this;
            }
        }

        public void PrintContents()
        {
            Console.WriteLine($"Список имеет память на  {_contents.Length} эл-в, но сейчас {_count} эл-в.");
            Console.Write("Мебель на складе:");
            for (int i = 0; i < Count; i++)
            {
                Console.Write($" [{_contents[i]}] ");
            }
            Console.WriteLine();
        }

        public IEnumerator GetEnumerator()
        {
            return _contents.GetEnumerator();
        }
}

    public class Program
    {
        public static void Main(string[] args)
        {
            // Event Мягкая мебель и её продажа 
            Console.WriteLine("\n Event Мягкая мебель и её продажа :");
            Upholstered_furniture divanchik_1 = new Upholstered_furniture() ;
            Upholstered_furniture divanchik_2 = new Upholstered_furniture() ;
            divanchik_1.Wholesale += Divanchik_1_Wholesale;
            divanchik_1.RetailSales += Divanchik_1_RetailSales;
            divanchik_2.Wholesale += Divanchik_1_Wholesale;
            divanchik_2.RetailSales += Divanchik_1_RetailSales;


            divanchik_1.Sale(100);
            divanchik_2.Sale(12);
            // divanchik_1.Name = "кровать <Гармония сна> ";
            //  divanchik_1.Name = "кресло <Комфорт> ";


            //Event color wardobe
            Console.WriteLine("\n Event выбор цвета шкафа :");
            Wardrobe wardobe = new Wardrobe();
            wardobe.ColorWardobe += Wardobe_ColorWardobe;
            wardobe.ColorSelection("чёрный");

            //Event Table изменение назвавания
            Console.WriteLine("\n Event замена названия стульям :");
            var table = new Table();
            table.Name = "for_big_family";
            Console.WriteLine($"Прежнее название стола: {table.Name}.");
            table.NameChanged += new EventHandler(NameChanged);
            table.Name = "Гуд_дэй";

            // Event Furniture+ Доставка
            Console.WriteLine("\n Event бесплатная доставка :");
            Furniture furniture_1 = new Furniture();
            Furniture furniture_2 = new Furniture();
            furniture_2.Name = "ковёр <Мария> ";
            furniture_1.Name = "картина <Лондон> ";
          
            furniture_1.FreeDelivery += Furniture_FreeDelivery; //обработчик события
            furniture_2.FreeDelivery += Furniture_FreeDelivery; 
            furniture_1.PaidDelivery += Furniture_PaidDelivery;
            furniture_2.PaidDelivery += Furniture_PaidDelivery;

            furniture_1.TakeDelivery(3600);
            furniture_2.TakeDelivery(500);

            // Работа со списками
            Console.WriteLine("\n Работа со списками :");
            MyList<string> myList = new MyList<string>();
            var myList3 = new List<string>{ "Диван","Табуретка", "Тумба", "Зеркало",
                "Настольная лампа","Духовой шкаф", "Диван Бароко", "Стул" };

           // MyList<Furniture> fList = new MyList<Furniture> (); //Добавление элементов в список ( классов )
             List<Furniture> fList = new List<Furniture>();
            fList.Add(new Furniture() { Name = "Диван <Art>", Price = 34499 });
            fList.Add(new Furniture() { Name = "Табурет <Art>", Price = 3200 });
            fList.Add(new Furniture() { Name = "Тумба <Art>", Price = 2500 });
            fList.Add(new Furniture() { Name = "Зеркало <Art>", Price = 4200 });
            fList.Add(new Furniture() { Name = "Настольная лампа <Art>", Price = 1500 });
            fList.Add(new Furniture() { Name = "Духовой шкаф <Art>", Price = 17800 });
            fList.Add(new Furniture() { Name = "Стул <Art>", Price = 5600 });
            
            MyList<Table> tList = new MyList<Table>(); 
            MyList<Wardrobe> wList = new MyList<Wardrobe>(); 
           // MyList<Upholstered_furniture> uList = new MyList<Upholstered_furniture>(); 
            List<Upholstered_furniture> uList = new List<Upholstered_furniture>();
            uList.Add(new Upholstered_furniture() { Name = "Стул < RedMilk>", Price = 150000, Material = "Красное дерево" });
            uList.Add(new Upholstered_furniture() { Name = "Диван <Milk>", Price = 199999, Material = "Искусственная кожа" });
            uList.Add(new Upholstered_furniture() { Name = "Зеркало <PinkMilk>", Price = 150000, Material = "Стекло" });
            uList.Add(new Upholstered_furniture() { Name = "Кресло <Milk>", Price = 150000, Material = "Искусственная кожа" });

            var chair = "Стул";
            var divan_1 = "Диван";
           // var taburet ="Табуретка";
            var tumba = "Тумба";
            var mirror = "Зеркало";
            var n_lamp ="Настольная лампа";
            var d_sh = "Духовой шкаф";
            var bar = "Диван Бароко";
            var vaza = myList.Add("Ваза"); // изначально 1 эл-т
            myList.PrintContents();
            

            // добавляем элементы
                myList.Add(tumba);
                myList.Add(mirror);
                myList.Add(n_lamp);
                myList.Add(d_sh);
                myList.Add(bar);
                myList.Add(divan_1);
              //  myList.Add(taburet);
                Console.WriteLine("\n!!!1 - ADD!!!");
                myList.PrintContents();

            // вставляем элемент перед индексом 1
            Console.WriteLine("\n!!!2 - INSERT[2]!!!");
            myList.Insert(2, chair);
            myList.PrintContents();

            // удаляем элемент по индексу 2 
            myList.RemoveAt(0);
            Console.WriteLine("\n!!!3 - REMOVE_AT!!!");
            myList.PrintContents();

            // удаляем элемент "Стул"
            myList.Remove(vaza);
            Console.WriteLine("\n!!!4 - REMOVE!!!");
            myList.PrintContents();

            // сортировка элементов
            Console.WriteLine("\n!!!5 - SORT!!!");
            
            Console.WriteLine("\nBefore sort <Furniture>:");
            foreach (Furniture aPart in fList)
            {
                Console.WriteLine(aPart);
            }
            fList.Sort();// сортировка с с использованием стороннего компаратора
            //ИЛИ ТАК МОЖНО ЕЩЁ
           // fList.Sort(delegate (Furniture c1, Furniture c2) { return c1.Name.CompareTo(c2.Name); }); // по имени
            // fList.Sort(delegate (Furniture c1, Furniture c2) { return c1.Price.CompareTo(c2.Price); }); // по цене

            Console.WriteLine("\nAfter sort <Furniture>:");
            foreach (Furniture aPart in fList)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nBefore sort <Upholstered_furniture>:");
            foreach (Upholstered_furniture test in uList)
            {
                string name = (string)test.Name;
                string material = (string)test.Material;
                int price = (int)test.Price;
                Console.WriteLine(" Товар ({0}) - Материал ({1}) - Цена ({2})", name, material, price);
              
            }

            uList.Sort(delegate (Upholstered_furniture c1, Upholstered_furniture c2) { return c1.Material.CompareTo(c2.Material); }); // по материалу
            
            Console.WriteLine("\nAfter sort <Upholstered_furniture>:");
            foreach (Upholstered_furniture test in uList)
            {
                string name = (string)test.Name;
                string material = (string)test.Material;
                int price = (int)test.Price;
                Console.WriteLine(" Товар ({0}) - Материал ({1}) - Цена ({2})", name, material, price);
                
            }
            
            
            Console.WriteLine("\nBefore sort <Standart List>:");
            foreach (var aPart in myList3)
            {
                Console.WriteLine(aPart);
            }

            myList3.Sort();

            Console.WriteLine("\nAfter sort <Standart List>:");
            foreach (var aPart in myList3)
            {
                Console.WriteLine(aPart);
            }

            //очистка списка
            Console.WriteLine("\n!!!6 - CLEAR!!!");
            myList.Clear();
            myList.PrintContents();

            #region delegate
            //Furniture lampa = new Furniture("пластмасса", 0.2, 1500, 70, 50);

            //Table steklo = new Table("дерево", 5, 5600, 150, 100, "кухонный", 4);

            //Upholstered_furniture divan = new Upholstered_furniture("ткань", 10, 7000, 150, 200, "раскладной", 4);

            //Wardrobe bogem = new Wardrobe("дерево", 24, 13499, 210, 0.7, "книжный", 6);

            ////для клонирования
            //Furniture lampa_2 = new Furniture { Title = "for-night" };
            //Furniture lampa_3 = new Furniture { Title = "for-eat" };
            //Table steklo_2 = new Table("Luna");
            //Upholstered_furniture divan_2 = new Upholstered_furniture();
            //Wardrobe bogem_2 = new Wardrobe(3);

            //lampa.ShowInfo();
            //Console.WriteLine();

            //steklo.ShowTable();
            //Console.WriteLine();

            //divan.Show_Upholstered_furniture();
            //Console.WriteLine();

            //bogem.ShowWardrobe();
            //Console.WriteLine();

            ////проверка интерфейса подсчета площади
            //Console.WriteLine("S = {0} см^2", steklo.Square());
            //Console.WriteLine("S = {0} см^2", divan.Square());
            //Console.WriteLine("S = {0} см^2", lampa.Square());
            //Console.WriteLine("S = {0} см^2", bogem.Square());

            ////само клонирование
            //lampa_2 = (Furniture)lampa_3.Clone();
            //Console.WriteLine(lampa_2.Title);

            //Console.WriteLine("---------------ИНТЕРФЕЙС-------------");

            ////проверка свойства
            //lampa_2.Delivery = 300;
            //Console.WriteLine(lampa.Delivery);
            //Console.WriteLine(steklo.Delivery);
            //Console.WriteLine(divan.Delivery);
            //Console.WriteLine(bogem.Delivery);


            //bogem.Print_the_receipt(); // проверка метода
            #endregion
            Console.Read();
        }
        private static void Divanchik_1_RetailSales()
        {
            Console.WriteLine("Объём товара соответсвует розничной цене!");
        }
        private static void Divanchik_1_Wholesale()
        {
            Console.WriteLine("Товар будет рассчитан в соответсвии с оптовой ценой!");
        }
        private static void Wardobe_ColorWardobe()
        {
           
            Console.WriteLine("Отличный выбор цвета для Вашего шкафа!");
        }
        private static void Furniture_PaidDelivery(object sender, EventArgs e)
        {
            if (sender is Furniture)
            {
             Console.WriteLine($"{((Furniture)sender).Name} отличный выбор, но  бесплатная доставка от 3500 рублей");
            }
            if (sender is Table)
            {
                Console.WriteLine($"{((Table)sender).Name} отличный выбор, но  бесплатная доставка от 3500 рублей");
            }
            if (sender is Wardrobe)
            {
                Console.WriteLine($"{((Wardrobe)sender).Name} отличный выбор, но  бесплатная доставка от 3500 рублей");
            }
            if (sender is Upholstered_furniture)
            {
                Console.WriteLine($"{((Upholstered_furniture)sender).Name} отличный выбор, но  бесплатная доставка от 3500 рублей");
            }
        }
        private static void Furniture_FreeDelivery()
        {
            Console.WriteLine("Поздравляем с покупкой товара!");
          
        }
         public static void NameChanged(Object sender, EventArgs e)
        {
            
            Table character = (Table)sender;
            Console.WriteLine($"Новое название стола: {character.Name}.");
        }

     }
}

        
   
