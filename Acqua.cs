public class Acqua : Prodotto
{
    public float capacity { get; set; }
    public Acqua(string name, string description, double price, float capacity) : base(name, description, price)
    {
        this.capacity = capacity;
    }
}
