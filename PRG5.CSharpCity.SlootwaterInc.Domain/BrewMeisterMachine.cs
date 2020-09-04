using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PRG5.CSharpCity.SlootwaterInc.Domain
{

    /// <summary>
    /// These are the types we can brew
    /// </summary>
    public enum CoffeeType {
        Coffee,
        Ristretto,
        Espresso,
        Cappucino,
        [Description("Dit is geen Heineken maar docentkofie, want gratis")]
        Slootwater,
        LatteMachiatto
    }

    public class BrewMeisterMachine 
    {
        private List<CoffeeType> brewedCups;

        /// <summary>
        /// 
        /// </summary>
        public List<CoffeeType> BrewedCups {
            get {
                return brewedCups;
            }
        }

        private int cupsMade;

        public CoffeeType SelectedType { get; set; }

        public BrewMeisterMachine()
        {
            cupsMade = 0;
            SelectedType = CoffeeType.Slootwater;
            brewedCups = new List<CoffeeType>();
        }

        /// <summary>
        /// Clears calcium from machine, resets cupcounter
        /// </summary>
        /// <returns>true if decalcified, false otherwise</returns>
        public bool Decalcify()
        {
            if (cupsMade >= 5)
            {
                cupsMade = 0;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Brew Meister Inc. V2. coffeemaker.";
        }

        public string Brew()
        {
            if (cupsMade < 5)
            {
                brewedCups.Add(SelectedType);
                cupsMade++;
                return $"Een lekker bakje {SelectedType}!";
            }
            else
            {
                return "Machine moet ontkalkt worden.";
            }
        }
    }
}
