using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Canghiari_EsTeatroFinale
{
    public class Rappresentazione
    {
        private DateTime giorno; // Variabile che contiene la data della rappresentazione
        private int numeroBigliettiDisponobili; // Variabile che contiene il numero di biglietti disponibili per la rappresentazione
        List<Biglietto> biglietto = new List<Biglietto>(); // Lista che contien i biglietti della rappresentazione
        public int costoSpettatore; // Variabile che contiene il costo di ogni posto di ogni spettatore
        public Spettacolo spettacolo;
        public Teatro t;

        /// <summary>
        /// Costruttore che inizializza l'oggeto della classe Rappresentazione
        /// </summary>
        /// <param name="giorno"></param>
        /// <param name="numeroBigliettiDisponobili"></param>
        /// <param name="costoSpettatore"></param>
        /// <param name="spettacolo"></param>
        /// <param name="t"></param>
        public Rappresentazione(DateTime giorno, int numeroBigliettiDisponobili, int costoSpettatore, Spettacolo spettacolo, Teatro t)
        {
            this.giorno = giorno;
            this.numeroBigliettiDisponobili = numeroBigliettiDisponobili;
            this.costoSpettatore = costoSpettatore;
            this.spettacolo = spettacolo;
            this.t = t;
        }

        /// <summary>
        /// Get per visualizzare i valori delle variabili precedentemente richiamati
        /// </summary>
        public DateTime GiornoSpettacolo
        {
            get { return giorno; }
        }

        /// <summary>
        /// Metodo che aggiunge eventuali biglietti alla lsta di biglietti
        /// </summary>
        /// <param name="b"></param>
        public void AddBiglietto(Biglietto b)
        {
            biglietto.Add(b);
            numeroBigliettiDisponobili ++;
        }

        /// <summary>
        /// Metodo che calcola il numero di biglietti ancora disponibili
        /// </summary>
        /// <returns> NumeroBigliettiDisponibili numero dei biglietti disponibili intero </returns>
        public int GetBigliettiDisponibili()
        {
            numeroBigliettiDisponobili = t.NumeroPosti - 1;
            return numeroBigliettiDisponobili;
        }
    }
}
