internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter start of numeric range (A): ");
        double startA = double.Parse(Console.ReadLine());
        Console.Write("Enter end of numeric range (B): ");
        double endB = double.Parse(Console.ReadLine());
        Console.Write("Enter x from number A to B, including A and wihout B: ");
        double numberX = double.Parse(Console.ReadLine());
        Console.Clear();
        
        if (numberX >= startA && numberX < endB || numberX <= startA && numberX > endB)
        {
            Console.Write("Number x is in numeric range from A to B.");
        }
        else
        {
            Console.Write("Number x isn't in numeric range from A to B.");
        }
        Console.ReadKey();
    }
}