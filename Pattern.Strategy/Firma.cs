﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Jarai.CSharp.Pattern.Strategy
{
    public class Firma
    {
        public Firma(string name)
        {
            Name = name;
        }

        public List<Arbeiter> Mitarbeiter { get; } = new List<Arbeiter>();


        public string Name { get; }


        public void Einstellen(Arbeiter arbeiter)
        {
            Mitarbeiter.Add(arbeiter);
        }

        public void Produzieren()
        {
            Console.WriteLine("Firma '{0}' produziert:", Name);

            foreach (Arbeiter arbeiter in Mitarbeiter)
            {
                arbeiter.Arbeiten(); // Spätes binden zur Laufzeit

                Debug.WriteLine(arbeiter.ToString());
            }
        }


    }
}
