using Figure;

var circle = new Circle()
{
    radius = 10
};

ConsoleHelper.PrintPerimeter(circle);
ConsoleHelper.PrintArea(circle);
ConsoleHelper.PrintFigure(circle);

var square = new Square()
{
    side = 10
};

ConsoleHelper.PrintPerimeter(square);
ConsoleHelper.PrintArea(square);
ConsoleHelper.PrintFigure(square);