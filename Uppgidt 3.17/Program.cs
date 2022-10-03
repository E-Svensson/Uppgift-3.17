using System;

namespace Uppgift_317
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal.");
            Console.WriteLine(" ");

            Console.Write("Tal 1: "); double tal1 = double.Parse(Console.ReadLine());
            Console.Write("Tal 2: "); double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Välj nu ett av de fyra räknesätten (1-4).");
            Console.WriteLine(" ");

            Console.WriteLine("1 = addition");
            Console.WriteLine("2 = subtraktion");
            Console.WriteLine("3 = multiplikation");
            Console.WriteLine("4 = division");
            Console.WriteLine(" ");

            double svar1 = tal1 + tal2;
            double svar2 = tal1 - tal2;
            double svar3 = tal1 * tal2;
            double svar4 = tal1 / tal2;


            Console.Write("Välj här: "); int val = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            switch (val)
            {
                case 1:
                    Console.WriteLine($"Svaret blev då: {tal1} + {tal2} = {svar1}");
                    break;
                case 2:
                    Console.WriteLine($"Svaret blev då: {tal1} - {tal2} = {svar2}");
                    break;
                case 3:
                    Console.WriteLine($"Svaret blev då: {tal1} * {tal2} = {svar3}");
                    break;
                case 4:
                    Console.WriteLine($"Svaret blev då: {tal1} / {tal2} = {svar4}");
                    break;
                default:
                    Console.WriteLine("Ditt dumme fan.");
                    break;
            }
        }
    }
}