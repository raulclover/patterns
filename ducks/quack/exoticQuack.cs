using System;
using System.Collections.Generic;
using System.Text;

namespace strategySample.quack
{
    class exoticQuack: IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Meow!");
        }
    }
}
