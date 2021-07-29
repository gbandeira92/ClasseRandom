using System;
using System.Collections.Generic;

namespace ClasseRandom
{
    class Dice
    {
        public int AmountOfSides { get; set; }
        public int RolledNumber { get; set; }

        public int RolledDice()
        {
            Random rd = new Random();
            RolledNumber = rd.Next(1, AmountOfSides + 1);
            return RolledNumber;
        }
        //public Dice()
        //{ }

        //public Dice(int AmountOfSides, int RolledNumber)
        //{
        //    this.AmountOfSides = AmountOfSides;
        //    this.RolledNumber = RolledNumber;
        //}

    }
}
