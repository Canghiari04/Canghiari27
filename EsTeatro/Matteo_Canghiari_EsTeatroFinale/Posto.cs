using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteo_Canghiari_EsTeatroFinale
{
    public class Posto
    {
        public int numero; // Variabile che contiene il numero del post
        public string tipologia; // Variabile che contiene la tipologia del posto
        public int costoPosto; // Variabile che contien il prezzo del posto in base alla tipologia

        /// <summary>
        /// Costruttore che inizializza l'oggeto della classe Posto
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="tipologia"></param>
        /// <param name="costoPosto"></param>
        public Posto(int numero, string tipologia, int costoPosto)
        {
            this.numero = numero;
            this.tipologia = tipologia;
            this.costoPosto = costoPosto;
        }

        /// <summary>
        /// Get per visualizzare i valori delle variabili precedentemente richiamati
        /// </summary>
        public string DatiPosto
        {
            get { return tipologia; }
        }
    }
}
