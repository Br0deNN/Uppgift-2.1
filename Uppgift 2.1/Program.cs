using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favorit bok?");
            string Bok = Console.ReadLine();
            Console.WriteLine("Din favorit bok är " + Bok);
            Console.ReadKey();
        }
    }
}
