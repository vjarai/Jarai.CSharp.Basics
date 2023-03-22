using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public class Aufgelegt : Telefonzustand
    {
        public Aufgelegt()
            : base("<H�rer ist aufgelegt>")
        {
        }

        public override Telefonzustand Abheben()
        {
            Console.WriteLine("H�rer wird abgehoben.");
            return new Abgehoben();
        }

        public override Telefonzustand AnnehmenAnruf()
        {
            Console.WriteLine("Anruf wird angenommen.");
            return new Verbunden();
        }
    }
}