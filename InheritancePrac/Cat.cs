using System;
namespace InheritancePrac
{
    internal class Cat : Animal
    {
        public int Age { get; set; }
        public Cat()
        {
            this.Age = 0;
        }
        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}