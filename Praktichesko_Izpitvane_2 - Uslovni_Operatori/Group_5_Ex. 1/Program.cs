internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        int comparison = firstNumber;
        Console.Clear();

        if (comparison < secondNumber)
        {
            comparison = secondNumber;
        }
        if (comparison < thirdNumber)
        {
            comparison = thirdNumber;
        }
        if (comparison < fourthNumber)
        {
            comparison = fourthNumber;
        }
        Console.Write($"The biggest number is: {comparison}");
        Console.ReadKey();
    }
}