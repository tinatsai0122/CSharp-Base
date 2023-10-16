namespace Exo_Loops_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb;
            bool isConverted;
            do
            {
            Console.WriteLine("Veuillex indiquer le nombre de nombres premiers que vous souhaitez obtenir: ");
            String? reponse = Console.ReadLine();
            isConverted = int.TryParse(reponse, out nb);
            } while (!isConverted);
            for (int i = 2, count=0; count < nb; i++) {
                bool isPrime = true;
                for(int j = 2; j <= (i/2) && isPrime; j++) {
                    if(i % j == 0) isPrime = false;
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
        }
    }
}