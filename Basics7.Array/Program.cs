using System;

namespace Jarai.CSharp.Basics.Array
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Bitte Anzahl eingeben");
            string eingabe = Console.ReadLine();
            int anzahl = int.Parse(eingabe);

            double[] umsatz = new double[anzahl]; // eindimensionales Array (Vektor) passender Gr��e anlegen
            //var matrix = new double[4,4];   // geht im Prinzip auch mehrdimensional...

            // Bei ung�ltigem index wird IndexOutOfRangeException geworfen:
            //umsatz[-1] = 0;

            // Schleife f�r Eingabe
            for (int i = 0; i < umsatz.Length; i++)
            {
                Console.WriteLine("Bitte umsatz[{0:d}] eingeben", i);
                eingabe = Console.ReadLine();
                umsatz[i] = double.Parse(eingabe);
            }

            // foreach durchl�uft alle Elemente des Arrays
            foreach (double wert in umsatz)
            {
                Console.WriteLine("umsatz = " + wert);
            }

            // Alternativ: Ausgabe r�ckw�rts
            for (int i = umsatz.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("umsatz[{0}] = {1}", i, umsatz[i]);
            }

            Console.ReadLine();
        }
    }
}
