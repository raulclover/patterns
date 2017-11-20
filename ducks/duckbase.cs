using System;
using System.Collections.Generic;
using System.Text;
using strategySample.quack;
using strategySample.fly;

namespace strategySample.fly
{
    public abstract class duckbase
    {
        protected IQuackable quackBehavior;
        protected IFlyable flyBehavior;

        public duckbase()
        {
            flyBehavior = new simpleFly();
            quackBehavior = new simpleQuack();
        }
        public void Swim()
        {
            Console.WriteLine("I swim!");
        }

        public void Fly()
        {
            flyBehavior.Fly();
        }
        public void Quack()
        {
            quackBehavior.Quack();
        }

        public void setQuackBehavior(IQuackable newQuackBehavior)
        {
            quackBehavior = newQuackBehavior;
        }

        public void setFlyBehavior(IFlyable newFlyBehavior)
        {
            flyBehavior = newFlyBehavior;
        }


        public abstract void Display();
    }
}
