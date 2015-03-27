using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{


    class Animal
    {

        protected string name;
        protected int cells;
        protected static int quantity = 0;

        public static int Quantity
        {
            get { return quantity; }
        }



        public Animal(int cells)
        {
            this.cells = cells;
        }


        public Animal()
        {
            //   this.name = (string)( this.GetType());
            quantity++;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Я животное, я ем");
        }
    }

        class Man : Animal
        {
            protected bool phonesmb = true;
            public  bool PhoneSmb
            {
                get
                {
                    Console.WriteLine("Я человек, я звоню");
                    return phonesmb;
                }
            }
        
            public override void Eat()
            {
                Console.WriteLine("Я человек, я люблю есть");
            }

        }

        class Batman : Man, IFlying
        {
            public void Fly()
            {
                Console.WriteLine("Я бетмен, я летаю");


            }

        }


  

    interface IFlying
    {
        void Fly();

    }



    class Bird : Animal, IFlying
    {
        int wingLength;

        public void Fly()
        {
            Console.WriteLine(name + " is flying");

        }
        public override void Eat()
        {
            Console.WriteLine("Я птица, я ем детей");

        }
    }


    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine(name + ": meow");

        }
        public override void Eat()
        {
            Console.WriteLine("Я кот, я ем");
        }

    }

    class Lion : Cat
    {
        public void Meow()
        {
            Console.WriteLine(name + ": RRRRR!!!");

        }
        public override void Eat()
        {
            Console.WriteLine("Я лев, я ем");
        }
    }

    class Bat : Animal, IFlying
    {
        int wingLength;

        public void Fly()
        {
            Console.WriteLine(name + " is flying");
            Console.WriteLine("Я летучая мышь, свалилась в камыш");
        }
    }

    class Program
    {
        static void Main()
        {
            int i = 0;
            int N = 4;


            Animal animal = new Animal();
            Bird bird = new Bird();
            Cat cat = new Cat();
            Lion lion = new Lion();


            Animal[] animals = new Animal[4];
            animals[0] = animal;
            animals[1] = bird;
            animals[2] = cat;
            animals[3] = lion;


            while (i < N)
            {
                animals[i].Eat();


                switch (i)
                {
                    case 1:
                        ((Bird)animals[i]).Fly();
                        break;

                    case 2:
                        ((Cat)animals[i]).Meow();
                        break;
                    case 3:
                        ((Lion)animals[i]).Meow();
                        break;
                }
                i++;
            }


            IFlying[] flying = new IFlying[2];
            Bat bat = new Bat();
            flying[0] = bat;
            flying[1] = bird;

            i = 0;
            while (i < 2)
            {
                flying[i].Fly();
                i++;
            }

            Man man = new Man();
            man.Eat();
 
        
            Batman batman = new Batman();
            batman.Fly();
            
            

      
           


            Console.WriteLine("Количество животных: " + Animal.Quantity);

            Console.ReadKey();
        }
    }
}
