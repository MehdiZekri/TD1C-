using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_N_1_CSharp
{
	class Coubeh
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la somme d'argent :");
            int somme = int.Parse(Console.ReadLine());

            int billet100 = somme / 100;
            somme %= 100;
            int billet50 = somme / 50;
            somme %= 50;
            int billet10 = somme / 10;
            somme %= 10;
            int billet5 = somme / 5;
            somme %= 5;
            int piece1 = somme;

            Console.WriteLine("Décomposition de la somme :");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{billet100} billet(s) de 100");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{billet50} billet(s) de 50");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{billet10} billet(s) de 10");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{billet5} billet(s) de 5");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{piece1} pièce(s) de 1");
            Console.ResetColor();
            Console.Read();
        }
    }
}
