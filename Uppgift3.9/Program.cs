using System;
namespace Uppgift3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition med 1 eller 2 plustecken");
            string problem = Console.ReadLine();

            short plusIndex1 = (short)problem.IndexOf('+');
            short plusIndex2 = (short)problem.IndexOf('+',plusIndex1+1);

            float tal1 = float.Parse(problem[..plusIndex1]);
            float tal2;
            float tal3 = 0;

            if (plusIndex2 == -1)
            {
                tal2 = float.Parse(problem[(plusIndex1+1)..]);
            }
            else
            {
                tal2 = float.Parse(problem[(plusIndex1+1)..plusIndex2]);
                tal3 = float.Parse(problem[(plusIndex2 + 1)..]);
            }

            Console.WriteLine($"={tal1 + tal2 + tal3}");

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}