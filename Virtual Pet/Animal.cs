using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    public class Animal
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public string FavoriteFood { get; protected set; }

        public void Feed()
        {
            Console.WriteLine("Thank you for the food.");
        }

        public void Feed(string favoriteFood)
        {
            Console.WriteLine($"Mmm, my favorite food {favoriteFood}! Thank you!");
        }

        public void About()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Favorite food: {FavoriteFood}");
        }
    }
}
