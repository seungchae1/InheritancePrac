using System;
namespace InheritancePrac
{
    internal class Cat : Animal
    {
        public void TestB()
        {
            //Private(); //error
            Protected();
            Public();
        }
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}