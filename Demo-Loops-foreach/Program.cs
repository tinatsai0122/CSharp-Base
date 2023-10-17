namespace Demo_Loops_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[12];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            foreach (string name in names)
            {
                Console.WriteLine(name ?? "Eleve non-enregistre");
            }
        }
    }
}