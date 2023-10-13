namespace Exo_02_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number)){
                if (number % 2 == 0) Console.WriteLine($"{number} you entered is an even number");
   
                else Console.WriteLine($"{number} you entered is an odd number");

            }
            else{
                Console.WriteLine($"{input} you entered is not valid, please enter a valid number!");
            }
            Console.ReadLine();

            Console.WriteLine("------------------------");
            Console.WriteLine($"Veuillez saisir l'année de votre naissance: ");
            String? year = Console.ReadLine();
            if (int.TryParse(year, out int nb))
            {
                if ((DateTime.Now.Year - nb) >= 18)
                {
                    Console.WriteLine("Veuillez saisir votre nationalité: ");
                    String? nationality = Console.ReadLine().ToLower();
                    switch (nationality)
                    {
                        case "belge":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale, une fois!");
                            break;
                        case "francais":
                        case "francaise":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale. cocorico!");
                            break;
                        case "suisse":
                            Console.WriteLine("Bienvennue sur le siteeeuhh de la loterie nationaleeeeehhh!");
                            break;
                        case "canadien":
                        case "canadienne":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale, tabernacle!");
                            break;
                        default:
                            Console.WriteLine("Désolé, vous ne pouvez donc pas accéder au site!");
                            break;

                    }
                }
                else { Console.WriteLine("Désolé, tu dois encore attendre " + (18-(DateTime.Now.Year - nb)) + " années et il faut devenir belge pour accéder au site"); }
            }
            else
            {
                Console.WriteLine("Vous n'avez pas entrer une annee valable.");
            }
        }
    }
}
