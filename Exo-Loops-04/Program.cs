namespace Exo_Loops_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculateur Factoriell");
            Console.WriteLine("----------------------");
            Console.WriteLine("Please enter a number: ");
            string? input = Console.ReadLine();
            bool isConverted = int.TryParse(input, out int facto);
            if (isConverted)
            {
                long result=1;
                for (int i = facto; i > 0; i--)
                {
                    result *= i;
                }
                Console.WriteLine($"Le factoriel de {facto} est: {result}");
            }
            else
            {
                Console.WriteLine($"The number you entered is not valid. Please enter a valid number: ");
                Console.WriteLine("Please enter a number: ");
                Console.ReadLine();
                isConverted = int.TryParse(input, out facto);
            }

        }
    }
}