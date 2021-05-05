using System;

namespace exercicio.extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero romano de 1 a 10:");
            string numero = Console.ReadLine().ToLower();
            
            switch (numero)
            {
                case "i":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 1");
                    break;
                case "ii":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 2");
                    break;
                case "iii":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 3");
                    break;
                case "iv":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 4");
                    break;
                case "v":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 5");
                    break;
                case "vi":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 6");
                    break;
                case "vii":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 7");
                    break;
                case "viii":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 8");
                    break;
                case "ix":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 9");
                    break;
                case "x":
                    Console.WriteLine("Em algarismos Indo-Arábicos ele vale: 10");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Este numero nao esta dentro dos valores que foi pedido!!!");
                    break;
            }
            
        }
    }
}
