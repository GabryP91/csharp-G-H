using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_G_H
{
    public class Eccezzioni : Exception
    {
        public Eccezzioni() : base() { }

        public Eccezzioni(string message) : base(message) { }

    }

    public class NumeroErratoException : Eccezzioni
    {
        public NumeroErratoException() : base("Sintassi errata. Inserisci un numero intero positivo.") { }
    }

    public class NumeroOutErratoException : Eccezzioni
    {
        public NumeroOutErratoException() : base("Indice non presente nell'array") { }
    }

    public class NumeroPilotiException : Eccezzioni
    {
        public NumeroPilotiException() : base("Devi inserire almeno 2 piloti.") { }
    }

    public class NomeVuotoException : Eccezzioni
    {
        public NomeVuotoException() : base("Il nome del pilota non può essere vuoto.") { }
    }

    public class ScuderiaVuotoException : Eccezzioni
    {
        public ScuderiaVuotoException() : base("La scuderia non può essere vuota.") { }
    }



}
