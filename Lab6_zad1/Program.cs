using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kliknij by wykonać tabelkę 10x10");
            Console.ReadKey();

            int rows = 10;
            int cols = 10;
            int[,] array = new int[rows, cols];
            int counter = 1;

            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] = counter++;
                    }
                }
                else
                {
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        array[i, j] = counter++;
                    }
                }
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
