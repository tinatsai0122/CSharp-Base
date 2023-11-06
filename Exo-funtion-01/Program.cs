namespace Exo_funtion_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice d1 = new Dice();
            d1.min = 5;
            d1.max = 10;
            Console.WriteLine(d1.Roll());
            Console.WriteLine(d1.Roll(2));
            Console.WriteLine(d1.Roll(3));
            Console.WriteLine(d1.Roll(5));
            Console.WriteLine(d1.Roll(10));

        }
    }
}