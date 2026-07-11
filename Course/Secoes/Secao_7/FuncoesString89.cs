namespace Course.Secoes.Secao_7;

public class FuncoesString89
{
    public static void Run()
    {
        
        string original  = "abcde FGHIJ ABC abc DEFG    ";
        
        string s1 = original.ToUpper();
        string s2 = original.ToLower();
        string s3 = original.Trim();
        
        int n1  = original.IndexOf("bc");
        int n2 = original.LastIndexOf("bc");
        
        string s4 = original.Substring(3);
        string s5 = original.Substring(3, 5);

        string s6 = original.Replace('a', 'x');
        string s7 = original.Replace("abc", "xy");
        
        bool b1 = String.IsNullOrEmpty(original);
        bool b2 = String.IsNullOrWhiteSpace(original);
        
        Console.WriteLine("Original string: " + original);
        Console.WriteLine("ToUpper string: " + s1);
        Console.WriteLine("ToLower string: " + s2);
        Console.WriteLine("Trim string: " + s3);
        Console.WriteLine("Index of 'bc': " + n1);
        Console.WriteLine("Last Index of 'bc': " + n2);
        Console.WriteLine("Substring(3): " + s4);
        Console.WriteLine("Substring(3, 5): " + s5);
        Console.WriteLine("Replace('a', 'x'): " + s6);
        Console.WriteLine("Replace('abc', 'xy'): " + s7);
        Console.WriteLine("IsNullOrEmpty: " + b1);
        Console.WriteLine("IsNullOrWhiteSpace: " + b2);
    }
}