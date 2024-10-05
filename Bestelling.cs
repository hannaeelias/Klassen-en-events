using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_en_events
{
    internal class Bestelling<T>
    {
        private static int nextId = 1;
        public int Id { get; }
        public T Item { get; set; }
        public DateTime Datum { get; set; }
        public int Aantal { get; set; }
        public Verschijningsperiode? AbonnementPeriode { get; set; }

        public Bestelling(T item, int aantal, Verschijningsperiode? periode = null)
        {
            Id = nextId++;
            Item = item;
            Aantal = aantal;
            Datum = DateTime.Now;
            AbonnementPeriode = periode;
        }

        public (string isbn, int aantal, decimal totalePrijs) Bestel()
        {
            if (Item is Boek boek)
            {
                decimal totalePrijs = boek.Prijs * Aantal;

                BestellingGeplaatst?.Invoke(this, new BestellingEventArgs($"Bestelling geplaatst voor {Aantal} exemplaren van {boek.Naam}."));
                return (boek.Isbn, Aantal, totalePrijs);
            }
            throw new InvalidOperationException("Item is geen boek.");
        }

        public event EventHandler<BestellingEventArgs> BestellingGeplaatst;
    }

    public class BestellingEventArgs : EventArgs
    {
        public string Bericht { get; }

        public BestellingEventArgs(string bericht)
        {
            Bericht = bericht;
        }
    }
}

