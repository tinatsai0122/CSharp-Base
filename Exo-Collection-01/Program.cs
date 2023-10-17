using System.Numerics;

namespace Exo_Collection_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers for addition");
            Console.WriteLine("Please enter the first number: ");
            String? input = Console.ReadLine();
            int nb1;
            bool isConverted = int.TryParse(input, out nb1);
            while (!isConverted)
            {
                Console.WriteLine($"Error! The number {input} is not a valid number!");
                Console.WriteLine("Please enter the first number: ");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out nb1);
            }
            Console.WriteLine("Please enter the second number: ");
            String? input2 = Console.ReadLine();
            int nb2;
            bool isConverted2 = int.TryParse(input2, out nb2);
            while (!isConverted2)
            {
                Console.WriteLine($"Error! The number {input2} is not a valid number!");
                Console.WriteLine("Please enter the second number: ");
                input2 = Console.ReadLine();
                isConverted2 = int.TryParse(input2, out nb2);
            }

            List<int> digitsList1 = new List<int>();
            List<int> digitsList2 = new List<int>();

            String nb1String = nb1.ToString();
            String nb2String = nb2.ToString();

            int maxLength = Math.Max(nb1String.Length, nb2String.Length);

            nb1String = nb1String.PadLeft(maxLength, '0');
            nb2String = nb2String.PadLeft(maxLength, '0');

            Char[] nb1StringArray = nb1String.ToCharArray();
            foreach (Char ch1 in nb1StringArray)
            {
                int digit1 = int.Parse(ch1.ToString());
                digitsList1.Add(digit1);
            }

            Char[] nb2StrongArray = nb2String.ToCharArray();
            foreach (Char ch2 in nb2StrongArray)
            {
                int digit2 = int.Parse(ch2.ToString());
                digitsList2.Add(digit2);
            }

            int carry = 0;

            List<int> result = new List<int>();
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int addition = digitsList1[i] + digitsList2[i] + carry;
                carry = addition / 10;
                addition %= 10;
                result.Insert(0, addition); 
            }

            
            if (carry > 0)
            {
                result.Insert(0, carry);
            }

            Console.WriteLine("Result: " + string.Join("", result));
        }

    }
}