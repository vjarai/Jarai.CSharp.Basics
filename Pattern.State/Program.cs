﻿namespace Jarai.CSharp.Pattern.State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var meinTelefon = new Telefon();

            // Happy Path "jemanden anrufen"
            meinTelefon.Abheben();
            meinTelefon.Wählen();
            meinTelefon.Sprechen();
            meinTelefon.Auflegen();

            // Happy Path "Anruf annehmen"
            meinTelefon.AnnehmenAnruf();
            meinTelefon.Sprechen();
            meinTelefon.Auflegen();


        }
    }
}
