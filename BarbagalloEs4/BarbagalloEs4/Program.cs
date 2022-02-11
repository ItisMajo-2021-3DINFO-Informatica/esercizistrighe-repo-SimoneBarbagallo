using System;

namespace BarbagalloEs4
{
    class Program
    {
        static void Main(string[] args)
        {
            int corte = 0;
            int medie = 0;
            int lunghe = 0;
            string parola = "";
            while (parola != "fine")
            { 
                Console.WriteLine("inserisci una frase/parola");
                parola = Console.ReadLine();
                int lungh = parola.Length;
                if (lungh < 4)
                {
                    corte++;
                }
                else if (lungh <= 7)
                {
                    medie++;
                }
                else
                {
                    lunghe++;
                }
            }
            Console.Write($"le parole minori di 4 lettere sono {corte}");
            Console.WriteLine($"la parole con lettere minori o uguali a sette sono {medie}");
            Console.WriteLine($"le parole con più di 7 lettere sono {lunghe}");
        }
    }
}
