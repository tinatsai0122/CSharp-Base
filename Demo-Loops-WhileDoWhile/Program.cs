namespace Demo_Loops_WhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo Whilte
            Console.WriteLine("Veuillez entrer un chiffre: ");
            String? reponse = Console.ReadLine();
            int nb;
            bool isConverted = int.TryParse(reponse, out nb);
            while (!isConverted){
                Console.WriteLine("Veuillez entrer un chiffre: ");
                reponse = Console.ReadLine();
                isConverted = int.TryParse(reponse, out nb);
            }
            Console.WriteLine($"Le nombre {nb} est correct!");

            #endregion

            #region Demo Do Whilte

            int nb2;
            bool isConverted2;
            string message = "Veuillez entrer un chiffre: ";
            do
            {
                Console.WriteLine(message);
                String? reponse2 = Console.ReadLine();
                message = $"Erreur! Le nombre {reponse}n'est pas valide! \n Veuillez entrer un chiffre: ";
                isConverted2 = int.TryParse(reponse2, out nb2);
            } while (!isConverted2);
            Console.WriteLine($"Le nombre {nb2} est correct!");

            #endregion

            #region Demo Do Whilte simplified

            int nb3;
            do Console.WriteLine("Veuillez entrer un chiffre: ");
            while (!int.TryParse(Console.ReadLine(), out nb3));
            Console.WriteLine($"Le nombre {nb3} est correct!");

            #endregion
        }
    }
}