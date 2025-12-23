using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie2
{
    public class ArrayAnalyzer
    {
        public double ObliczSrednia(int[] tablica)
        {
            if (tablica == null || tablica.Length == 0)
            {
                throw new ArgumentException("Tablica nie może być pusta");
            }

            double suma = 0;
            foreach (int liczba in tablica)
            {
                suma += liczba;
            }
            return suma / tablica.Length;
        }

        public int LiczbaWiekszychNizSrednia(int[] tablica)
        {
            if (tablica == null || tablica.Length == 0) return 0;

            double srednia = ObliczSrednia(tablica);
            int licznik = 0;

            foreach (int liczba in tablica)
            {
                if (liczba > srednia)
                {
                    licznik++;
                }
            }
            return licznik;
        }
    }
}

