namespace Demo_Operator_Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillex indiquer combien d'annee vous reste-t-il de formation?");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                //if(year > 1)
                //{
                //    Console.WriteLine($"Waouw! Il vous rest {year} annees!");
                //}
                //else
                //{
                //    Console.WriteLine($"Waouw! Il vous rest {year} annee!");
                //}
                string s = (year > 1) ? "s" : "";
                Console.WriteLine($"Waouw! Il vous reste {year } annee{s}");
            }
        }
    }
}