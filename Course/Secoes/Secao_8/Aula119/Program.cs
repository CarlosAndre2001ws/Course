using System.Diagnostics;
using System.Globalization;
using Course.Secoes.Secao_8.Aula119.Entities;

namespace Course.Secoes.Secao_8.Aula119;

public class Program
{
    public static void Run()
    {
        List<Shape> shapes = new List<Shape>();
        Console.Write("Enter the number of shapes: "); int shapesNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < shapesNumber; i++)
        {
            Console.WriteLine($"\x1b[1mShape #{i+1} data:\x1b[0m");
            Console.Write("Rectangle or Circle (r/c)?: "); string rectangleOrCircle = Console.ReadLine();
            Console.Write("Color: "); string color = Console.ReadLine();
            switch (rectangleOrCircle)
            {
                case "r":
                    Console.Write("Width: "); double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: "); double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(Enum.Parse<Color>(color), width, height));
                    break;
                
                case "c":
                    Console.Write("Radius: "); double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(Enum.Parse<Color>(color), radius));
                    break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("SHAPE AREAS:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}