using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Canghiari_EsTeatroFinale
{
    public class Compagnia
    {
        private string denominazione; // Variabile che contiene il nome della compagnia
        private int numeroMembri; // Variabile che contiene il numero totale di membri della compagnia
        List<Attore> attore; // Lista che contiene tutti gli attori della compagnia

        /// <summary>
        /// Costruttore che inizializza l'oggeto della classe Compagnia
        /// </summary>
        /// <param name="denominazione"></param>
        public Compagnia(string denominazione)
        {
            this.denominazione = denominazione;
            attore = new List<Attore>();
        }

        /// <summary>
        /// Get per visualizzare i valori delle variabili precedentemente richiamati
        /// </summary>
        public string DatiCompagnia
        {
            get { return denominazione; }
        }
        public int DatiCompagnia2
        {
            get { return numeroMembri; }
        }

        /// <summary>
        /// Metodo che aggiunge eventuali attori alla lista e incremneta il numero di membri della compagnia
        /// </summary>
        /// <param name="a"> a definisce l'attore </param>
        public void AddAttori(Attore a)
        {
            attore.Add(a);
            numeroMembri ++;
        }
    }
}
