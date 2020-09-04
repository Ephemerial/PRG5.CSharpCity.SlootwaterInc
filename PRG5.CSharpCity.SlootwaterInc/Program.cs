using PRG5.CSharpCity.SlootwaterInc.Domain;
using System;
using System.Linq;

namespace PRG5.CSharpCity.SlootwaterInc
{
    class Program
    {
        static void Main(string[] args)
        {

            BrewMeisterMachine koffiezetter = new BrewMeisterMachine();
            Console.WriteLine($"Welkom bij onze {koffiezetter}");
            string commandKey = Console.ReadLine();
            while (!commandKey.Equals("X", StringComparison.OrdinalIgnoreCase))
            {
                switch (commandKey)
                {
                    case "1":
                        koffiezetter.SelectedType = CoffeeType.Coffee;
                        Console.WriteLine(koffiezetter.Brew());
                        break;
                    case "2":
                        koffiezetter.SelectedType = CoffeeType.Cappucino;
                        Console.WriteLine(koffiezetter.Brew());
                        break;
                    case "3":
                        koffiezetter.SelectedType = CoffeeType.Ristretto;
                        Console.WriteLine(koffiezetter.Brew());
                        break;
                    case "4":
                        koffiezetter.SelectedType = CoffeeType.Espresso;
                        Console.WriteLine(koffiezetter.Brew());
                        break;
                    case "5":
                        koffiezetter.SelectedType = CoffeeType.LatteMachiatto;
                        Console.WriteLine(koffiezetter.Brew());
                        break;
                    case "6":
                        koffiezetter.SelectedType = CoffeeType.Slootwater;
                        Console.WriteLine(koffiezetter.Brew());
                        break;
                    case "O":
                        Console.WriteLine(koffiezetter.Decalcify() ? "Ontkalkt!" : "Nog niet nodig!");
                        break;
                    default:
                        Console.WriteLine("Ken ik niet, je krijgt gewoon koffie!");
                        koffiezetter.SelectedType = CoffeeType.Coffee;
                        break;
                }

                commandKey = Console.ReadLine();
            }

            Console.WriteLine($"{koffiezetter.BrewedCups.Where(b => b == CoffeeType.Slootwater).Count()} kopjes {CoffeeType.Slootwater}");
           
            Console.WriteLine($"Thanks for drinking {koffiezetter} brews.");
        }
    }
}
