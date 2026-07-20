using Course.Secoes.Secao_8.Aula98.Entities.Enums;

namespace Course.Secoes.Secao_8.Aula98.Entities;

public class Order
{
    
    public int Id {get; set;}
    public DateTime Moment {get; set;}
    public OrderStatus Status {get; set;}


    public override string ToString()
    {
        return Id
               + ", "
               + Moment
               + ", "
               + Status;
    }
}