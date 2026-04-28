using System;
namespace Abstacts
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderLine[] orderLines =
            {
                new ItemLine("Laptop",1500m,3),
                new ItemLine("Mouse",25m,6),
                new ServiceLine("cleaning Service",100m),
                new ServiceLine("Installation Service",150m)
            };
            foreach(var line in orderLines)
            {
                line.PrintInfo();
            }
        } 
    }
}
