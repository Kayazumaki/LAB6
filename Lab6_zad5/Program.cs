using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] magicSquare1 = { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } };
            int[,] magicSquare2 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            int[,] magicSquare3 = { { 16, 3, 2, 13 }, { 5, 10, 11, 8 }, { 9, 6, 7, 12 }, { 4, 15, 14, 1 } };

            Console.WriteLine("Wybierz numer kwadratu do sprawdzenia:");
            Console.WriteLine("1. Kwadrat spełniający wszystkie warunki");
            Console.WriteLine("2. Kwadrat nie spełniający warunku unikatowości");
            Console.WriteLine("3. Kwadrat nie spełniający warunku sumy");
            int choice = int.Parse(Console.ReadLine());

            int[,] selectedSquare;

            switch (choice)
            {
                case 1:
                    selectedSquare = magicSquare1;
                    break;
                case 2:
                    selectedSquare = magicSquare2;
                    break;
                case 3:
                    selectedSquare = magicSquare3;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    return;
            }

            bool isMagicSquare = CheckMagicSquare(selectedSquare);

            if (isMagicSquare)
            {
                Console.WriteLine("Podany kwadrat jest kwadratem magicznym.");
            }
            else
            {
                Console.WriteLine("Podany kwadrat nie jest kwadratem magicznym.");
            }
            Console.ReadKey();
        }

        static bool CheckMagicSquare(int[,] square)
        {
            int n = square.GetLength(0);

            // Sprawdzanie sumy wierszy
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += square[0, j];
            }

            // Sprawdzanie unikatowości liczb i sum w pozostałych wierszach i kolumnach
            for (int i = 1; i < n; i++)
            {
                int currentRowSum = 0;
                int currentColSum = 0;
                bool[] uniqueNums = new bool[n * n + 1];

                for (int j = 0; j < n; j++)
                {
                    int num = square[i, j];
                    if (num < 1 || num > n * n || uniqueNums[num])
                    {
                        return false; // Liczba powtarza się lub jest spoza zakresu
                    }
                    uniqueNums[num] = true;

                    currentRowSum += square[i, j];
                    currentColSum += square[j, i];
                }

                if (currentRowSum != rowSum || currentColSum != rowSum)
                {
                    return false; // Suma wiersza lub kolumny jest niezgodna
                }
            }

            // Sprawdzanie sum na przekątnych
            int diagSum1 = 0;
            int diagSum2 = 0;
            for (int i = 0; i < n; i++)
            {
                diagSum1 += square[i, i];
                diagSum2 += square[i, n - i - 1];
            }
            if (diagSum1 != rowSum || diagSum2 != rowSum)
            {
                return false; // Suma na przekątnych jest niezgodna
            }

            return true; // Wszystkie warunki zostały spełnione
        }

    }
}
