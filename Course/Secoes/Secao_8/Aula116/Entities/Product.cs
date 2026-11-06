using System.Globalization;

namespace Course.Secoes.Secao_8.Aula116.Entities;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
    
    public virtual string PriceTag()
    {
        return Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}