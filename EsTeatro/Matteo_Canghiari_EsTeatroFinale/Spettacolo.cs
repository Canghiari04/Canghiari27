using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Canghiari_EsTeatroFinale
{
    public class Spettacolo
    {
        public string genere; // Variabile che contien il genere scenografico dello spettacolo
        public string titolo; // Variabile che contieneil titolo dello spettacolo
        Compagnia compagnia;

        /// <summary>
        /// Costruttore che inizializza l'oggeto della classe Spettacolo
        /// </summary>
        /// <param name="genere"></param>
        /// <param name="titolo"></param>
        /// <param name="compagnia"></param>
        public Spettacolo(string genere, string titolo, Compagnia compagnia)
        {
            this.genere = genere;
            this.titolo = titolo;
            this.compagnia = compagnia;
        }
    }
}
