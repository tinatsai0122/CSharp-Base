namespace Exo_05_Operator_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your BBAN for verification: ");
            String? bban = Console.ReadLine()?.Trim().Replace(" ",""); //Second ? is to verify first if the value is null, if yes, then following by other verficiations:Trim = delete the white space before and after the numbers, Replace is to dealing with white spaces in between numbers.
            if(!(bban is null) && bban.Length == 12 && long.TryParse(bban, out _))// _ means that no variable needs to be created
            {
                String first10nb = bban.Substring(0, 10);
                long first10 = long.Parse(first10nb);
                String last2nb = bban.Substring(10);
                short last2 = short.Parse(last2nb); //two numbers can be using short
            

                short check = (short)(first10 % 97); //the calculation can be covered by short, so transform it to short
                if ((check == last2) || (check==0 && last2 ==97))
                {
                    Console.WriteLine($"The bban number you entered: {bban} is OK.");
                    long check2 = long.Parse($"{last2}{last2}111400");
                    short check3 = (short)(98 - (check2 % 97));
                    Console.WriteLine($"Your IBAN will be 'BE{((check3<10)?"0":"")}{check3}{bban}'.");

                }else {
                    Console.WriteLine($"The bban number you entered: {bban} is not ok!");
                }
            
            }else
            {
                Console.WriteLine($"The bban number you entered: '{bban}' is not valid! \n Un BBAN is with 12 digits. \n Please re-enter with correct bban account.");
            }

 
        }
    }
}