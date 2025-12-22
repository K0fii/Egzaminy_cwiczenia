using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzegladarkaObiektow
{
    public class Pracownik
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Zawod { get; set; }
        public double Placa { get; set; }
        public string Zdjecie { get; set; }

        public Pracownik(int  id, string imie, string nazwisko, string zawod, double placa)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Zawod = zawod;
            Placa = placa;
            Zdjecie = $"{id}-foto.jpg";
        }
    }
}
