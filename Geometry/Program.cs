using GeometryLibrary;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;


class Program
{
    static async Task Main(string[] args)
    {

        var featureManagement = new Dictionary<string, string>
    {
    { "FeatureManagement:Square", "true"},
    { "FeatureManagement:Rectangle", "true"},
    { "FeatureManagement:Triangle", "true"}
    };

        IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();

        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("Enter the side of the square:");
            double side = double.Parse(Console.ReadLine() ?? "0");

            Square square = new Square(side);

            Console.WriteLine($"Area: {square.CalculateArea()}");
            Console.WriteLine($"Perimeter: {square.CalculatePerimeter()}");
        }


        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Enter the width and height of the rectangle:");
            double width = double.Parse(Console.ReadLine() ?? "0");
            double height = double.Parse(Console.ReadLine() ?? "0");

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
        }

        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Enter the base, height, side A and side B of the triangle:");
            double baseLength = double.Parse(Console.ReadLine() ?? "0");
            double height = double.Parse(Console.ReadLine() ?? "0");
            double sideA = double.Parse(Console.ReadLine() ?? "0");
            double sideB = double.Parse(Console.ReadLine() ?? "0");

            Triangle triangle = new Triangle(baseLength, height, sideA, sideB);

            Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
        }
        Thread.Sleep(5000);
    }
}