namespace Demo_Variable_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez entrer un nombre: ");
            string? reponse = Console.ReadLine();
            //Console.WriteLine($"Vous avez repondu: {reponse}");
            //int nombre = int.Parse( reponse );
            //Console.WriteLine($"Votre nombre est: {nombre}");

            int nombre;
            bool isConverted = int.TryParse( reponse, out nombre);
            Console.WriteLine($"La conversion s'est bien passee: {isConverted}; voici le resultat: {nombre}");

            //Convertion implicite
           // int i = 5;
           // long l = i;

            //Conversion explicite (casting)
           // short s = (short)i;
           // double d = 3.14;
           // int r = (int)d;
           // Console.WriteLine(i);
           // Console.WriteLine(l);
            //Console.WriteLine(s);
           // Console.WriteLine(d);
           // Console.WriteLine(r);

        }
    }
}