using System.Collections.Generic;

namespace Exo_Collection_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>();
            int score;
            Console.WriteLine("Enter your score: ");
            String? input = Console.ReadLine();
            while (!int.TryParse(input, out score))
            {
                Console.WriteLine($"The score '{input}' you entered is not valid!");
                Console.WriteLine("Enter your score: ");
                input = Console.ReadLine();
            }
            Console.WriteLine("Do you want to add another score?");
            String? reponse = Console.ReadLine();
            while (reponse.Trim().ToLower() == "yes" && reponse!= null)  {
                Console.WriteLine("Enter another player's score: ");
                input = Console.ReadLine();
                scores.Add(score);
            }
            if (reponse.Trim().ToLower() == "no" && reponse != null)
            {
                double averageScore = Queryable.Average(scores.AsQueryable());
                Console.WriteLine($"");
            }
            else
            {
                Console.WriteLine($"The reponse '{reponse}' is not valid. Please answer yes or no!");
                Console.WriteLine("Do you want to add another score?");
                reponse = Console.ReadLine();
            }

        }
    }
}