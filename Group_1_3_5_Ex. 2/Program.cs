internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        double y = 0;

        if (x < -10)
        {
            y = 4 * x - 12;
        }
        else if (x >= -10 && x < 12)
        {
            y = Math.Pow(x, 2) - 7 * x + 8;
        }
        else if (x >= 12)
        {
            y = x - 3 * Math.Sqrt(x ) - 14;
        }
        Console.Write($"The value is equal to: {Math.Round(y, 2)}");
        Console.ReadKey();
    }
}