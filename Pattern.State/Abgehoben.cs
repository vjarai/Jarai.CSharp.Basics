using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public class Abgehoben : Telefonzustand
    {
        public Abgehoben()
            : base("<H�rer ist abgenommen>")
        {
        }

        public override Telefonzustand Auflegen()
        {
            Debug.WriteLine("H�rer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override Telefonzustand W�hlen()
        {
            Debug.WriteLine("Rufnummer wird gew�hlt.");
            return new Verbunden();
        }
    }
}