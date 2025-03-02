using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using System.Text.RegularExpressions;
using System.Text.Unicode;
namespace _2DArray_playground

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
            Random rand = new Random();

            Console.Write("# # ");
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
                    grid[i, j] = new Random().Next(1, 10);

                    if (grid[i, j] > 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(grid[i, j] + " ");
                    }
                }
                Console.Write("# "); // the right border
                Console.WriteLine();
            }
            Console.Write("# ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write("# ");
            }
            Console.WriteLine("#");
        }
    }
}      