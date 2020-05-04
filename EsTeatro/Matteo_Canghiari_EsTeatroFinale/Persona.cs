using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Canghiari_EsTeatroFinale
{
    public class Attore 
    {
        private string nome; // Variabile che contiene il nome dell'attore
        private string cognome; // Variabile che contiene il cognome dell'attore
        private DateTime dataNascita; // Variabile che contiene la data di nascita dell'attore 
        private int numeroSpettacoli; // Variabile che contiene il numero di spettacoli fatti dall'attore
        private string ruolo; // Variabile che contiene il ruolo dell'attore nello spettacolo
        private int stipendio; // Variabile che contiene lo stipendio retribuito all'attore
        Compagnia compagnia;

        /// <summary>
        /// Costruttore che inizializza l'oggeto della classe Attore
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="dataNascita"></param>
        /// <param name="numeroSpettacoli"></param>
        /// <param name="ruolo"></param>
        public Attore(string nome, string cognome, DateTime dataNascita, int numeroSpettacoli, string ruolo)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = dataNascita;
            this.numeroSpettacoli = numeroSpettacoli;
            this.ruolo = ruolo;
        }

        /// <summary>
        /// Get per visualizzare i valori delle variabili precedentemente richiamati
        /// </summary>
        public string NomeCognome
        {
            get { return nome + " " + cognome; }
        }
        public int Eta
        {
            get { return DateTime.Now.Year - dataNascita.Year; }
        }
        public int GetnumeroSpettacoli
        {
            get { return numeroSpettacoli; }
        }
        public string Getruolo
        {
            get { return ruolo; }
        }

        /// <summary>
        /// Metodo che calcola lo stipendio di ogni attore
        /// </summary>
        /// <returns> Stipendio dell'attore intero </returns>
        public int Ottienistpendio()
        {
            stipendio = 10 * (numeroSpettacoli);
            return stipendio;
        }
    }

    public class Spettatore
    {
        string nome; // Variabile che contiene il nome dello spettatore
        string cognome; // Variabile che contiene il cognome dello spettatore
        DateTime dataNascita; // Variabile che contiene la data di nascita dello spettatore

        /// <summary>
        /// Costruttore che inizializza l'oggeto della classe Compagnia
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="dataNascita"></param>
        public Spettatore(string nome, string cognome, DateTime dataNascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = dataNascita;
        }

        /// <summary>
        /// Get per visualizzare i valori delle variabili precedentemente richiamati
        /// </summary>
        public string NomeCognome
        {
            get { return nome + " " + cognome; }
        }
        public int Eta
        {
            get { return DateTime.Now.Year - dataNascita.Year; }
        }
    }
}
