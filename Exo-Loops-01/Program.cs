namespace Exo_Loops_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double i = 0.1; i <= 20.0; i += 0.1
                ) {
                Console.WriteLine(Math.Round(i, 2)
                    );
            }

            for (decimal j= 0.1M; j <= 20.0M; j += 0.1M)
            {
                Console.WriteLine(Math.Round(j, 2)
                    );
            }

            for (int k = 0; k <= 200; k ++)
            {
                Console.WriteLine(k/10D);
                }
            }
    }
}