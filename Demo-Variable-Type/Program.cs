namespace Demo_Variable_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOMBRES ENTIER");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            int nb = Int32.MaxValue;
            Console.WriteLine($"La valeur maximale d'un entier est: {nb}");
            nb = Int32.MinValue;
            Console.WriteLine($"La valeur minimale d'un entier est: {nb}");
            long nb_grand = Int64.MaxValue;
            Console.WriteLine($"La valeur maximale d'un entier est: {nb_grand}");
            nb_grand = Int64.MinValue;
            Console.WriteLine($"La valeur minimale d'un entier est: {nb_grand}");
            short nb_small = Int16.MaxValue;
            Console.WriteLine($"La valeur maximale d'un entier est: {nb_small}");
            nb_small = Int16.MinValue;
            Console.WriteLine($"La valeur minimale d'un entier est: {nb_small}");
            Console.WriteLine();

            Console.WriteLine("NOMBRES ENTIER NON-SIGNES");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            uint unb = UInt32.MaxValue;
            Console.WriteLine($"La valeur maximale d'un entier no-signe est: {unb}");
            unb = UInt32.MinValue;
            Console.WriteLine($"La valeur minimale d'un entier no-signe est: {unb}");
            ulong unb_grand = UInt64.MaxValue;
            Console.WriteLine($"La valeur maximale d'un entier no-signe est: {unb_grand}");
            unb_grand = UInt64.MinValue;
            Console.WriteLine($"La valeur minimale d'un entier no-signe est: {unb_grand}");
            ushort unb_small = UInt16.MaxValue;
            Console.WriteLine($"La valeur maximale d'un entier no-signe est: {unb_small}");
            unb_small = UInt16.MinValue;
            Console.WriteLine($"La valeur minimale d'un entier no-signe est: {unb_small}");
            Console.WriteLine();

            Console.WriteLine("NOMBRES REELS");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            decimal deci = Decimal.MaxValue;
            Console.WriteLine($"La valeur maximale d'un nombre entier deguise en decimal est: {deci}");
            deci = Decimal.MinValue;
            Console.WriteLine($"La valeur minimale d'un nombre entier deguise en decimal est: {deci}");

            float reel_small = Single.MaxValue;
            Console.WriteLine($"La valeur maximale d'un decimal de petite precision est : {reel_small}");
            reel_small = Single.MinValue;
            Console.WriteLine($"La valeur minimale d'un decimal de petite precision est : {reel_small}");

            double reel_grand = double.MaxValue;
            Console.WriteLine($"La valeur maximale d'un decimal de petite precision est : {reel_grand}");
            reel_grand = double.MinValue;
            Console.WriteLine($"La valeur minimale d'un decimal de petite precision est : {reel_grand}");
            Console.WriteLine();

            Console.WriteLine("AUTRES TYPES");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            char caractere = 'a';
            Console.WriteLine($"Une variable char, contrairement au String, permet de stocker un seul et unique caractere!");
            caractere = (char)97;
            Console.WriteLine($"Voici le contenu de mon caractere {caractere}");

            bool isOk = false;
            Console.WriteLine($"Une variable bool, ne connait que 2 valeurs:{isOk}");
            isOk = true;
            Console.WriteLine(isOk);
        }   
    }
}