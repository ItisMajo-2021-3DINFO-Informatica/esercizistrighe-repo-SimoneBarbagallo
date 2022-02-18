using System;

namespace BarbagalloEs3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contoparola = 0;
            string parola= "";
            while (parola !="fine")
            {
                Console.WriteLine("inserisci una parola");
                parola = Console.ReadLine();
                
                char primalettera = parola [0];
                int lungh = parola.Length;
                char ultimalettera = parola [lungh - 1];
                if (primalettera == ultimalettera)
                {
                    contoparola++;
                }      
            }
            Console.WriteLine($"il numero delle parole che iniziano e finiscono con la stessa lettera è di {contoparola}");
        }
    }
}
