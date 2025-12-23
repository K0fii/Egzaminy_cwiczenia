namespace Losowanie
{
    internal class Program
    {
        public static void wyswietl(int[,] tab)
        {
            Console.WriteLine("---------------------");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0 , 4}",tab[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");
        }
        static void Main(string[] args)
        {
            int[,] tab = Generator.generujTablice();

            wyswietl(tab);


            Console.ReadKey();
        }
    }
}
