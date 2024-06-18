public class Program 
{
    public static void Main(string[] args)
    {
        Shape circle = new Circle(10);
        Shape rectangle = new Rectangle(7, 12);

        Console.WriteLine("Circle Area: " + circle.GetArea());

    }
}