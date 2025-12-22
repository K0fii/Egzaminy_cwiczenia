using System.Collections.ObjectModel;

namespace MabilkiMobilki
{
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<string> Zadania { get; set; } = new ObservableCollection<string>();

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "tasks.txt");

        public MainPage()
        {
            InitializeComponent();
            //  ZaladujZadania();
            listaZadan.BindingContext = Zadania;
            listaZadan.ItemsSource = Zadania;
        }

        private void UsunZadanie(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string zadanieDoUsuniecia = button.CommandParameter.ToString();
            Zadania.Remove(zadanieDoUsuniecia);
        }

        private void DodajZadanie(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entNoweZadania.Text))
            {
                Zadania.Add(entNoweZadania.Text);
                entNoweZadania.Text = null;
            }
        }

        private void ZaladujZadania()
        {
            string[] linie = File.ReadAllLines(filePath);
            foreach (string linia in linie)
            {
                Zadania.Add(linia);
            }
        }
    }
}
