using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_G_H
{
    internal class Pilota
    {
        //Attributi
        private string nome;
        private string auto;

        //Proprietà
        public string Nome { get; set; }
        public Auto Auto { get; set; }

        //Costruttore parametrico
        public Pilota(string nome, Auto auto)
        {
            Nome = nome;
            Auto = auto;
        }

        //override del metodo ToString
        public override string ToString()
        {
            return "Nome: " + nome + "\nAuto: " + auto;
        }
    }
}
