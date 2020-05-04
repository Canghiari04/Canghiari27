using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canghiari_Matteo_EsAgenzia
{
    // Mandrelli Francesco, Canghiari Matteo, Ossama Nadifi
    // 4J - Compito TPSIT - Agenzia Pubblicitaria

    class AgenziaPubblicitaria
    {

    }

    public class Agenzia 
    {
        Livello Livello; 
        private string Nome;
        private string CodiceFiscale;
        private string Iban;
        private int NumeroDipendenti;

        public Agenzia(string nome, string CodiceFiscale, string Iban) // Costruttore
        {
            this.Nome = nome;
            this.CodiceFiscale = CodiceFiscale;
            this.Iban = Iban;
        }

        public string DatiAzienda // Metodo get che restituisce i valori Nome, CodiceFiscale e Iban
        {
            get { return Nome + "\nIl cui codice fiscale è : " + CodiceFiscale + "\nIl cui Iban è : " + Iban; }
        }
    }

    public class Livello
    {
        private string descrizione;
        private string nome;
        private DateTime Inizio;
        private DateTime Fine;
        private int id;
        public RetribuzioneLivello RetribuzioneLivello = new RetribuzioneLivello();
        Staff Staff;

        public Livello(string descrizione, string nome, string Inizio, string Fine, int id) // Costruttore
        {
            this.descrizione = descrizione;
            this.nome = nome;
            this.Inizio = Convert.ToDateTime(Inizio);
            this.Fine = Convert.ToDateTime(Fine);
            this.id = id;
        }

        public string Descrizione // Vari metodi get per impostare i seguenti valori 
        {
            get { return descrizione; }
        }

        public string Nome
        {
            get { return nome; }
        }

        public int Eta 
        {
            get { return Fine.Year - Inizio.Year; }
        }

        public int ID
        {
            get { return id; }
        }
    }

    public class RetribuzioneLivello
    {
        private double Retribuzione;
        public Livello Livello;

        public double CalcoloStipendio(int ID) // Metodo dove dato l'ID del livello attribuisce una determinata retribuzione
        {
            switch (ID)
            {
                case 1:
                    Retribuzione = 1500;
                    break;
                case 2:
                    Retribuzione = 2000;
                    break;
                case 3:
                    Retribuzione = 2500;
                    break;
                case 4:
                    Retribuzione = 3000;
                    break;
                case 5:
                    Retribuzione = 3500;
                    break;
            }
            return Retribuzione;
        }
    }

    public class Persona
    {
        protected string nome;
        protected string cognome;
        protected DateTime dataNascita;

        public Persona(string nome, string cognome, string dataNascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = Convert.ToDateTime(dataNascita);
        }

        public string NomeCognome
        {
            get { return nome + " " + cognome + " "; }
        }

        public int Eta
        {
            get { return DateTime.Now.Year - dataNascita.Year; }
        }
    }

    public class Cliente : Persona
    {
        CampagnaPubblicitaria CampagnaPubblicitaria;

        public Cliente(string nome, string cognome, string dataNascita) : base(nome, cognome, dataNascita) // Costruttore
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = Convert.ToDateTime(dataNascita);
        }
    }

    public class Staff : Persona
    {
        private int NumeroImpiegati;
        Livello Livello;
        private double Bonus;
        private double stipendio;

        List<Persona> Impiegato = new List<Persona>(); // Lista che contiene tutte le persone dell'azienda

        public Staff(string nome, string cognome, string dataNascita, Livello Livello) : base(nome, cognome, dataNascita) // Costruttore
        {
            this.Livello = Livello;
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = Convert.ToDateTime(dataNascita);
        }

        public void AggiungiImpiegato(Persona p) // Metodo che aggiunge p alla lista Impiegato
        {
            Impiegato.Add(p);
        }

        public int ImpiegatiTotali() // Metodo che conta il numero di impiegati
        {
            foreach (Persona aPart in Impiegato)
            {
                NumeroImpiegati++;
            }
            return NumeroImpiegati;
        }

        public double Stipendio(double Bonus, double Retribuzione) // Calcola stipendio sommando il bonus alla retribuzione
        {
            stipendio = Bonus + Livello.RetribuzioneLivello.CalcoloStipendio(Livello.ID);
            return stipendio;
        }

        public double CalcolaBonus(int ID) // Calcolo del bonus retribuzione in base al livello dell'impiegato
        {
            switch (ID)
            {
                case 1:
                    Bonus = 50;
                    break;
                case 2:
                    Bonus = 100;
                    break;
                case 3:
                    Bonus = 150;
                    break;
                case 4:
                    Bonus = 200;
                    break;
                case 5:
                    Bonus = 250;
                    break;
            }
            return Bonus;
        }
    }

    public class StaffAmministratori : Staff
    {
        private int NumeroImpiegati;

        public StaffAmministratori(string nome, string cognome, string dataNascita, Livello livello) : base(nome, cognome, dataNascita, livello) // Costruttore
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = Convert.ToDateTime(dataNascita);
        }
    }

    public class StaffCreativo : Staff
    {
        private int NumeroImpiegati;
        CampagnaPubblicitaria CampagnaPubblicitaria;

        public StaffCreativo(string nome, string cognome, string dataNascita, Livello livello) : base(nome, cognome, dataNascita, livello) // Costruttore
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataNascita = Convert.ToDateTime(dataNascita);
        }
    }

    public class CampagnaPubblicitaria
    {
        private double CostoTotale;
        private double Iva;
        Pubblicita Pubblicita;

        public void CalcoloCosto(bool PubblicitaInCorso) // Calcolo del costo della pubblicità inclusa l'iva
        {
            Console.WriteLine("Inserisci il costo totale della  pubblicità:");
            CostoTotale = Convert.ToDouble(Console.ReadLine());
            Iva = (CostoTotale * 22) / 100; // Calcolo Iva
            CostoTotale = CostoTotale + Iva;
            Console.WriteLine("Il costo totale della pubblicità iva compresa è: " + CostoTotale + " euro");
        }

        public void CreaPubblicita(bool PubblicitaInCorso) // Metodo che crea la pubblictà
        {
            if (PubblicitaInCorso == false)
            {
                Console.WriteLine("Creo pubblicità");
                Console.WriteLine("Inserisci il nome della pubblicità:");
                string TitoloPubblicita = Console.ReadLine();
                PubblicitaInCorso = true;
                Console.WriteLine("Pubblicità creata");
            }
            else
            {
                Console.WriteLine("Pubblicità già in corso");
            }
        }
    }

    public class Pubblicita  // Tipi di pubblicità della campagna 
    {
        public bool PubblicitaInCorso; 
        private string TitoloPubblicita;
        private string TipoPubblicita;

        public Pubblicita(bool PubblicitaInCorso, string TitoloPubblicita, string TipoPubblicita) // Costruttore
        {
            this.PubblicitaInCorso = PubblicitaInCorso;
            this.TitoloPubblicita = TitoloPubblicita;
            this.TipoPubblicita = TipoPubblicita;
        }
    }  
}
