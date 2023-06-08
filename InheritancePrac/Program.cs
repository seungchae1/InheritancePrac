using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                 new Dog(), new Dog(), new Dog(),
                  new Cat(), new Cat(), new Cat()
            };
            
            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();
                if (item is Dog) ((Dog)item).Bark();
                if (item is Cat) ((Cat)item).Meow();
            }
        }
    }
}
