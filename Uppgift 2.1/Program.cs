using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken stad kommer du ifrån? ");
            String stad = Console.ReadLine();
            Console.WriteLine("Vad är ditt dröm resemål?");
            String resemål = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Hej " + stad + "'s bo. Jag hoppas att du kan åka till " + resemål + " någon gång.");
        }
    }
}