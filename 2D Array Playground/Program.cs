namespace TwoDimensionalArrayPlayground
{
    class Array
    {
        private static void Main(string[] args)
        {
            Console.Write("How many rows do you want to add: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("How many columns do you want to add: ");
            int cols = int.Parse(Console.ReadLine());
            
            int [,] grid = new int[rows, cols];
            
            Console.Write("# # "); // upper border
            
            for (int i = 0; i < rows; i++)
            {
                Console.Write("# ");
            }
            Console.WriteLine("# ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("# "); // the left border
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = new Random().Next(1, 5);
                    grid[i, j] = i + j;

                    if (grid[i, j] > 3)
                    {
                        Console.Write("* ");
                    }

                    if (grid[i, j] == 1)
                    {
                        Console.Write("! ");
                    }
                    else
                    {
                        Console.Write(grid[i, j] + " "); //prints the random numbers
                    }
                }
                Console.Write("# "); // the right border
                Console.WriteLine();
            }
            Console.Write("# "); //the down border
            for (int j = 0; j < cols; j++)
            {
                Console.Write("# ");
            }
            Console.WriteLine("# ");
        }
    }
}      