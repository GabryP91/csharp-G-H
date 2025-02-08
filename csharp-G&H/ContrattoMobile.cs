using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_G_H
{
    // Classe che rappresenta un contratto telefonico mobile derivata dalla classe ContrattoTelefonico
    internal class ContrattoMobile : ContrattoTelefonico
    {
        // Attributo
        private int minutiInclusi;

        // Proprietà
        public int MinutiInclusi { get; set; }

        // Costruttore
        public ContrattoMobile(string numero, string nomeAbbonato, int minutiInclusi, int durataInSecondi)
            : base(numero, nomeAbbonato, durataInSecondi)
        {
            MinutiInclusi = minutiInclusi;
        }

        // Override del calcolo bolletta, includendo una logica per il piano mobile
        public override void CalcolaBolletta(int durataInSecondi)
        {
            //Chiama la funzione CalcolaBolletta della classe base e modifica variabile bolletta
            base.CalcolaBolletta(durataInSecondi);

            // Calcola la durata in minuti
            int durataInMinuti = durataInSecondi / 60;

            // Se la durata supera i minuti inclusi, applica un costo extra
            if (durataInMinuti > MinutiInclusi)
            {
                double costoExtra = (durataInMinuti - MinutiInclusi) * COSTO_AL_SECONDO * 60; // Costo extra per i minuti in eccesso
                Bolletta += costoExtra;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Minuti Inclusi: {MinutiInclusi}, Tipologia Cotratto: Mobile";
        }


    }
}
