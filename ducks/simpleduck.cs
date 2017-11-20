using strategySample.fly;
using strategySample.quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace strategySample.ducks
{
    class simpleduck : duckbase
    {
        public simpleduck()
        {
            quackBehavior = new simpleQuack();
            flyBehavior = new simpleFly();
        }
        public override void Display()
        {
            Console.WriteLine("I'm simple duck!");
        }
      
    }
}
