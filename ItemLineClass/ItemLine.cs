namespace Abstacts
{
    public class ItemLine : OrderLine
    {
        public decimal Price;
        public int Quantity;
        public ItemLine(string description,decimal price, int quantity):base(description)
        {
            Price=price;
            Quantity=quantity;

        }
        public override decimal CalculateTotal()
        {
            return Price * Quantity;
        }

    }
}