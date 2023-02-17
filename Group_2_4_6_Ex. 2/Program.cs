internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        double y = 0;

        if (x < -5)
        {
            y = 33 * x - 12;
        }
        else if (x >= -5 && x < 12)
        {
            y = Math.Pow(x, 3) - 8;
        }
        else if (x >= 12)
        {
            if (x == 12)
            {
                Console.Write("Wrong input!");
                Console.ReadKey();
                return;
            }
            else
                y = x - 3 * Math.Sqrt(x - 14);
        }
        Console.Write($"The value is equal to: {Math.Round(y, 2)}");
        Console.ReadKey();
    }
}