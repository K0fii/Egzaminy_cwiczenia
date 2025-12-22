using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace PrzegladarkaObiektow;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<Pracownik> pracownicy = new List<Pracownik>();
    int index = 0;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void wczytajDane(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        if(openFileDialog.ShowDialog() == true)
        {
            pracownicy.Clear();
            string[] linie = File.ReadAllLines(openFileDialog.FileName);

            foreach (string line in linie)
            {
                string[] dane = line.Split(';');
                pracownicy.Add(new Pracownik(
                    Convert.ToInt32(dane[0]),
                    dane[1],
                    dane[2],
                    dane[3],
                    Convert.ToDouble(dane[4])
                    ));
            }

            wyswietlPracownika(0);
        }
    }

    private void wyswietlPracownika(int id)
    {
        Pracownik p = pracownicy[id];
        lbImie.Content = $"Pracownik: {p.Imie} {p.Nazwisko}";
        lbZawod.Content = $"Zawód: {p.Zawod}";
        lbPlaca.Content = $"Placa: {p.Placa}";
        Uri uri = new Uri($"img/{p.Zdjecie}", UriKind.Relative);
        imgPracownik.Source = new BitmapImage(uri);
    }
    private void poprzedniPracownik(object sender, RoutedEventArgs e)
    {
        if (pracownicy.Count > 0)
        {
            if (index > 0)
                index--;
            wyswietlPracownika(index);
        }
        else return;
    }

    private void nastepnyPracownik(object sender, RoutedEventArgs e)
    {
        if(pracownicy.Count > 0)
        {
            if (index < 2)
                index++;
            wyswietlPracownika(index);
        }
        else return;
    }
}