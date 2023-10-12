namespace Exo_01_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice int.Parse()");
            Console.WriteLine("----------------------");
            Console.WriteLine("We need 2 random numbers from you for the addition.");
            Console.WriteLine("Please provide the first number from 1-10: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the second number from 1-10: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The addition of your number {number1} and {number2} is {number1 + number2}");
            Console.ReadLine();

            Console.WriteLine("Exercice int.TryParse()");
            Console.WriteLine("----------------------");
            int number3, number4;
            Console.WriteLine("We need 2 random numbers from you for the addition.");
            Console.WriteLine("Please provide the first number from 1-10: ");
            string? nb3 = Console.ReadLine();
            bool isConverted = int.TryParse(nb3, out number3);
            Console.WriteLine("Please provide the second number from 1-10: ");
            string? nb4 = Console.ReadLine();

            bool convertedOrNot = int.TryParse(nb4, out number4);
            Console.WriteLine($"The addition of your number {nb3} and {nb4} is {number3 + number4}");

        }
    }
}