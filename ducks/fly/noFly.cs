using System;
using System.Collections.Generic;
using System.Text;

namespace strategySample.fly
{
    public class noFly: IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly!");
        }
    }
}
