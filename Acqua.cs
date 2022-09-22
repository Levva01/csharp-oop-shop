public class Acqua : Prodotto
{
    public float Capacity { get; set; }
    public float Ph { get; }
    public string Sorgente { get; }

    private const double Gallone = 3.785;

    public Acqua(string name, string description, double price, float capacity, float ph, string sorgente) : base(name, description, price)
    {
        this.Capacity = capacity;
        this.Ph = ph;
        this.Sorgente = sorgente;
    }

    public void bevi(float litriDaBere)
    {
        Capacity -= litriDaBere;
    }

    public void riempi(float litriDaAggiungere)
    {
        if(litriDaAggiungere + Capacity > 1.5)
        {
            Capacity = 1.5f;
        } else
        {
            Capacity += litriDaAggiungere;
        }
    }

    public void svuota()
    {
        Capacity = 0;
    }

    public static double convertiGalloni(double litri)
    {
        return litri * Gallone;
    }

    public override void StampaProdotto(Acqua a)
    {
        Console.WriteLine(a.Capacity);
        Console.WriteLine(a.Ph);
        Console.WriteLine(a.Sorgente);

    }
}
