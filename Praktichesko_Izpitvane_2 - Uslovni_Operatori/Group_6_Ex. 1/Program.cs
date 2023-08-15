internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        Console.Clear();

        if (x != y)
        {
            if (x < y)
            {
                x *= 2;
            }
            else
            {
                y *= 2;
            }
        }
        else
        {
            Console.Write("Wrong input!");
        }
        Console.Write($"The bigger number is: {x}" +
            $"\nThe smaller number multiplied by 2 is: {y}");
        Console.ReadKey();
    }
}