namespace Exo_struc_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int size = 5;
            Cross?[,] table = new Cross?[size, size];

            Cross p;

            for (int i = 0; i < size; i++)
            {
                p.x = i + 1;
                p.y = i + 1;

                table[i, i] = p;
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (table[row, col] is null) Console.Write("\t");
                    else
                    {
                        Console.Write($"X: {table[row, col]?.x} - Y: {table[row, col]?.y}");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}