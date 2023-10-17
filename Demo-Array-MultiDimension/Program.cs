namespace Demo_Array_MultiDimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 4;
            const int ROWS = 12;
            bool[,] grid = new bool[ROWS, COLS];

            grid[1,1] = true;
            grid[8,3] = true;

            for (int row_i = 0; row_i < ROWS; row_i++) { 
                for (int col_i = 0; col_i < COLS; col_i++)
                {
                    Console.Write($"[{((grid[row_i, col_i]) ? "X" : " ")}]");
                }
                Console.WriteLine();
            }
        }
    }
}