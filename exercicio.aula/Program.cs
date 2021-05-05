using System;

namespace exemplo.aula03._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine().ToLower();

            string letra = nome.Substring(0, 1);

            switch (letra)
            {
                case "a":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu Nome começa com a vogal " + letra + " igual Abelha");
                    break;
                case "e":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu Nome começa com a vogal " + letra + " igual Elefante");
                    break;
                case "i":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu Nome começa com a vogal " + letra + " igual Igreja ");
                    break;
                case "o":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu Nome começa com a vogal " + letra + " igual Ovo");
                    break;
                case "u":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu Nome começa com a vogal " + letra + " igual Urubu");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu nome nao começa com uma vogal!");
                    break;
            }
            
        }
    }
}
