using System.Linq.Expressions;

namespace Figure;

public class Circle : GeometryFigure, IArea, IPerimeter
{
    public double radius;
    public const double PI = 3.14;
    
    public double CalculateArea()
    {
        area = PI * radius * radius;
        return area;
    }

    public double CalculatePerimeter()
    {
        perimeter = 2 * PI * radius;
        return perimeter;
    }
}