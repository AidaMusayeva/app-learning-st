using System;
namespace Abstacts
{
    public abstract class OrderLine
    {
        public string Description;
        public OrderLine(string description)
        {
            Description=description;
        
        }
        public abstract decimal CalculateTotal();
        public void PrintInfo()
        {
            Console.WriteLine($"Descrition:{Description},Total:{CalculateTotal()}");
        }
    }
}