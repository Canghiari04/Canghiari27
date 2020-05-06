 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca_Esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente c;
            ContoCorrente d;
            int scelta;
            Console.WriteLine("Inserisci il nome della banca: ");
            string nomeBanca = Console.ReadLine();

            Console.WriteLine("Inserisci l'indirizzo della banca: ");
            string indirizzoBanca = Console.ReadLine();

            Banca Banca = new Banca (nomeBanca, indirizzoBanca);

            do
            {
                Console.Write("\n");
                Console.WriteLine("------------------------");
                Console.WriteLine("----/AZIONI POSSIBILI/----");

                Console.WriteLine("1 - Inserisci intestatario");
                Console.WriteLine("2 - Elimina intestatario");
                Console.WriteLine("3 - Effettua bonifico");
                Console.WriteLine("4 - Effettua prelievo");
                Console.WriteLine("5 - Effettua versamento");
                Console.WriteLine("6 - Stampa clienti della banca e movimenti");
                Console.WriteLine("7 - Stampa dati banca");
                Console.Write("\n");
                Console.WriteLine("8 - Esci");
                Console.WriteLine("------------------------");
                Console.Write("\n");

                Console.Write("Selezione: ");
                scelta = Convert.ToInt16(Console.ReadLine());

                Console.Write("\n");
            
                    switch (scelta)
                    {
                        case 1:
                            Console.WriteLine("------------------------");
                            Console.Write("\n");

                            Console.Write("Inserisci nome: ");
                            string nome = Console.ReadLine();

                            Console.Write("Inserisci cognome: ");
                            string cognome = Console.ReadLine();

                            Console.Write("Inserisci luogo di nascita: ");
                            string luogoNascita = Console.ReadLine();

                            Console.Write("Inserisci data di nascita (anno/mese/giorno): ");
                            DateTime dataNascita = Convert.ToDateTime(Console.ReadLine());

                            Console.Write("Inserisci codice fiscale: ");
                            string codiceFiscale = Console.ReadLine();

                            Persona intestatario = new Persona(nome, cognome, luogoNascita, dataNascita, codiceFiscale);

                            Console.Write("Il conto creato è preferibile online (si/no): ");
                            string risposta = Console.ReadLine();

                            if (risposta == "si")
                            {
                                Console.Write("Inserisci IBAN: ");
                                string IBAN = Console.ReadLine();
                                ContoOnline contoOnline = new ContoOnline(intestatario, IBAN);
                                Banca.aggiungiConto(contoOnline);
                            }
                            else
                            {
                                Console.Write("Inserisci IBAN: ");
                                string IBAN = Console.ReadLine();
                                ContoCorrente contoCorrente = new ContoCorrente(intestatario, IBAN);
                                Banca.aggiungiConto(contoCorrente);
                            }
                            break;

                        case 2:
                            Console.WriteLine("------------------------");

                            Console.Write("Inserisci l'IBAN dell'intestatario da eliminare: ");
                            string ibanElimanare = Console.ReadLine();

                            Banca.EliminaConto(ibanElimanare);                           
                            break;

                        case 3:
                            Console.WriteLine("------------------------");
                            Console.Write("\n");

                            Console.Write("Inserisci la somma del bonifico: ");
                            int sommaBonifico = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Inserisci IBAN mittente: ");
                            string ibanMittente = Console.ReadLine();

                            Console.Write("Inserisci IBAN destinatario: ");
                            string ibanDestinatario = Console.ReadLine();

                            c = Banca.CercaConto(ibanMittente);

                            if (c.Bonifico(ibanDestinatario, sommaBonifico)) //nel caso in cui sia vero oltre che a ritornare il bool il metodo effettua un bonifico
                            {
                                Console.WriteLine("Movimento accettato.");
                            }
                            else
                            {
                                Console.WriteLine("Movimento rifiutato.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("------------------------");
                            Console.Write("\n");

                            Console.Write("Inserisci la somma del prelievo: ");
                            int sommaPrelievo = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Inserisci l'IBAN dell'intestario: ");
                            string ibanIntestatario = Console.ReadLine();

                            c = Banca.CercaConto(ibanIntestatario);

                            if (c.Preleva(sommaPrelievo))  //nel caso in cui sia vero oltre che a ritornare il bool il metodo preleva
                            {
                                Console.WriteLine("Movimento accettato.");
                            }
                            else
                            {
                                Console.WriteLine("Movimento fallito.");
                            }
                            break;

                        case 5:
                            Console.WriteLine("------------------------");
                            Console.Write("\n");

                            Console.WriteLine("Inserisci la somma del versamento: ");
                            int sommaVersamento = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Inserisci l'IBAN dell'intestatario: ");
                            string ibanVersamento = Console.ReadLine();

                            c = Banca.CercaConto(ibanVersamento);
                            c.Versa(sommaVersamento);

                            break;

                        case 6:
                            Console.WriteLine("------------------------");
                            Console.Write("\n");

                            if (Banca.ListaConti.Count != 0)
                              {
                                 foreach (ContoCorrente k in Banca.ListaConti)
                                 {
                                    Console.WriteLine("\nIntestatario del conto corrente " + k.Intestatario.Nome);
                                    foreach (Movimento m in k.Movimenti)
                                    {
                                        if (m == null)
                                        {
                                            Console.WriteLine("Nessun movimento.");
                                        }
                                        else
                                        {
                                            if (m is Bonifico)
                                            {
                                                Console.WriteLine("Movimento richiesto: bonifico.");
                                                Console.WriteLine(("Iban destinatario: " + ((Bonifico)m).Destinatario));
                                            }
                                            else
                                            {
                                                if (m is Prelievo)
                                                    Console.WriteLine("Moviemento richiesto: prelievo.");
                                                else
                                                    Console.WriteLine("Movimento richiesto: versamento.");
                                            }
                                            Console.WriteLine("Data del movimento: " + m.DataMovimento.ToString());
                                            Console.WriteLine("Importo del movimento : " + m.Importo + " euro.");
                                            Console.WriteLine("Identificativo del movimento: " + m.Id);
                                        }
                                    }
                                 }
                              }
                              else
                              {
                                Console.WriteLine("Non è presente alcun conto all'interno della lista.");
                              }

                            break;

                        case 7:
                            Console.WriteLine("------------------------");
                            Console.Write("\n");

                            Console.Write("Stampa nome banca: " + Banca.Nome + "\n");
                            Console.Write("Stampa indirizzo banca: " + Banca.Indirizzo);
                            Console.ReadLine();

                            break;
                    }
            } while (scelta != 8);
        }
    }
}
