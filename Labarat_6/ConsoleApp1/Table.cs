//Class Table
using System;

namespace ConsoleApp1
{
    class Table : Furniture // Стол!
    {
        public event EventHandler NameChanged;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "" ||
                    value == string.Empty)
                {
                    throw new ArgumentException("Укажите имя.");
                }
                          _name = value;

                if (NameChanged != null)
                {
                    NameChanged(this, new EventArgs());
                }
            }
        }
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
            set { table_view = value; }
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
}
