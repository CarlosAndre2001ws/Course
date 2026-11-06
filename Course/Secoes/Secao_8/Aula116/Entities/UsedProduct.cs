namespace Course.Secoes.Secao_8.Aula116.Entities;

public class UsedProduct: Product
{
    public DateTime ManufactureDate { get; set; }

    public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }
}