public class Elettrodomestico : Prodotto
{
    public string Marca { get; set; }
    public Elettrodomestico(string name, string description, double price, string marca) : base(name, description, price)
    {
        this.Marca = marca;
    }
}
