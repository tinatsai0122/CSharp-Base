using System.ComponentModel.Design;
using System.Threading.Channels;
using System.Text;

namespace Exo_Collection_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
#region
 /*
            //1. Generation du Tabeau
            const int TAILLE = 11;
                bool[] tableau = new bool[TAILLE];

            //2. Definir la position de POIN
            int position = TAILLE / 2;    
            tableau[position] = true;

            //3.Afficher le tableau + instructions
            //[      .      }
            string choix;
            do
            {
                const char PION = '·';
                const char VIDE = ' ';
                Console.Clear();
                Console.Write("[");
                foreach (bool cell in tableau)
                {
                    if (cell) Console.Write(PION);
                    else Console.Write(VIDE);
                }

                Console.WriteLine("]");
                Console.WriteLine(
    @"Faites un choix:
'G' pour deplacer le pion sur la gauche,
'D' pour deplacer le pion sur la droite,
'Q' pour stopper l'application");

                //4. Attendre le choix de l'utilisateur
                do
                {
                    choix = Console.ReadLine().Trim().ToUpper();
                } while (choix != "G" && choix != "D" && choix != "Q");
                tableau[position] = false;
                switch (choix)
                {
                    case "G":
                        if(position>0) position--;
                        break;
                    case "D":
                        if (position < TAILLE-1) position++;
                        break;
                }
                tableau[position] = true;
 
            } while (choix!="Q");
 */

            #endregion


            #region
            Console.OutputEncoding = Encoding.Unicode;
            //1. Generation du Tabeau
            const int TAILLE = 11;
            bool[] tableau = new bool[TAILLE];

            //2. Definir la position de POIN
            int position = TAILLE / 2;
            tableau[position] = true;

            //3.Afficher le tableau + instructions
            //[      .      }
            string choix;
            do
            {
                const char PION = "😍";
                const char VIDE = " ";
                Console.Clear();
                Console.Write("[");
                foreach (bool cell in tableau)
                {
                    if (cell) Console.Write(PION);
                    else Console.Write(VIDE);
                }

                Console.WriteLine("]");
                Console.WriteLine(
    @"Faites un choix:
'G' pour deplacer le pion sur la gauche,
'D' pour deplacer le pion sur la droite,
'Q' pour stopper l'application");

                //4. Attendre le choix de l'utilisateur
                do
                {
                    choix = Console.ReadKey().Key.ToString();
                } while (choix != "G" && choix != "D" && choix != "Q");
                tableau[position] = false;
                switch (choix)
                {
                    case "G":
                        if (position > 0) position--;
                        break;
                    case "D":
                        if (position < TAILLE - 1) position++;
                        break;
                }
                tableau[position] = true;

            } while (choix != "Q");
            #endregion

        }
    }
}
