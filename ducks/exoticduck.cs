using strategySample.fly;
using strategySample.quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace strategySample.ducks
{
    class exoticduck: duckbase
    {
        public exoticduck()
        {
            quackBehavior = new exoticQuack();
            flyBehavior = new exoticFly();
        }
        public override void Display()
        {
            Console.WriteLine("I'm exotic duck!");
        }

        
    }
}
