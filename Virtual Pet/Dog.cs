using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string favoriteFood)
        {
            Name = name;
            Age = age;
            FavoriteFood = favoriteFood;
        }
    }
}
