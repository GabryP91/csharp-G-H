using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_G_H
{
    internal class ContrattoTelefonico
    {
        //Attributi
        // Costante per il costo per secondo di telefonata
        protected internal const double COSTO_AL_SECONDO = 0.15; // esempio di costo
        private string numero;
        private string nomeAbbonato;
        private double bolletta;

        // Definizione dell'evento
        public event EventHandler<string> TelefonataCompletata;


        // Proprietà
        public string Numero { get; set; }
        public string NomeAbbonato { get; set; }
        public double Bolletta { get; set; }

        // Costruttore vuoto
        public ContrattoTelefonico() { }

        // Costruttore parametrico
        public ContrattoTelefonico(string numero, string nomeAbbonato, int durataInSecondi)
        {
            Numero = numero;
            NomeAbbonato = nomeAbbonato;
            CalcolaBolletta(durataInSecondi); // Calcola la bolletta automaticamente
            // Attiva l'evento
            OnTelefonataCompletata($"Telefonata completata per {NomeAbbonato}. Bolletta calcolata: {Bolletta} EUR.");

        }

        // Metodo per calcolare la bolletta in base alla durata della telefonata (in secondi)
        public virtual void CalcolaBolletta(int durataInSecondi)
        {
            Bolletta = COSTO_AL_SECONDO * durataInSecondi;
        }

        // Metodo per attivare l'evento
        protected virtual void OnTelefonataCompletata(string message)
        {
            //invoca l'evento
            TelefonataCompletata?.Invoke(this, message);
        }

        // Metodo override del metodo ToString
        public override string ToString()
        {
            return $"Numero: {Numero}, Abbonato: {NomeAbbonato}, Bolletta: {Bolletta} EUR";
        }


    }
}
