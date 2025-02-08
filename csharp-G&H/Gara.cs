using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_G_H
{
    internal class Gara
    {
        //Attributi
        private string circuito;

        private Pilota vincitore;

        private List<Pilota> grigliaDiPartenza;

        //Proprietà
        public string Circuito { get; set; }

        //Pilota vincitore
        public Pilota Vincitore { get; set; }
        //Lista di piloti in griglia di partenza
        public List<Pilota> GrigliaDiPartenza { get; set; }

        //Costruttore vuoto
        public Gara() { }

        //Costruttore parametrico
        public Gara(string circuito)
        {
            Circuito = circuito;
            GrigliaDiPartenza = new List<Pilota>();
        }

        //Metodi
        public int CreaGrigliaDiPartenza()
        {
            Console.WriteLine("\nInserire almeno 2 Piloti");
            int numeroPiloti = 0;

            try
            {
                // Richiesta del numero di piloti (almeno 2)
                Console.Write("Quanti piloti vuoi inserire? ");
                if (!int.TryParse(Console.ReadLine(), out numeroPiloti) || numeroPiloti < 2)
                {
                    throw new Exception("Devi inserire almeno 2 piloti.");
                }

                for (int i = 0; i < numeroPiloti; i++)
                {
                    Console.WriteLine($"Pilota {i + 1}: Nome");
                    string nome = Console.ReadLine();

                    // Controllo che il nome non sia vuoto
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        throw new NomeVuotoException();
                    }

                    Console.WriteLine($"\nPilota{i + 1}: Scuderia");
                    string scuderia = Console.ReadLine();

                    // Controllo che il nome non sia vuoto
                    if (string.IsNullOrWhiteSpace(scuderia))
                    {
                        throw new ScuderiaVuotoException();
                    }
                    
                    Auto auto = new Auto(scuderia);
                    
                    Pilota pilota = new Pilota(nome, auto);

                    GrigliaDiPartenza.Add(pilota);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
                numeroPiloti = 0; // Imposta numeroPiloti a 0 in caso di errore
            }
            finally
            {
                Console.WriteLine("\nFine programma.");
            }

            return numeroPiloti;
        }

        //Metodo per far correre i piloti
        public Pilota CorriGara()
        {
            try
            {
                if (GrigliaDiPartenza.Count < 2)
                {
                    throw new NumeroPilotiException();
                }

                //Genero un oggetto casuale random per determinare il vincitore
                Random random = new Random();


                //Genero un indice compreso tra 0 e GrigliaDiPartenza.Count - 1. Ad esempio, se la griglia di partenza contiene 3 piloti, random.Next(3) restituirà un valore compreso tra 0 e 2
                int indiceVincitore = random.Next(GrigliaDiPartenza.Count);

                Console.WriteLine($"\n Indice vincitore.{indiceVincitore}");

                //Assegno il vincitore
                Vincitore = GrigliaDiPartenza[indiceVincitore];
                //Ritorno il vincitore
                return Vincitore;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
                return null; // Aggiunto per garantire che tutti i percorsi restituiscano un valore
            }
            finally
            {
                Console.WriteLine("\nFine programma.");
            }
        }

        //Metodo per stampare il vincitore
        public void StampaInfoVincitore()
        {
            if (Vincitore != null)
            {
                Console.WriteLine($"Il vincitore è {Vincitore.Nome} della {Vincitore.Auto.Scuderia}.");
            }
            else
            {
                Console.WriteLine("La gara non è ancora iniziata.");
            }
        }



    }
}
