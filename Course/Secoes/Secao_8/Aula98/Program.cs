using Course.Secoes.Secao_8.Aula98.Entities;
using Course.Secoes.Secao_8.Aula98.Entities.Enums;

namespace Course.Secoes.Secao_8.Aula98;

public class Program
{
    public static void Run()
    {
        
        Order order = new Order
        {
            Id = 1080,
            Moment = DateTime.Now,
            Status  = OrderStatus.PendingPayment
        };

        Console.WriteLine(order);
        
        string txt = OrderStatus.PendingPayment.ToString();
        
        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine(os);
        Console.WriteLine(txt);
    }
}