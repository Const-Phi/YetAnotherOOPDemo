using System;

namespace Polymorphic
{
    abstract class Animal
    {
        public abstract void Say();
    }

    class Cat : Animal
    {
        public override void Say()
        {
            Console.WriteLine("Мяу!");
        }
    }

    class Dog : Animal
    {
        public override void Say()
        {
            Console.WriteLine("Гав!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animal[] { new Cat(), new Dog() };
            foreach (var animal in animals)
                animal.Say();
        }
    }
}
