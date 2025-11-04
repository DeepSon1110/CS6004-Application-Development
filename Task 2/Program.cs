class Circle
{
    public const double pi = 3.14;

    //method to calculate the area and perimeter of circle
    public static double Area(double radius)
    {
        return pi * radius * radius;
    }

    public static double Perimeter(double radius)
    {
        return 2 * pi * radius;
    }

}

class Program
{
    public static void Main(String[] args)
    {
        double radius = 4;
        double Area = Circle.Area(radius);
        double Perimeter = Circle.Perimeter(radius);

        Console.WriteLine($"Area of Circle is {Area}.");
        Console.WriteLine($"Perimeter of Circle is {Perimeter}.");

    }
}

