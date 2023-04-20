namespace Figure;

public class ConsoleHelper
{
    public static void PrintPerimeter(IPerimeter figure)
    {
        Console.WriteLine($"Периметр = {figure.CalculatePerimeter()}");
    }
    
    public static void PrintArea(IArea figure)
    {
        Console.WriteLine($"Площадь = {figure.CalculateArea()}");
    }

    public static void PrintFigure(GeometryFigure figure)
    {
        Console.WriteLine($"Площадь = {figure.area}, периметр = {figure.perimeter}");
    }
}