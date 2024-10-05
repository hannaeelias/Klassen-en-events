using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_en_events
{
    public enum Verschijningsperiode
    {
        Dagelijks,
        Wekelijks,
        Maandelijks
    }
    internal class Tijdschrift : Boek
    {
        public Verschijningsperiode Periode { get; set; }

        public Tijdschrift(string isbn, string naam, string uitgever, decimal prijs, Verschijningsperiode periode)
            : base(isbn, naam, uitgever, prijs)
        {
            Periode = periode;
        }

        public override string ToString()
        {
            return base.ToString() + $", Periode: {Periode}";
        }

        public override void Lees()
        {
            base.Lees();
            Console.WriteLine("Kies de verschijningsperiode (0: Dagelijks, 1: Wekelijks, 2: Maandelijks): ");
            int keuze = int.Parse(Console.ReadLine());
            Periode = (Verschijningsperiode)keuze;
        }
    }
}

