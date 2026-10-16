using System;
using System.Collections.Generic;
using System.Text;

namespace BalikTutma
{
    internal class Fish
    {

        public string name = "";
        public int point;

        public Rarity rarity;

        public Fish(string name, int point, Rarity rarity)
        {
            this.name = name;
            this.point = point;
            this.rarity = rarity;
        }

        public void Describe()
        {
            Console.WriteLine($" Fish: ({name}) , Point: ({point}) Rare : ({rarity})");
        }

    }
    enum Rarity
    {
        Common,      
        Rare,          
        Epic,       
        Legendary        
    }
}
