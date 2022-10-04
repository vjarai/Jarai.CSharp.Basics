using System;

//wg. Console


namespace Jarai.CSharp.CSharp.Basics.HelloWorld
{
    internal class Program
    {
        /// <summary>
        ///     Main ist der Einstiegspunkt der Anwendung
        ///     Main kann ohne Instanz aufgerufen werden (static)
        /// </summary>
        private static void Main(string[] args)
        {
            Console.WriteLine("Ihr vorname?");

            string vorname; // Lokale Variable anlegen (�berall m�glich)
            vorname = Console.ReadLine();

            Console.WriteLine("Ihr nachname?");
            string nachname = Console.ReadLine(); // Besser: Variable anlegen UND gleich zuweisen

            // Textverkettung mit +
            Console.WriteLine("Guten Tag " + vorname + " " + nachname + " !");

            // Vergleich der INHALTE (in Java w�re .equals() n�tig)
            // if( vorname == nachname )
            //	Console.WriteLine( "Vorname und Nachname sind gleich.");

            Console.ReadLine();
        }
    }
}
