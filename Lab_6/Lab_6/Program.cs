using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Lab_3
{
    public   abstract class Program
    {
        public double Cash { get; set; }
        static void Main(string[] args)
        {
            
            Processor r1 = new Processor("ERD", 896, 10, 10);
            Console.WriteLine("RESULT: " + r1.Cost +" //  "+r1.ClockFrequency+ "  //  "+ r1.Brand);
            Processor r4 = new Processor("ELO", 456, 12, 10);


            Motherboard r2 = new Motherboard("KIT");
          
            Console.WriteLine(r1.Equals(r2));
            Console.WriteLine(r1.GetHashCode());
            Console.WriteLine(r4.CasheSize);
            Console.ReadKey();
        }
    }


    
    public class Processor 
    {
        private string brand;
        private uint casheSize;
        private uint clockFrequency;
        private decimal cost;

    public Processor(string brand)
    {
            this.brand = brand;
    }
    public Processor()
    {

    }
    public Processor(string brand, uint clockFrequency, uint casheSize, decimal cost)
        {
            Brand = brand;
            ClockFrequency = clockFrequency;
            CasheSize = casheSize;
            Cost = cost;
        }

        public Processor(Processor other)
        {
            brand = other.brand;
            clockFrequency = other.clockFrequency;
            casheSize = other.casheSize;
            cost = other.cost;
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Текстовое значение марки не может быть пустым.");
                brand = value;
            }
        }

        public uint ClockFrequency
        {
            get { return clockFrequency; }
            set
            {
                if (value == 0)
                    throw new Exception("Значение тактовой частоты не может равняться нулю.");
                clockFrequency = value;
            }
        }

        public uint CasheSize
        {
            get { return casheSize; }
            set
            {
                if (value == 0)
                    throw new Exception("Объем кэша не может равняться нулю.");
                casheSize = value;
            }
        }

        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                    throw new Exception("Стоимость процессора не может быть отрицательной.");
                cost = value;
            }
        }
    }
    public class Motherboard 
    {
        private uint ram;
        private string ram_4;

        public Motherboard(Processor processor, uint ram)
        { 
            Processor = new Processor(processor);
            Ram = ram;
            
        }
       
        public Motherboard(string brand_4)
        {
            ram_4 = brand_4;
        }
        public Motherboard()
        {
            

        }

        public Processor Processor { get; set; }

        public uint Ram
        {
            get { return ram; }
            set
            {
                if (value == 0)
                    throw new Exception("Количество оперативной памяти не может равняться нулю.");
                ram = value;
            }
        }
    }

}


