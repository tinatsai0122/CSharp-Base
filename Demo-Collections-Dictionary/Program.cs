namespace Demo_Collections_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> presences = new Dictionary<string, bool>();

            string[] names =
            {
                "Elena",
                "Najoua",
                "Emanuela",
                "Hanane",
                "Dorine",
                "Laurence",
                "Margot",
                "Senem",
                "Victoria",
                "Hsin-i",
                "Yusra",
            };

            for (int i = 0; i < 12; i++)
            {
                presences.Add(names[i], false);
            }
            Console.WriteLine("Veuillez noter la presence pour chaque eleve: ");

            foreach (KeyValuePair<string, bool> kvp in presences)
            {

                string reponse;
                do
                {
                    Console.Write($"{kvp.Key}: (P)resent ou (A)bsent ?");
                    reponse = Console.ReadLine();
                    Console.WriteLine();
                } while (reponse != "A" && reponse != "P");
                presences[kvp.Key] = reponse == "p";

            }
            Console.Clear();
            Console.WriteLine("Les absents sont: ");

            foreach (KeyValuePair<string, bool> kvp in presences)
            {
                if (!kvp.Value)
                {
                    Console.WriteLine(kvp.Key);
                }

            }
        }
    }
}