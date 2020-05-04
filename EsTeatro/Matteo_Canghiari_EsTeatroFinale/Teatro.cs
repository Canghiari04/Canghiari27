using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Canghiari_EsTeatroFinale
{
    public class Teatro
    {
        private string denominazione; // Variabile che contiene il nome del teatro
        private string indirizzo; // Variabile che contiene l'indirizzo del teatro
        private int numeroPosti; // Variabile che contien il numero di posti del teatro
        List<Posto> posto; // Lista che contiene i posti del teatro
        List<Rappresentazione> rappresentazione; // Lista che contiene le raprpesentazioni del taetro
        List<Spettacolo> spettacolo; // Lista che contien gli spettacoli del teatro
        Spettacolo s;
        Rappresentazione r;

        /// <summary>
        /// Costruttore che inizializza l'oggeto della classe Teatro
        /// </summary>
        /// <param name="denominazione"></param>
        /// <param name="indirizzo"></param>
        /// <param name="numeroPosti"></param>
        public Teatro(string denominazione, string indirizzo, int numeroPosti)
        {
            this.denominazione = denominazione;
            this.indirizzo = indirizzo;
            this.numeroPosti = numeroPosti;
            this.posto = new List<Posto>();
        }

        /// <summary>
        /// Get per visualizzare i valori delle variabili precedentemente richiamati
        /// </summary>
        public string DenominazioneIndirizzo
        {
            get { return denominazione + ", mentre il suo indirizzo è " + indirizzo; }
        }
        public int NumeroPosti
        {
            get { return numeroPosti; }
        }

        /// <summary>
        /// Metodo che aggiunge ogni posto alla lista dei posti
        /// </summary>
        /// <param name="p"></param>
        public void AddPosto(Posto p)
        {
            posto.Add(p);
        }

        /// <summary>
        /// Metodo che aggiunge ogni rappresentazione alla lista di rappresentazioni
        /// </summary>
        public void AddRappresentazione()
        {
            rappresentazione.Add(r);
        }

        /// <summary>
        /// Metodo che riesce a risalire a ogni rappresentazione avvenuta all'interno del teatro
        /// </summary>
        /// <param name="titolo"></param>
        /// <returns></returns>
        public Spettacolo GetRappresentazione(string titolo)
        {
            foreach (Spettacolo s in spettacolo)
            {
                if (s.titolo == titolo)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
