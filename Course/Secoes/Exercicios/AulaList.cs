namespace Course.Secoes.Exercicios;

public class AulaList
{
    public static void Run()
    {
        List<string> lista = new List<string>();
        
        lista.Add("Maria");
        lista.Add("Alex");
        lista.Add("John");
        lista.Add("Jane");
        lista.Add("James");
        lista.Add("Jose");
        lista.Add("Anna");
        lista.Insert(2, "Marco");

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("List count: " + lista.Count);

        string? s1 = lista.Find(x => x[0] == 'A');
        Console.WriteLine("First 'A': " + s1);
        
        string? s2 = lista.FindLast(x => x[0] == 'A');
        Console.WriteLine("Last 'A': " + s2);

        Console.WriteLine();
        
        int pos1 = lista.FindIndex(x => x[0] == 'A');
        Console.WriteLine("First position 'A': " + pos1);
        
        int pos2 = lista.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("Last position 'A': " + pos2);
        
        List<string> lista2 = lista.FindAll(x => x.Length == 5);
        Console.WriteLine("---------------------------------------------");
        foreach (var obj in lista2)
        {
            Console.WriteLine(obj);
        }

        // lista.Remove("Alex");
        // lista.RemoveAt(1);
        lista.RemoveRange(2, 2);
        Console.WriteLine("---------------------------------------------");
        foreach (var obj in lista)
        {
            Console.WriteLine(obj);
        }

        lista.RemoveAll(x => x[0] == 'J');
        
        Console.WriteLine("---------------------------------------------");
        foreach (var obj in lista)
        {
            Console.WriteLine(obj);
        }
        
    }
}