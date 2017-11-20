using System;
using System.Collections.Generic;
using System.Text;

namespace strategySample.fly
{
    public class simpleFly: IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I Fly with wings");
        }
    }
}
