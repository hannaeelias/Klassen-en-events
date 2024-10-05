using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_en_events
{
    internal class Boek
    {
        public string Isbn { get; set; }
        public string Naam { get; set; }
        public string Uitgever { get; set; }
        private decimal prijs;

        public decimal Prijs
        {
            get { return prijs; }
            set
            {
                if (value < 5) prijs = 5;
                else if (value > 50) prijs = 50;
                else prijs = value;
            }
        }

        public Boek(string isbn, string naam, string uitgever, decimal prijs)
        {
            Isbn = isbn;
            Naam = naam;
            Uitgever = uitgever;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return $"ISBN: {Isbn}, Naam: {Naam}, Uitgever: {Uitgever}, Prijs: {Prijs:C}";
        }

        public virtual void Lees()
        {
            Console.WriteLine("Voer de gegevens in voor het boek:");
            Console.Write("ISBN: ");
            Isbn = Console.ReadLine();
            Console.Write("Naam: ");
            Naam = Console.ReadLine();
            Console.Write("Uitgever: ");
            Uitgever = Console.ReadLine();
            Console.Write("Prijs: ");
            decimal.TryParse(Console.ReadLine(), out decimal prijs);
            Prijs = prijs;
        }
    }
}

