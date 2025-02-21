using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid [i, j] = (i * j);
                    Console.WriteLine(grid [i, j]);

                    if (grid[i, j] == 0)
                    {
                        grid [i, j] = 1;
                    }

                    if (grid[i, j] == 1)
                    {
                        grid [i, j] = 2;
                    }
                    else
                    {
                        grid [i, j] = 3;
                    }
                }
            }
        }
    }
}      