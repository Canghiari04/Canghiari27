using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Canghiari_EsTeatroFinale
{
    // Canghiari Matteo
    // 4J - Compito TPSIT - Teatro

    class Program
    {
        static void Main(string[] args)
        {
            Teatro Galli = new Teatro("Teatro Galli", "Via A. De Gasperi", 500); // Istanza dell'oggetto Teatro
            Posto Posto1 = new Posto(27, "Loggione", 20); // Istanza dello'oggeto Posto
            Galli.AddPosto(Posto1); // Il posto viene aggiunto alla lista posti del Teatro
            Compagnia Musone = new Compagnia("Compagnia Musone"); // Istanza della nuova Compagnia
            Attore Martina = new Attore("Martina", "Musone", new DateTime(1995, 07, 25), 10, "protagonista"); // Istanza del'oggeto Attore
            Musone.AddAttori(Martina); // L'attore viene aggiunto alla lista di attori
            Spettacolo KungFuPanda = new Spettacolo("Animazione", "Kung Fu Panda 2", Musone); // Istanza del nuovo spettacolo
            Rappresentazione PrimaReplica = new Rappresentazione(new DateTime(2020, 04, 11, 21, 30, 00), 500, 20, KungFuPanda, Galli); // Istanza della nuova rappresentazione
            Spettatore Matteo = new Spettatore("Matteo", "Canghiari", new DateTime(1994, 03, 16)); // Istanza dell'oggeto Spettatore
            Biglietto Biglietto1 = new Biglietto("12ew3", 20, Posto1, PrimaReplica, Matteo); // Istanza dell'oggetto Biglietto

            // Stampa dei vari attributi e variabili dei vari metodi della classi
            Console.WriteLine("\nIl nome del teatro è " + Galli.DenominazioneIndirizzo + ",\ndi capienza massima di : " + Galli.NumeroPosti + " posti.\n");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\nLa compagnia che in data " + PrimaReplica.GiornoSpettacolo + ",");
            Console.WriteLine("si chiama " + Musone.DatiCompagnia + ", il cui numero di membri è " + Musone.DatiCompagnia2+ ",");
            Console.WriteLine("che in tale orario svolgerà lo spettacolo " + KungFuPanda.titolo + " mentre il numero di biglietti disponibili è : " + PrimaReplica.GetBigliettiDisponibili() + ".");
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\nL'attore della compagnia si chiama " + Martina.NomeCognome + ", il suo numero di spettacoli totale è di : " + Martina.GetnumeroSpettacoli);
            Console.WriteLine("il ruolo nella rappresentazione : " + Martina.Getruolo + ", il suo stipendio è di " + Martina.Ottienistpendio() + " euro.");
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\nLo spettatore che ha comprato il biglietto " + Biglietto1.GetCodice + " si chiama " + Matteo.NomeCognome);
            Console.WriteLine("il suo posto si trova nella parte " + Posto1.DatiPosto + " il quale numero è "+ Posto1.numero + ", mentre il costo del biglietto è stato di : " + Biglietto1.CalcolaBiglietto() + " euro.");
            Console.ReadLine();
        }
    }
}
