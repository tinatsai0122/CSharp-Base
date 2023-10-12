namespace Exo_00_intro
{
    internal class Program
    {
        static string programName = "Exo-00-Intro";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Clear();
            Console.WriteLine("Bonjour, a qui ai-je l'honneur?");
            Console.WriteLine("Please input your name: ");
            String? userName = Console.ReadLine();
            Console.Clear();
            //Console.WriteLine($"{userName}, c'est un tres joli nom!");
            Console.WriteLine(userName + ", c'est tres joli nom!");
            Console.WriteLine("Appuyez sur Enter pour quitter");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Ho!Vous me quittez deja! Au revoir {userName}.");
            //Console.WriteLine("Ho@Vous me quittez deja! Au revoir" + username);
        }
    }
}