namespace Demo_Function_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer votre e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Votre email est: {email}");

            string first_char = email.Substring(0, 1);
            Console.WriteLine($"La premiere lettre est: {first_char}");
        
            string three_chars_from_third = email.Substring(2,3);
            Console.WriteLine($"Les trois caracteres qui se suivent a partir du troisieme de l'email sont: {three_chars_from_third}");
        
            string five_last_chars = email.Substring(email.Length-6,5);
            Console.WriteLine($"Les cinq deniers caracteres de votre email sont: {five_last_chars}");
        }
    }
}