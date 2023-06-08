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
            List<Dog> dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            
            foreach(var item in dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}
