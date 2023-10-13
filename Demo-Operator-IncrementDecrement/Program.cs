namespace Demo_Operator_IncrementDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            //int j = i++;
            int j = i;
            i++;

            Console.WriteLine($"i={i};j={j}");
            Console.WriteLine($" i+j => {i+j}");

            i += j;
            Console.WriteLine($" i :{i}+j:{j} => {i + j}");
        }
    }
}