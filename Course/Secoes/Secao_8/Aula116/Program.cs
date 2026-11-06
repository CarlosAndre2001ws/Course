using System.Globalization;
using Course.Secoes.Secao_8.Aula116.Entities;

namespace Course.Secoes.Secao_8.Aula116;

public class Program
{
    public static void Run()
    {
        List<Product> products = new List<Product>();
        Console.Write("Enter the number of products: "); int numberOfProducts = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfProducts; i++)
        {
            Console.WriteLine($"Product #{i + 1} data: ");
            Console.Write("Common, used or imported (c/u/i) ? "); string typeOfProduct = Console.ReadLine();
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Price: "); double price =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            switch (typeOfProduct)
            {
                case "i":
                    Console.Write("Customs fee: "); double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product newProdImported = new ImportedProduct(name, price, customsFee);
                    products.Add(newProdImported);
                    break;
                
                case "u":
                    Console.Write("Manufacture date (DD/MM/YYYY): "); DateTime date = DateTime.Parse(Console.ReadLine());
                    Product newProdUsed = new UsedProduct(name, price, date);
                    products.Add(newProdUsed);
                    break;
                
                default:
                    products.Add(new Product(name, price));
                    break;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("PRICE TAGS:");
        foreach (Product prod in products)
        {
            if(prod is not ImportedProduct and not UsedProduct) Console.WriteLine($"{prod.Name} $ {prod.PriceTag()} ");
            if (prod is ImportedProduct imported)
                Console.WriteLine($"{prod.Name} $ {prod.PriceTag()} (Customs fee: $ {imported.CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})");
            if (prod is UsedProduct used)
                Console.WriteLine($"{prod.Name} (used) $ {prod.PriceTag()} (Manufacture date: {used.ManufactureDate.ToShortDateString()})");
        }
    }
}