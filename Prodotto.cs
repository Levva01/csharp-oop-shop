
using System.Reflection.PortableExecutable;

public class Prodotto
{
    private int code;
    private string name;
    private string description;
    private double price;
    private int iva = 25;

    public Prodotto(string name, string description, double price)
    {
        this.name = name;
        this.description = description;
        this.price = price;
    }

    //getter
    public int GetCode() { return this.code; }
    public string GetName() { return this.name; }
    public string Description() { return this.description; }
    public double GetPrice() { return this.price; }
    public int GetIva() { return this.iva; }

    //setter
    private void setCode(int code) { this.code = code; }
    public void SetName(string name) { this.name = name; }
    public void setDescription(string description) { this.description = description; }
    public void SetPrice(double price) { this.price = price; }
    public void SetIva(int iva) { this.iva = iva; }
    
    public int CalcoloRandom()
    {
        int n = new Random().Next(1, 999999);
        return n;
    }

    public double PrezzoBase()
    {
        return GetPrice();
    }

    public double PrezzoTassato()
    {
        return PrezzoBase() + (PrezzoBase() * (double)GetIva() / 100);
    }

    public string GetFullName()
    {
        return GetCode().ToString() + GetName();
    }


}
