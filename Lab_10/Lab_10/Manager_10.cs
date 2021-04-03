using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab_10
{
    class Manager_10
    {
        TextInfo textInfo = new CultureInfo("ru-RU", false).TextInfo;
        private string Name;
        private string s_isGood;
        private bool IsGood;
        private int Age;

        public string name
        {
            get { return Name; }
            set { Name = textInfo.ToTitleCase(value); } //Вот здесь идет проверка регистра символов.
        }

        public bool isGood
        {
            get { return IsGood; }
            set { IsGood = value; if (isGood) { this.s_isGood = "good"; } else { this.s_isGood = "bad"; } }

        }
        public int age
        {
            get { return Age; }
            set { Age = value; if (value < 0) this.Age = 0; } //В случае отрицательного значения ставится 0. 
        }
        public void printAboutObject() {Console.WriteLine($"I'm {name}, {age} years old & I {(isGood ? "good" : "bad")} worker");}
        int type { get; set; }
        public string name_10;
        public int age_10;
        public Manager_10() { name_10 = "Новый стажёр"; age_10 = 0; }      // 1 конструктор без параметров
        public Manager_10(string n) { name_10 = n; age_10 = 6; }         // 2 конструктор с одним параметром
        public Manager_10(string n, int a) { name_10 = n; age_10 = a; }
        public Manager_10(Manager_10 obj){ name_10 = obj.name_10; }
    public void GetInfo()
        {
            Console.WriteLine($"{name_10} - менеджер;  Стаж: {age_10}");
        }

    }
}
