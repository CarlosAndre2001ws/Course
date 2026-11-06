namespace Course.Secoes.Secao_8.Aula116.Entities;

public class ImportedProduct: Product
{
    public double CustomsFee { get; set; }

    public ImportedProduct(string name, double price, double customsFee) : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }
    
}