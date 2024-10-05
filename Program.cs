namespace Klassen_en_events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Boek boek1 = new Boek("123456789", "C# voor beginners", "Educatieve Uitgeverij", 29.99m);
            Boek boek2 = new Boek("987654321", "Gevorderde C# technieken", "Tech Press", 39.99m);

           
            Tijdschrift tijdschrift1 = new Tijdschrift("111222333", "Tech Today", "Tech Media", 9.99m, Verschijningsperiode.Wekelijks);
            Tijdschrift tijdschrift2 = new Tijdschrift("444555666", "Nature Weekly", "Science Publishers", 19.99m, Verschijningsperiode.Maandelijks);

           
            Bestelling<Boek> bestelling1 = new Bestelling<Boek>(boek1, 2);
            bestelling1.BestellingGeplaatst += BestellingBevestiging;
            var result1 = bestelling1.Bestel();
            Console.WriteLine($"Besteld: ISBN {result1.isbn}, Aantal: {result1.aantal}, Totale prijs: {result1.totalePrijs:C}");

            Bestelling<Tijdschrift> bestelling2 = new Bestelling<Tijdschrift>(tijdschrift1, 3, Verschijningsperiode.Wekelijks);
            bestelling2.BestellingGeplaatst += BestellingBevestiging;

        }

        static void BestellingBevestiging(object sender, BestellingEventArgs e)
        {
            Console.WriteLine(e.Bericht);
        }
    }
}
    

