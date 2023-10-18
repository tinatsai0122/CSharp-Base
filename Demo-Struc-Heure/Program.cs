namespace Demo_Struc_Heure
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Temps finDesCours;
            finDesCours.heure = 16;
            finDesCours.minute = 45;
            finDesCours.seconde = 0;

            Temps debutDesCours = new Temps() { heure=8, minute=45};

            Console.WriteLine($"Nous debutons la journee a {debutDesCours.heure}h {debutDesCours.minute}m {debutDesCours.seconde}sec.");
        }
    }
}