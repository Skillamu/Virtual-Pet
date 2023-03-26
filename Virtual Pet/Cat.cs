using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Virtual_Pet
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string favoriteFood)
        {
            Name = name;
            Age = age;
            FavoriteFood = favoriteFood;
        }
    }
}
