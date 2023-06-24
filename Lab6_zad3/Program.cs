using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_zad3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Wybierz zadanie:");
            Console.WriteLine("1. Zadanie 1");
            Console.WriteLine("2. Zadanie 2");
            int wybor;

            while (true)
            {
                Console.Write("Twój wybór: ");
                if (int.TryParse(Console.ReadLine(), out wybor) && (wybor == 1 || wybor == 2))
                {
                    break;
                }
                Console.WriteLine("Niepoprawny wybór. Podaj wartość 1 lub 2.");
            }

            Console.Write("Podaj rozmiar tablicy: ");
            int rozmiar;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out rozmiar) && rozmiar > 0)
                {
                    break;
                }
                Console.WriteLine("Niepoprawny rozmiar. Podaj dodatnią liczbę całkowitą.");
            }

            int[,] tablica = new int[rozmiar, rozmiar];

            switch (wybor)
            {
                case 1:
                    WypelnijTabliceZadanie1(tablica);
                    break;
                case 2:
                    WypelnijTabliceZadanie2(tablica);
                    break;
            }

            
            
        }

        static void WypelnijTabliceZadanie1(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < tablica.GetLength(1); j++)
                    {
                        tablica[i, j] = i * tablica.GetLength(1) + j + 1;
                    }
                }
                else
                {
                    for (int j = tablica.GetLength(1) - 1; j >= 0; j--)
                    {
                        tablica[i, j] = i * tablica.GetLength(1) + tablica.GetLength(1) - j;
                    }
                }
            }
            WypiszTablice1(tablica);
            Console.ReadKey();
        }

        static void WypelnijTabliceZadanie2(int[,] tablica)
        {
            int liczba = 1;
            int gora = 0;
            int dol = tablica.GetLength(0) - 1;
            int lewo = 0;
            int prawo = tablica.GetLength(1) - 1;

            while (liczba <= tablica.GetLength(0) * tablica.GetLength(1))
            {
                for (int i = lewo; i <= prawo; i++)
                {
                    tablica[gora, i] = liczba;
                    liczba++;
                }
                gora++;

                for (int i = gora; i <= dol; i++)
                {
                    tablica[i, prawo] = liczba;
                    liczba++;
                }
                prawo--;

                for (int i = prawo; i >= lewo; i--)
                {
                    tablica[dol, i] = liczba;
                    liczba++;
                }
                dol--;

                for (int i = dol; i >= gora; i--)
                {
                    tablica[i, lewo] = liczba;
                    liczba++;
                }
                lewo++;
            }
            WypiszTablice2(tablica);
            Console.ReadKey();



        }
        static void WypiszTablice2(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void WypiszTablice1(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
