using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kliknij by stworzyć tablicę, która tworzy się jak ślimak ");
            Console.ReadKey();
            int rows = 10;
            int cols = 10;
            int[,] array = new int[rows, cols];

            int counter = 1;
            int rowStart = 0;
            int rowEnd = rows - 1;
            int colStart = 0;
            int colEnd = cols - 1;

            while (counter <= rows * cols)
            {
                // Wypełnianie wiersza od lewej do prawej
                for (int col = colStart; col <= colEnd; col++)
                {
                    array[rowStart, col] = counter++;
                }
                rowStart++;

                // Wypełnianie kolumny od góry do dołu
                for (int row = rowStart; row <= rowEnd; row++)
                {
                    array[row, colEnd] = counter++;
                }
                colEnd--;

                // Wypełnianie wiersza od prawej do lewej
                for (int col = colEnd; col >= colStart; col--)
                {
                    array[rowEnd, col] = counter++;
                }
                rowEnd--;

                // Wypełnianie kolumny od dołu do góry
                for (int row = rowEnd; row >= rowStart; row--)
                {
                    array[row, colStart] = counter++;
                }
                colStart++;
            }

            PrintArray(array);
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
