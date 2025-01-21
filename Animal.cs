using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }

        public virtual void Voice()
        {
            Console.WriteLine("Мычание");
        }
    }
    public class Dog : Animal
    {
        public string Nickname { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Кличка: {Nickname}");
        }

        public override void Voice()
        {
            Console.WriteLine("Гав-Гав");
        }
    }

    public class Cat : Animal
    {
        public string Color { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Окраска: {Color}");
        }

        public override void Voice()
        {
            Console.WriteLine("Мяу-Мяу");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Animal myanimal = new Animal { Name = "Животное", Age = 1 };
                Dog dog = new Dog { Name = "Собака", Age = 2, Nickname = "Шарик" };
                Cat cat = new Cat { Name = "Кошка", Age = 3, Color = "Черный" };

                List<Animal> animals = new List<Animal> { myanimal, dog, cat };


                foreach (Animal animal in animals)
                {
                    animal.Show();
                    animal.Voice();
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }

}


