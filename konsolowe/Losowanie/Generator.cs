using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Losowanie
{
    public class Generator
    {
        public static int[,] generujTablice()
        {

            HashSet<int> wylosowaneLiczby = new HashSet<int>();
            Random random = new Random();

            while(wylosowaneLiczby.Count < 25)
            {
                wylosowaneLiczby.Add(random.Next(1, 51));
            }
        
            int[] tmp = new int[25];
            int index = 0;
            foreach (int liczba in wylosowaneLiczby)
            {
                tmp[index] = liczba;
                index++;
            }
            int[,] tablica = new int[5, 5];
            for(int i=0; i<5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    tablica[i, j] = tmp[(5*i)+j];
                }
            }
            return tablica;
        }
    }
}
