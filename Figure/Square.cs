namespace Figure;

public class Square : GeometryFigure, IArea, IPerimeter
{
    public double side;
    
    public double CalculateArea()
    {
        area = side * side;
        return area;
    }

    public double CalculatePerimeter()
    {
        perimeter = side * 4;
        return perimeter;
    }
}