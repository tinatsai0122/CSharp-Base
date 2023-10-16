using System.Runtime.Serialization.Json;

namespace Exo_Loops_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {   for(int j = 1; j <= 20; j++)
                {
                    int result = (i * j);
                    Console.WriteLine($"{i}x{j}={result}");
                }
                Console.WriteLine();
            }
        }
    }
}