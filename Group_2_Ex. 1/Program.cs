internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter four - digit number: ");
        int number = int.Parse(Console.ReadLine());
        int thousands = number / 1000;
        int hundreds = (number / 100) % 10;
        int dozens = (number / 10) % 10;
        int units = number % 10;

        if (thousands == hundreds || thousands == dozens || thousands == units || hundreds == dozens || hundreds == units || dozens == units)
        {
            Console.Write("Number have got two equal digits.");
        }
        else
        {
            Console.Write("Number haven't got two equal digits.");
        }
        Console.ReadKey();
    }
}