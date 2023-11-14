using System.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<int> intRepository = new Repository<int>();
            intRepository.Add(5);
            intRepository.Add(8);
            intRepository.Add(60);

            Repository<string> stringRepository = new Repository<string>();
            stringRepository.Add("boston");
            stringRepository.Add("kyiv");
            stringRepository.Add("helsinki");

            var evenNumbers = intRepository.Find(x => x % 5 == 0);
            Console.WriteLine("Number which % 5 == 0:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            var fruitsWithA = stringRepository.Find(s => s.Contains("h"));
            Console.WriteLine("\nCities with 'h':");
            foreach (var fruit in fruitsWithA)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}