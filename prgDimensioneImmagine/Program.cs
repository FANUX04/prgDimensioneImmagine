using System;

namespace prgDimensioneImmagine
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1;
            int n2;
            Console.WriteLine("inserisci prima l'altezza");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci la lunghezza");
            n2 = Convert.ToInt32(Console.ReadLine());
            // calcolo di dimensioni in pixel:
           
            int pixel = n1 * n2;


            int bit;
            
            Console.WriteLine("inserisci il numero di bit");
            bit = Convert.ToInt32(Console.ReadLine());
            
            switch(bit)
            {
                case 24:
                    Console.WriteLine($"={n1 * n2 * 3 / 1024}");
                    break;

                case 16:
                    Console.WriteLine($"={pixel * 2 / 1024}");
                    break;

                case 8:
                    Console.WriteLine($"={pixel * 1 / 1024}");
                    break;

                case 1:
                    Console.WriteLine($"={pixel * 8 / 1024}");
                    break;

                default:
                    Console.WriteLine("mi dispiace non funziona riprova");
                    break;
                

            }

        }
    }
}
