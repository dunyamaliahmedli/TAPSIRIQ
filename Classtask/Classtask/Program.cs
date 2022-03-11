using System;
using Classtask.Model;
namespace Classtask
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("bMW");
            Bus bus1 = new Bus("DAF");
            Console.WriteLine(car1.model, bus1.model);
        }
    }
}
