using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Canghiari_EsTeatroFinale
{
    public class Biglietto
    {
        private string codice; // Variabile che contiene il codice del biglietto
        private int tariffa; // Variabile che contiene il prezzo del biglietto
        Posto p;
        Rappresentazione r;
        Spettatore s;

        /// <summary>
        /// Costruttore che inizializza l'oggeto della classe Biglietto
        /// </summary>
        /// <param name="codice"></param>
        /// <param name="tariffa"></param>
        /// <param name="p"></param>
        /// <param name="r"></param>
        /// <param name="s"></param>
        public Biglietto(string codice, int tariffa, Posto p, Rappresentazione r, Spettatore s)
        {
            this.codice = codice;
            this.tariffa = tariffa;
            this.p = p;
            this.r = r;
            this.s = s;
        }

        /// <summary>
        /// Get per visualizzare i valori delle variabili precedentemente richiamati
        /// </summary>
        public Rappresentazione GetRappresentazione
        {
            get { return r; }
        }
        public Posto GetPosto
        {
            get { return p; }
        }
        public int GetTariffa
        {
            get { return tariffa; }
        }
        public string GetCodice
        {
            get { return codice; }
        }

        /// <summary>
        /// Metodo che calcola la tariffa del biglietto 
        /// </summary>
        /// <returns> Tariffa del biglietto intero </returns>
        public int CalcolaBiglietto()
        {
            tariffa = r.costoSpettatore + p.costoPosto;
            return tariffa;
        }
        
    }
}
