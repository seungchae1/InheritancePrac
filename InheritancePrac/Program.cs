using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Program
    {
        class Parent
        {
            public Parent() { Console.WriteLine("부모 생성자"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }
        }

        class Child : Parent
        {
            public Child() : base(10)
            {
                Console.WriteLine("Child() : base(10)");
            }
            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();

            //d.Private(); //error
            //d.Protected(); //error
            d.Public();

            List<Animal> animals = new List<Animal>
            {
                 new Dog(), new Dog(), new Dog(),
                  new Cat(), new Cat(), new Cat()
            };
            
            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();

                Dog dog = item as Dog;
                Cat cat = item as Cat;

                if (dog != null) ((Dog)item).Bark();
                if (cat != null) ((Cat)item).Meow();
            }
        }
    }
}
