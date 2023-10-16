using System;

namespace Exo_04_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Automatic Division Program");
            Console.WriteLine("Please enter the first number: ");
            string reponse = Console.ReadLine();

            if (int.TryParse(reponse, out int nb1))
            {
                Console.WriteLine("Please enter the second number: ");
                reponse = Console.ReadLine();

                if (int.TryParse(reponse, out int nb2))
                {
                    if (nb2 == 0)
                    {
                        Console.WriteLine("The second number cannot be 0 as you cannot divide by zero.");
                        return;
                    }
                    int result = nb1/nb2;
                    float nbf1 = nb1;
                    float nbf2 = nb2;
                    Console.WriteLine($"The result of the division between {nb1} & {nb2} : {result}, Modulo: {nb1 % nb2}, division: {Math.Round((nbf1 / nbf2), 2)}");
                }
                else
                {
                    Console.WriteLine($"The number: {reponse} is not a valid number");
                }
            }
            else
            {
                Console.WriteLine($"The number: {reponse} is not a valid number");
            }
        }
    }
}
