using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public class Verbunden : Telefonzustand
    {
        public Verbunden()
            : base("<Verbindung ist hergestellt>")
        {
        }

        public override Telefonzustand Auflegen()
        {
            Console.WriteLine("H�rer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override Telefonzustand Sprechen()
        {
            Console.WriteLine("Es wird gesprochen.");
            return this;
        }
    }
}