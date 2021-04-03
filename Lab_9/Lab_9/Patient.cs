using System;
using System.Globalization;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Computer MKD = new Computer { title = "MKD", clock_speed = "400", isGood= false };
            Computer BRS = new Computer { title = "BRS", clock_speed = "200", isGood = true };

             MKD.printAboutObject();
             BRS.printAboutObject();
           
            



            Console.ReadKey();
        }
    }
    public class Computer
    {
        TextInfo textInfo = new CultureInfo("ru-RU", false).TextInfo;
        private string Title;

        private string Clock_speed;
        private bool IsGood;
        private string s_isGood;

        public string title
        {
            get { return Title; }
            set { Title = textInfo.ToTitleCase(value); } //Вот здесь идет проверка регистра символов.
        }

        public string clock_speed
        {
            get { return Clock_speed; }
            set { Clock_speed = textInfo.ToTitleCase(value); } //Вот здесь идет проверка регистра символов.
        }
        public bool isGood
        {
            get { return IsGood; }
            set { IsGood = value; if (isGood==true) { this.s_isGood = "присутствует"; } else { this.s_isGood = "отсутсвует"; } }
        }

        public void printAboutObject()
        { Console.WriteLine($"Название процессора: {title}, тактовая частота: {clock_speed} мегагерц, есть сетевая плата?: {s_isGood} "); }

        

        


    }
}