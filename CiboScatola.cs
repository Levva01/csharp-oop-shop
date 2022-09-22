public class CiboScatola : Prodotto
{
    public int Peso { get; set; }
    public CiboScatola(string name, string description, double price, int peso) : base(name, description, price)
    {
        this.Peso = peso;
    }

}