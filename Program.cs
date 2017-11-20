using strategySample.ducks;
using strategySample.fly;
using strategySample.quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace strategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<duckbase> ducks = new List<duckbase>();
            ducks.Add(new exoticduck());
            ducks.Add(new simpleduck());
            ducks.Add(new rubberduck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Fly();
                duck.Quack();

                Console.WriteLine();
            }

            rubberduck d = new rubberduck();
            d.Display();
            d.Swim();
            d.Quack();
            d.Fly();
            Console.WriteLine();
            d.setFlyBehavior(new exoticFly());
            d.setQuackBehavior(new exoticQuack());
            d.Quack();
            d.Fly();
            Console.ReadKey();
        }
    }
}
