public class SacchettoFrutta : Prodotto
{
    public int quantity { get; set; }
    public SacchettoFrutta(string name, string description, double price, int quantity) : base(name, description, price)
    {
        this.quantity = quantity;
    }
}
