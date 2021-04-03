using System;
using System.Linq;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Бла-бла? блабла бла, бла бла. БлааАА!";
            string[] words = str.Split(new[] { ' ', '!', '?', ':', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            int averageLenght = words.Aggregate(0, (count, nextWord) => count += nextWord.Length) / words.Length;
            int k2 = averageLenght + 2;
            int k1 = averageLenght - 2;

            foreach (string word in str.Split(new char[] { ' ', ',', '.', ';', ':' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (word.Length == k2) {
                    Console.WriteLine(word);
                }
                else if ((word.Length == k1) || (word.Length == averageLenght))
                {
                    Console.WriteLine(word);
                }
            }
            Console.WriteLine("Средняя длина строки: {0}", averageLenght);
            Console.ReadLine();
        }
    }
}
