namespace Klassen_en_events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Boek boek1 = new Boek("123456789", "C# voor beginners", "Educatieve Uitgeverij", 29.99m);
            Boek boek2 = new Boek("987654321", "Gevorderde C# technieken", "Tech Press", 39.99m);
            Boek boek3 = new Boek("432143556", "hannae", "testing somthing to make sure no error", 600.99m);

            Tijdschrift tijdschrift1 = new Tijdschrift("111222333", "Tech Today", "Tech Media", 9.99m, Verschijningsperiode.Wekelijks);
            Tijdschrift tijdschrift2 = new Tijdschrift("444555666", "Nature Weekly", "Science Publishers", 19.99m, Verschijningsperiode.Maandelijks);
            Tijdschrift tijdschrift3 = new Tijdschrift("313143145", "nog een testt", "wooooh", 14000.99m, Verschijningsperiode.Dagelijks);


            Bestelling<Boek> bestelling1 = new Bestelling<Boek>(boek1, 2);
            bestelling1.BestellingGeplaatst += BestellingBevestiging;
            var result1 = bestelling1.Bestel();
            Console.WriteLine($"Besteld: ISBN {result1.isbn}, Aantal: {result1.aantal}, Totale prijs: {result1.totalePrijs:C}");

            Bestelling<Boek> bestelling3 = new Bestelling<Boek>(boek3, 4);
            bestelling3.BestellingGeplaatst += BestellingBevestiging;
            var result3 = bestelling3.Bestel();
            Console.WriteLine($"Besteld: ISBN {result3.isbn}, Aantal: {result3.aantal}, Totale prijs: {result3.totalePrijs:C}");



            Bestelling<Tijdschrift> bestelling2 = new Bestelling<Tijdschrift>(tijdschrift1, 3, Verschijningsperiode.Wekelijks);
            bestelling2.BestellingGeplaatst += BestellingBevestiging;


           
        }

        static void BestellingBevestiging(object sender, BestellingEventArgs e)
        {
            Console.WriteLine(e.Bericht);
        }
    }
}
    

