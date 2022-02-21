using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.ShowInfo();
            cat.ShowInfo();
            Console.ReadKey();
        }

        abstract class Animal

        {

            public abstract void Say();
            public abstract string Name { get; set; }
            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Say();
            }
              
        }
        class Dog:Animal
        {
            string name="Собака";
            public override string Name
            {
                get 
                {
                    return name;
                }
                set 
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.WriteLine("Гав");
            }
        }
        class Cat : Animal
        {
            string name = "Кошка";
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.WriteLine("Мяу");
            }
        }
    }
}
