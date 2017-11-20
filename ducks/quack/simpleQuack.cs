using System;
using System.Collections.Generic;
using System.Text;

namespace strategySample.quack
{
    public class simpleQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
