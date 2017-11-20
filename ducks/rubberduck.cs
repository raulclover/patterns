using strategySample.fly;
using strategySample.quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace strategySample.ducks
{
    class rubberduck : duckbase
    {
        public rubberduck()
        {
            flyBehavior = new noFly();
            quackBehavior = new simpleQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm rubber duck!");
        }

        
    }
}