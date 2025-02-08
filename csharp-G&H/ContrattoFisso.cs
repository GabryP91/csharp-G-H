using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_G_H
{
    // Classe che rappresenta un contratto telefonico fisso derivata dalla classe ContrattoTelefonico
    internal class ContrattoFisso : ContrattoTelefonico
    {
        // Attributo
        private string indirizzo;

        // Proprietà
        public string Indirizzo { get; set; }

        //Costruttore vuoto
        public ContrattoFisso() { }

        // Costruttore parametrico
        public ContrattoFisso(string numero, string nomeAbbonato, string indirizzo, int durataInSecondi)
            : base(numero, nomeAbbonato, durataInSecondi)
        {
            Indirizzo = indirizzo;
        }

        // Metodo override del metodo ToString
        public override string ToString()
        {
            //ritorno del metodo ToString della classe base e aggiunta dell'indirizzo
            return base.ToString() + $", Indirizzo: {Indirizzo}, Tipologia Cotratto: Fisso";
        }

    }
}
