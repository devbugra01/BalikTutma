using System;
using System.Collections.Generic;
using System.Text;

namespace BalikTutma
{
    internal class Fish
    {

        public string name = "";
        public int point;

        public Fish(string name, int point)
        {
            this.name = name;
            this.point = point;
        }

        public void Describe()
        {
            Console.WriteLine($" Fish: {name} , Point: {point}");
        }
      
    }
}
