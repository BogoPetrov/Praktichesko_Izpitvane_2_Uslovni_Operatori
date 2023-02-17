internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
        {
            Console.Write("The year is leap.");
        }
        else
        {
            Console.Write("The year is't leap.");
        }
        Console.ReadKey();
    }
}