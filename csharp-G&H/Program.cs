/*
    A – Rispondi alle seguenti domande argomentando la risposta:

       
        4) Cosa sono gli operatori logico booleani?

            Gli operatori logici booleani eseguono operazioni logiche con gli operandi bool.
            Gli operatori includono:
                1) la negazione logica unaria (!) => negazione logica dell'operando ovvero trasforma true a false e viceversa, 
                2) la logica binaria AND (&) => calcola l'AND logico dei relativi operandi cioè impone il verificarsi di tutti i casi A & B,
                3) OR logico (|) => calcola l'OR logico dei relativi operandi cioè verifica che almeno uno dei due casi sia vero A | B, 
                4) OR esclusivo (^) => calcola l'OR esclusivo logico dei relativi operandi cioè verifica che uno dei due casi sia vero ma non entrambi A ^ B,
                5) e la logica binaria condizionale AND (&&) e OR (||) => and e or logico condizionale, cioè se il primo operando è sufficiente a determinare il risultato, il secondo non viene valutato.



        5) Cos’è il tipo di ritorno di un metodo e cosa implica?
        6) Che differenza c’è tra le strutture di controllo selettive e quelle iterative?       
        13) Quali sono le conseguenze dell’ereditarietà?
        20) È possibile gestire insieme più eccezioni? Se si spiega come? 
   
***************************************************************************************************************

        1) Definisci la differenza tra oggetto, classe e istanza.
            
          
            Un oggetto è un'entità concreta che rappresenta un'istanza di una classe.
            Una classe è un modello o schema che definisce le proprietà e i comportamenti dell'oggetto o degli oggetti.
            Un'istanza è la creazione di un oggetto a partire da una classe.

        2) Cos’è il processo di astrazione?
        
            L'astrazione è il processo di semplificazione di un sistema complesso nascondendo i dettagli irrilevanti e mostrando solo le caratteristiche essenziali.
            In programmazione, permette di creare classi che rappresentano concetti generali, lasciando i dettagli specifici alle classi derivate, consentendo
            di concentrarsi sui concetti principali e di nascondere i dettagli di implementazione.

        3) Qual è lo scope di una variabile?
        
            Lo scope di una variabile è la parte del codice in cui la variabile è accessibile.
            In C#, lo scope può essere locale (all'interno di un metodo), di classe (all'interno di una classe) o globale (accessibile da qualsiasi parte del programma).

        4) Definisci gli array e fai un esempio.
        
            Un array è una struttura dati che contiene una collezione di elementi dello stesso tipo, accessibili tramite un indice.
            In C#, gli array sono definiti specificando il tipo degli elementi e la dimensione dell'array deve sempre essere definita.
           
            Esempio:
            int[] numeri = new int[5] { 1, 2, 3, 4, 5 };

         5) Quali sono i modificatori d’accesso?
        
            I modificatori d'accesso in C# definiscono la visibilità e l'accessibilità alle classi, metodi e variabili.
            I principali modificatori d'accesso sono:
            
            - public: accessibile da qualsiasi parte del programma.
            - private: accessibile solo all'interno della classe in cui è definito.
            - protected: accessibile all'interno della classe in cui è definito e dalle classi derivate.
            - internal: accessibile solo all'interno dello stesso assembly.
            - protected internal: accessibile all'interno dello stesso assembly o da classi derivate.

         6) Descrivere il processo dell’incapsulamento.
        
            L'incapsulamento è un principio della programmazione orientata agli oggetti che consiste nel nascondere i dettagli interni di un oggetto e nel fornire un'interfaccia pubblica per interagire con esso.
            Questo permette di proteggere lo stato interno dell'oggetto da modifiche esterne non controllate e di mantenere l'integrità dei dati.
            In C#, l'incapsulamento si realizza utilizzando modificatori d'accesso (come private e public) e proprietà (getters e setters) per controllare l'accesso ai campi dell'oggetto.

        7) Cosa sono getters e setters e a cosa servono?
            
            I getters e setters sono metodi utilizzati per accedere e modificare i campi privati di una classe in modo controllato.
            I getters (metodi get) permettono di ottenere il valore di un campo privato, mentre i setters (metodi set) permettono di impostare il valore di un campo privato.
            Questo permette di mantenere l'incapsulamento e il controllo sull'accesso ai dati all'interno di una classe.

        8) Cosa rappresenta l’ereditarietà in C#?
        
            L'ereditarietà in C# è un principio della programmazione orientata agli oggetti che permette di creare una nuova classe basata su una classe esistente.
            La classe derivata eredita i membri (proprietà, metodi, campi) della classe base, consentendo il riutilizzo del codice e la creazione di gerarchie di classi.
            Questo facilita la manutenzione e l'estensione del codice, permettendo di aggiungere o modificare funzionalità senza alterare la classe base.

        9) Cosa sono le interfacce?

            Un'interfaccia in C# è un contratto che definisce un insieme di metodi, proprietà ed eventi che una classe deve implementare.
            Le interfacce permettono di definire un comportamento comune che può essere condiviso tra diverse classi, indipendentemente dalla gerarchia di ereditarietà.
            Una classe può implementare più interfacce, consentendo di definire comportamenti diversi in base alle esigenze.

        10) Che differenza c’è tra classe astratta ed interfaccia?
        
            Una classe astratta può contenere sia metodi con implementazione che metodi astratti (senza implementazione), e non può essere istanziata direttamente.
            Le classi derivate devono implementare i metodi astratti della classe astratta, può avere un costruttore
            
            Un'interfaccia, invece, può contenere solo dichiarazioni di metodi, proprietà ed eventi, senza alcuna implementazione.
            Le classi che implementano un'interfaccia devono fornire l'implementazione di tutti i membri dell'interfaccia, non può avere un costruttore
            
            Inoltre, una classe può ereditare solo una classe astratta, ma può implementare più interfacce. Entrambe non possono essere istanziate direttamente.

            
         11) Definisci l’overload.
               
            l'overload è una tecnica di programmazione che consente di definire più funzioni con lo stesso nome ma con firme diverse (numero o tipo di parametri).
            In C#, il compilatore distingue le funzioni in base alla firma, consentendo di averne tante con lo stesso nome ma con comportamenti diversi.
            Questo permette di creare funzioni con lo stesso nome che eseguono operazioni simili su tipi di dati diversi o con parametri diversi.
            
        12) Definisci l’override.

            l'override è una tecnica di programmazione che consente di ridefinire un metodo di una classe base in una classe derivata.
            In C#, il metodo ridefinito deve avere la stessa firma del metodo della classe base e deve essere contrassegnato con la parola chiave override.
            Questo permette di personalizzare il comportamento di un metodo ereditato, consentendo di adattarlo alle esigenze della classe derivata.

        13) Spiega cos’è il polimorfismo.

            Il polimorfismo è un principio della programmazione orientata agli oggetti che consente di trattare oggetti di classi diverse in modo omogeneo.
            In C#, il polimorfismo si realizza attraverso l'uso di classi base e classi derivate, permettendo di utilizzare un oggetto di una classe derivata come se fosse un oggetto della classe base.
            Questo permette di scrivere codice più generico e flessibile, consentendo di trattare oggetti diversi in modo uniforme.

        14) Cos’è un’eccezione? Come la si gestisce?
        
            Un'eccezione è un evento anomalo che si verifica durante l'esecuzione di un programma, interrompendo il normale flusso di esecuzione.
            Le eccezioni possono essere causate da errori di programmazione, condizioni di runtime impreviste o problemi esterni come la mancanza di risorse.
            I cosiddetti Program Error, ovvero errori che si verificano durante l'esecuzione del programma e che possono essere previsti e quindi gestiti.
            
            In C#, le eccezioni si gestiscono utilizzando i blocchi try, catch e finally:
            
            - try: contiene il codice che potrebbe generare un'eccezione.
            - catch: contiene il codice per gestire l'eccezione se si verifica.
            - finally: contiene il codice che viene eseguito indipendentemente dal fatto che si verifichi un'eccezione o meno (opzionale).
            -throw: permette di generare manualmente un'eccezione in un punto specifico del codice.

            n. b. Un blocco try può contenere più blocchi catch per gestire diversi tipi di eccezioni.

            Esempio:
            try
            {
                int[] numeri = { 1, 2, 3 };
                Console.WriteLine(numeri[5]); // Questo genererà un'eccezione
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Indice fuori intervallo: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Blocco finally eseguito.");
            }

        15) Descrivi il modificatore static.

            Il modificatore static in C# viene utilizzato per dichiarare membri (metodi e attributi) di classe che appartengono alla classe stessa anziché a un'istanza specifica della classe.
            Vengono condivisi tra tutte le istanze della classe e possono essere acceduti direttamente tramite il nome della classe.
            I membri statici vengono inizializzati una sola volta, quando la classe viene caricata in memoria, e mantengono il loro valore per tutta la durata del programma.
            Esempio:
            public class Esempio
            {
                public static int Contatore = 0;
                public Esempio()
                {
                    Contatore++;
                }
                public static void MetodoStatico()
                {
                    Console.WriteLine("Metodo statico eseguito.");
                }
            }
            Esempio.MetodoStatico(); // Chiamata a un metodo statico
            Console.WriteLine(Esempio.Contatore); // Accesso a un campo statico



    B – Esercizi C#

            1)  Creare un programma che chieda all’utente quanti elementi intende inserire, e poi acquisisca in
                input quel numero di elementi, che saranno numeri interi. Una volta fatto questo, chiedere
                all’utente di scegliere un indice dell’array. Si scambi di posto il massimo tra gli elementi
                dell’array e l’elemento con l’indice deciso dall’utente, scrivendo anche un messaggio quando le
                due posizioni coincidono.

            2)  Sviluppare un’applicazione che gestisce corse automobilistiche. Saranno presenti le classi Auto,
                Gara, Pilota. Ogni pilota avrà un nome, ogni auto avrà una scuderia. La classe Gara avrà un
                circuito, un vincitore e una griglia di partenza per i piloti.
                Creare il metodo creaGrigliaDiPartenza() che istanzierà i piloti associandoli alla griglia di
                partenza. Creare il metodo corriGara() che restituirà il pilota vincente e ne stamperà le info in
                console, assieme a quelle dell’auto che guidava.

            3)  Sviluppare una classe ContrattoTelefonico che ha un numero, un nome dell'abbonato e una
                bolletta, data da una costante (COSTO_AL_SECONDO) moltiplicata per il numero di secondi di
                una telefonata.
               
                Un contratto fisso è un contratto telefonico con la sola aggiunta che in questo caso abbiamo
                anche l'indirizzo dell'utenza.

                Un contratto per un telefono mobile è un contratto telefonico dove il conteggio della bolletta
                viene fatto con lo stesso criterio generale, salvo che ad ogni risposta viene aggiunto un
                sovrapprezzo COSTO_RISPOSTA.

            4)  Testare la classe ContrattoTelefonico e le sue sottoclassi ContrattoFisso e ContrattoMobile.
                Definire due utenti, uno fisso e uno mobile. I due utenti fanno una serie di telefonate di un certo
                tempo, alla fine stampare le loro bollette telefoniche.

*/

