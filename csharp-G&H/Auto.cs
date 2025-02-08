using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_G_H
{
    internal class Auto
    {
        //Attributi
        private string scuderia;

        //Proprietà
        public string Scuderia { get; set; }

        //Costruttore parametrico
        public Auto(string scuderia)
        {
            Scuderia = scuderia;
        }

        //override del metodo ToString
        public override string ToString()
        {
            return "Scuderia: " + scuderia;
        }

    }
}
