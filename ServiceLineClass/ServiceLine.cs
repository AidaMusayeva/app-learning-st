using System;
namespace Abstacts
{
    public class ServiceLine : OrderLine
    {
    public decimal FlatFee;
    public ServiceLine(string description,decimal flatFee):base (description)
    {
    FlatFee=flatFee;
    }
        public override decimal CalculateTotal()
        {
            return FlatFee;
        }
    }
}