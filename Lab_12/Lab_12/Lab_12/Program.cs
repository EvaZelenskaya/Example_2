using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_12
{
    
        //Закрытые поля


        public class Paper
        {
            //Свойства + Поля

            public string nameP { get; set; }
            public Person author { get; set; }
            public DateTime data { get; set; }

            //Конструкторы

            public Paper(string nameP, Person author, DateTime data)
            {
                this.nameP = nameP;
                this.author = author;
                this.data = data;
            }

            public Paper()
            {
                nameP = "PlaceHolder_Book";
                author = new Person("Liza", "Bolotnova", new DateTime(2002, 7, 11));
                data = new DateTime(2000, 5, 3);
            }

            //Методы

            public override string ToString()
            {
                return string.Format("Author  {0} write book {1}. Data = {2}", nameP, author, data);
            }
        }
        public class Person
        {
            //Поля

            private string name;
            private string secondName;
            private DateTime birthDate;

            //Конструкторы

            public Person()
            {
                name = "PlaceHolder";
                secondName = "PlaceHolder2";
                birthDate = new DateTime(2015, 7, 20);
            }

            public Person(string name, string secondName, DateTime birthDate)
            {
                this.name = name;
                this.secondName = secondName;
                this.birthDate = birthDate;
            }

            //Свойства

            public string Name
            {
                get { return name; }
                set
                {
                    if (value.Length < 2)
                        Console.WriteLine("Name must be more than 2 characters");
                    else
                        name = value;
                }
            }

            public string SecondName
            {
                get { return secondName; }
                set
                {
                    if (value.Length > 16)
                        Console.WriteLine("Second name must be less than 16 characters");
                    else
                        secondName = value;
                }
            }

            public DateTime BirthDate
            {
                get { return BirthDate; }
                set
                {
                    if (value.Year < 1910 && value.Day > 31 && value.Day < 1 && value.Month < 1 && value.Month > 12)
                        Console.WriteLine("Please check your birthday date");
                    else
                        birthDate = value;
                }
            }

            public int intStdBdate
            {
                get
                {
                    return Convert.ToInt32(birthDate);
                }
                set
                {
                    birthDate = Convert.ToDateTime(value);
                }
            }

            //Методы

            public override string ToString()
            {
                return string.Format("{0} {1}\nDate of birth: {2}", name, secondName, birthDate);
            }

            public string ToShortString()
            {
                return "\n" + "Имя: " + name + "\n" + "Фамилия: " + secondName;
            }

            //Перечисляемый тип

            public enum TimeFrame { Year, TwoYears, Long }
        }
    namespace Lab12
    {
        class Program
        {
            static void Main(string[] args)
            {
                /////1/////
                ResearchTeam teamDisaster = new ResearchTeam("OW", "Team Disaster", 01, Person.TimeFrame.Year);
                Console.WriteLine(teamDisaster.ToShortString());
                /////2//////


                Paper[] pap = new Paper[] { new Paper(), new Paper() };
                try
                {
                    ResearchTeam t1 = new ResearchTeam
                    {
                        Last = Person.TimeFrame.Year,
                        NameOfOrg = "ooo",
                        NumberOFOrg = 03,
                        Theme = "ewq"
                    };
                    t1.ListOfPubs = pap;



                    Console.WriteLine(t1.ToString());
                }
                catch (System.NullReferenceException)
                {
                    Console.WriteLine("//////......////////");
                }
            }
        }
    }
    public class ResearchTeam
    {
        //Поля

        private string theme;
        private string nameOfOrg;
        private int numberOfOrg;
        private Person.TimeFrame last;
        private Paper[] listOfPubs;

        //Конструкторы

        public ResearchTeam(string theme, string nameOfOrg, int numberOfOrg, Person.TimeFrame last)
        {
            this.theme = theme;
            this.nameOfOrg = nameOfOrg;
            this.numberOfOrg = numberOfOrg;
            this.last = last;
        }

        public ResearchTeam()
        {
            theme = "Blank";
            nameOfOrg = "BlaBla";
            numberOfOrg = 0;
            last = Person.TimeFrame.Long;
        }

        public string Theme
        {
            get
            {
                return theme;
            }
            set
            {
                if (value.Length > 16 && value.Length < 2)
                    Console.WriteLine("Check your information!");
                else
                    theme = value;
            }
        }

        public string NameOfOrg
        {
            get
            {
                return nameOfOrg;
            }
            set
            {
                if (value.Length > 16 && value.Length < 2)
                    Console.WriteLine("Check your information!");
                else
                    nameOfOrg = value;
            }
        }

        public int NumberOFOrg
        {
            get
            {
                return numberOfOrg;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Check your information!");
                else
                    numberOfOrg = value;
            }
        }

        public Person.TimeFrame Last
        {
            get { return last; }
            set
            {
                if (true)
                    last = value;
            }
        }

        public Paper[] ListOfPubs
        {
            get
            {//
             //if (listOfPubs[listOfPubs.Length].data.Year > 2015)
                return listOfPubs;
                //else
                //return null;
            }
            set
            {
                listOfPubs = value;
            }
        }
        //
        public bool this[Person.TimeFrame Indexator]
        {
            get
            {
                if (this.last == Indexator)
                    return true;
                else
                    return false;
            }
        }
        //
        public void AddPapers(params Paper[] listOfPubs)
        {
            Array.Resize(ref listOfPubs, listOfPubs.Length + 1);
            //listOfPubs[listOfPubs.Length] = new Paper();
        }
        //
        public override string ToString()
        {
            return string.Format("\nTheme: {0}\nNameOfOrg: {1}\nNumberOfRed: {2}\nLast: {3}\nPublications: {4} ", theme, nameOfOrg, numberOfOrg, last, listOfPubs);
        }

        public virtual string ToShortString()
        {
            return string.Format("\nTheme: {0}\nNameOfOrg: {1}\nNumberOfRed: {2}\nLast: {3}\n", theme, nameOfOrg, numberOfOrg, Last);
        }
    }
}