using System;

namespace csharp_G_H
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int scelta;

            while (true) // Loop infinito fino a scelta di uscita
            {
                Console.WriteLine("\n---------------------------------------------------\n");
                Console.WriteLine("Seleziona un esercizio da 1 a 3 oppure digita 0 per uscire:");

                Console.WriteLine("Caso [1]: Stampa a schermo massimo array");
                Console.WriteLine("Caso [2]: Gestione Corse");
                Console.WriteLine("Caso [3]: Gestore Telefonico");
               

                Console.WriteLine("\nFai la tua scelta\n");

                // Controllo input utente
                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
                }

                if (scelta == 0)
                {
                    Console.WriteLine("Uscita dal programma...");
                    break; // Esce dal loop e termina il programma
                }

                Console.WriteLine("\n---------------------------------------------------\n");

                switch (scelta)
                {

                    case 1:
                        Console.WriteLine("ESERCIZIO 1\n");
                        ChekArray();
                        break;
                    case 2:
                        Console.WriteLine("ESERCIZIO 2\n");
                        IndiciCorsa();
                        break;
                    case 3:
                        Console.WriteLine("ESERCIZIO 3\n");
                        Chiamate();
                        break;
                    
                }

            }

        }
        /*
            1)  Creare un programma che chieda all’utente quanti elementi intende inserire, e poi acquisisca in
                input quel numero di elementi, che saranno numeri interi. Una volta fatto questo, chiedere
                all’utente di scegliere un indice dell’array. Si scambi di posto il massimo tra gli elementi
                dell’array e l’elemento con l’indice deciso dall’utente, scrivendo anche un messaggio quando le
                due posizioni coincidono.
        */

        static void ChekArray()
        {
            // Dichiarazione variabili grandezza array
            int n;

            Console.WriteLine("Quanti numeri vuoi inserire?");

            try
            {
                // Controllo input utente

                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    throw new NumeroErratoException();
                }

                // Dichiarazione array di grandezza n
                int[] numeri = new int[n];

                // Inserimento numeri nell'array
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"\nInserisci il numero in posizione {i + 1}: ");

                    int temp;

                    //Controllo
                    if (!int.TryParse(Console.ReadLine(), out temp))
                    {
                        throw new NumeroErratoException();
                    }

                    numeri[i] = temp;
                }

                Console.WriteLine("\nScegli un'indice");

                for (int i = 0; i < numeri.Length; i++)
                {
                    Console.Write($"\nIndice [{i + 1}] => {numeri[i]}");

                }

                Console.Write($"\nFai la tua scelta");

                int value;

                // Controllo dell'input
                if (!int.TryParse(Console.ReadLine(), out value) || value < 1)
                {
                    throw new NumeroErratoException();
                }

                if ( value > n)
                {
                    throw new NumeroOutErratoException();
                }

                // Decremento value per adattarlo all'indice dell'array scelto dall'utente
                value -= 1;

                Console.WriteLine("\nAnalisi e scambio posizione....");

                //definizione variabile max e confronto con gli elementi dell'array
                int max = 0, indMax=0;

                for (int i = 0; i < numeri.Length; i++)
                {
                    Console.Write($"\nElemento in posizione {i + 1} confrontato con {max}");

                    if (numeri[i] >= max )
                    {
                        max = numeri[i];
                        indMax = i;

                        Console.Write($"\nNuovo massimo: {max} in posizione {indMax+1}....");
                    }

                }

                Console.WriteLine();

                Console.WriteLine($"\nMassimo valore individuato nell'array {max}");

                Console.WriteLine("\nConfronto con valore inserito da utente...");

                // conforno indice e valore massimo
                if (value == indMax)
                {
                    Console.WriteLine("\nLe posizioni coincidono. Nessun cambio effettuato.");
                }
                else
                {
                    // Scambio di posizione
                    int temp = numeri[value];
                    numeri[value] = numeri[indMax];
                    numeri[indMax] = temp;

                    Console.WriteLine($"\nScambiato l'elemento in posizione {indMax} con l'elemento in posizione {indMax + 1}.\n");

                    //stampo l'array su una sola riga
                    Console.WriteLine(string.Join(" ", numeri));
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nFine programma.");
            }
        }

        /*
            2)  Sviluppare un’applicazione che gestisce corse automobilistiche. Saranno presenti le classi Auto,
                Gara, Pilota. Ogni pilota avrà un nome, ogni auto avrà una scuderia. La classe Gara avrà un
                circuito, un vincitore e una griglia di partenza per i piloti.
                Creare il metodo creaGrigliaDiPartenza() che istanzierà i piloti associandoli alla griglia di
                partenza. Creare il metodo corriGara() che restituirà il pilota vincente e ne stamperà le info in
                console, assieme a quelle dell’auto che guidava.
        */

        static void IndiciCorsa()
        {
            Gara gara = new Gara("monza");

            int numeroPiloti = 0;

            numeroPiloti = gara.CreaGrigliaDiPartenza();

            if (numeroPiloti != 0)
            {
                gara.CorriGara();

                gara.StampaInfoVincitore();
            }
            

        }

        // Metodo che gestisce l'evento
        static void GestisciTelefonataCompletata(object sender, string message)
        {
            Console.WriteLine(message);
        }

        static void Chiamate()
        {
            // Creiamo il Contratto Fisso
            ContrattoFisso contrattoFisso = new ContrattoFisso("1234567890", "Mario Rossi", "Via Roma 123", 300);
            contrattoFisso.TelefonataCompletata += GestisciTelefonataCompletata; // associa (o "aggiunge") un gestore di eventi (o handler) al nostro evento TelefonataCompletata (presente della classe ContrattoTelefonico)

            // Creiamo il Contratto Mobile
            ContrattoMobile contrattoMobile = new ContrattoMobile("0987654321", "Luigi Bianchi", 100, 720);
            contrattoMobile.TelefonataCompletata += GestisciTelefonataCompletata; // Aggiungiamo il gestore dell'evento

            // Simuliamo alcune telefonate e calcoliamo le bollette
            Console.WriteLine("\n--- Simulazione telefonate ---");
            contrattoFisso = new ContrattoFisso("1234567890", "Mario Rossi", "Via Roma 123", 500);  // telefonata di 500 secondi
            contrattoMobile = new ContrattoMobile("0987654321", "Luigi Bianchi", 100, 850);  // telefonata di 850 secondi

            // Stampiamo le bollette finali
            Console.WriteLine("\n--- Risultati finali ---");
            Console.WriteLine(contrattoFisso);
            Console.WriteLine(contrattoMobile);

        }
            
    }
}
