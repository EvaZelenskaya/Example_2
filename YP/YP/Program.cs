using System;

namespace YP
{
    public abstract class Client
    {
        public abstract void PrintInfo();
        public abstract bool IsClientByDate(DateTime date);
    }

    public class Investor : Client
    {
        public string Surname { get; set; }
        public DateTime DepositDate { get; set; }
        public decimal DepositAmount { get; set; }
        public double DepositInterest { get; set; }

        public Investor(string surname, DateTime depositDate, decimal depositAmount, double depositInteres)
        {
            Surname = surname;
            DepositDate = depositDate;
            DepositAmount = depositAmount;
            DepositInterest = depositInteres;
        }


        public override void PrintInfo()
        {
            Console.WriteLine("Фамилия вкладчика: {0}", Surname);
            Console.WriteLine("Дата открытия вклада: {0}", DepositDate.ToShortDateString());
            Console.WriteLine("Размер вклада: {0}", DepositAmount);
            Console.WriteLine("Процент по вкладу: {0}", DepositInterest);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (DepositDate == date)
                return true;
            return false;
        }
    }

    public class Creditor : Client
    {
        public string Surname { get; set; }
        public DateTime CreditDate { get; set; }
        public decimal CreditAmount { get; set; }
        public double CreditInterest { get; set; }
        public decimal CreditBalance { get; set; }

        public Creditor(string surname, DateTime creditDate, decimal creditAmount, double creditInterest,
                        decimal creditBalance)
        {
            Surname = surname;
            CreditDate = creditDate;
            CreditAmount = creditAmount;
            CreditInterest = creditInterest;
            CreditBalance = creditBalance;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Фамилия вкладчика: {0}", Surname);
            Console.WriteLine("Дата выдачи кредита: {0}", CreditDate.ToShortDateString());
            Console.WriteLine("Размер кредита: {0}", CreditAmount);
            Console.WriteLine("Процент по кредиту: {0}", CreditInterest);
            Console.WriteLine("Остаток долга: {0}", CreditBalance);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (CreditDate == date)
                return true;
            return false;
        }
    }

    public class Organization : Client
    {
        public string Name { get; set; }
        public DateTime AccountDate { get; set; }
        public int AccountNumber { get; set; }
        public decimal AccountAmount { get; set; }

        public Organization(string name, DateTime accountDate, int accountNumber, decimal accountAmount)
        {
            Name = name;
            AccountDate = accountDate;
            AccountNumber = accountNumber;
            AccountAmount = accountAmount;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Название организации: {0}", Name);
            Console.WriteLine("Дата открытия счета: {0}", AccountDate.ToShortDateString());
            Console.WriteLine("Номер счета: {0}", AccountNumber);
            Console.WriteLine("Сумма на счету: {0}", AccountAmount);
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (AccountDate == date)
                return true;
            return false;
        }
    }

    
    public class CurrencyConverter : Client
    {

        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }
        public DateTime NowDate { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Чек!");
            Console.WriteLine("Дата: 21.05.2021");
            Console.WriteLine("Время: 15:45:12");
            Console.WriteLine("Операция: обмен валют");
            Console.WriteLine("Банк: ООО <Восточный>");
        }

        public override bool IsClientByDate(DateTime date)
        {
            if (DateTime.Now == date)
                return true;
            return false;
        }
        public CurrencyConverter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ConvertToUsd(double value)
        {
            return value / USD;
        }

        public double ConvertToEur(double value)
        {
            return value / EUR;
        }

        public double ConvertToRub(double value)
        {
            return value / RUB;
        }

        public double ConvertFromUsd(double value)
        {
            return USD * value;
        }

        public double ConvertFromEur(double value)
        {
            return EUR * value;
        }

        public double ConvertFromRub(double value)
        {
            return RUB * value;
        }
    }

    public class Program
    {
        public static void Main(string[] args)

        {
            Client[] clientDataBase = new Client[]
                {
                    new Investor("Пурокин", new DateTime(2020,5,7), 250178.597m, 20.15),
                    new Investor("Петров", DateTime.Now, 12178.867m, 18.75),
                    new Creditor("Обленков", new DateTime(2012, 8, 9), 12178.867m, 18.75, 578.89m),
                    new Creditor("Разоров", new DateTime(2017, 7, 19), 12178.867m, 18.75, 578.89m),
                    new Organization("ТитанСтрой №1", new DateTime(2019,2,18), 123456785, 7894623.7834m),
                    new Organization("Феррум", new DateTime(2020,3,8), 456456785, 7894623.7834m)
                };

            foreach (Client client in clientDataBase)
            {
                client.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine();

            DateTime askDate = new DateTime(2020, 3, 8);
            int foundClients = 0;

            foreach (Client client in clientDataBase)
            {
                if (client.IsClientByDate(askDate))
                {
                    client.PrintInfo();
                    foundClients++;
                    Console.WriteLine();
                }
            }
            if (foundClients == 0)
            {
                Console.WriteLine("Клиенты по данной дате не найдены");
            }
            Console.WriteLine("Для совершения валютной операции: нажмите любую клавишу");
            Console.ReadLine();
            var converter = new CurrencyConverter(76.36, 90.43, 1);

            Console.WriteLine("Choose option:");
            Console.WriteLine("1: Convert to RUB");
            Console.WriteLine("2: Convert from RUB");
          
            int k = int.Parse(Console.ReadLine());
            if (k == 1 || k == 2)
            {
                switch (k)
                {
                    case 1:
                        ConvertTo(converter);
                        break;
                    case 2:
                        ConvertFrom(converter);
                        break;
                }
                Console.WriteLine("Done");
            }
            else Console.WriteLine("Выберите одну из существующих функций! ");

            
            Console.ReadKey();
        }

        private static void ConvertTo(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1: Convert from USD");
            Console.WriteLine("2: Convert from EUR");
            Console.WriteLine("3: Convert from RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount");

            var input = double.Parse(Console.ReadLine());

            if (option == 1 || option == 2 || option==3)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine(currencyConverter.ConvertFromUsd(input));
                        break;
                    case 2:
                        Console.WriteLine(currencyConverter.ConvertFromEur(input));
                        break;
                    case 3:
                        Console.WriteLine(currencyConverter.ConvertFromRub(input));
                        break;
                }
            }
            else Console.WriteLine("Выберите одну из существующих валют! ");
        }

        private static void ConvertFrom(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1: Convert to USD");
            Console.WriteLine("2: Convert to EUR");
            Console.WriteLine("3: Convert to RUB");
            double option;
            if (double.TryParse(Console.ReadLine(), out option))
                Console.WriteLine("");
            else
                Console.Write("Ошибка ввода! Введите еще раз: ");
            //var option = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter amount");

            var input = double.Parse(Console.ReadLine());
            if (option == 1 || option == 2 || option == 3)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine(currencyConverter.ConvertToUsd(input));
                        break;
                    case 2:
                        Console.WriteLine(currencyConverter.ConvertToEur(input));
                        break;
                    case 3:
                        Console.WriteLine(currencyConverter.ConvertToRub(input));
                        break;
                }
            }
            else Console.WriteLine("Ошибка! Выберите одну из существующих валют! ");
        }
    }
   
}
