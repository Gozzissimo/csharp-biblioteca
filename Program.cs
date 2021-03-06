/*
Si vuole progettare un sistema per la gestione di una biblioteca.

- Gli utenti registrati al sistema, fornendo cognome, nome, email, password, recapito telefonico,
possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).

- I documenti sono caratterizzati da un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
titolo, anno, settore (storia, matematica, economia, …),
stato (In Prestito, Disponibile), uno scaffale in cui è posizionato, un elenco di autori (Nome, Cognome).

- Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

- L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente,
effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.

- Il sistema per ogni prestito determina un numero progressivo di tipo alfanumerico.

- Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
*/

/*
 * ELENCO CLASSI:
 * - BIBLIOTECA
 * - UTENTE
 * - DOCUMENTO
 * - LIBRO
 * - DVD
 * - STATO
*/

//NB: la chiave di un dizionario non deve necessarimente essere una stringa. ome abbiamo visto nelle procedure di ordinamento,
//questa può essere anche una tupl
//Esempio:  var dict = new Dictionary<Tuple<int, double, string>, string>();

using System;

namespace csharp_biblioteca
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //GESTIONE FILE DI CONFIGURAZIONE
            string vPublicEnv = Environment.GetEnvironmentVariable("PUBLIC");
            if (vPublicEnv != null)
            {
                Console.WriteLine("Valore: {0}", vPublicEnv);
            }

            vPublicEnv += "\\biblioteca";
            string vFileBiblio = vPublicEnv + "\\biblioteca.txt";

            if (!Directory.Exists(vPublicEnv))
            {
                Directory.CreateDirectory(vPublicEnv);
                Console.WriteLine("Ho creato la directory");
                if (!File.Exists(vFileBiblio))
                {
                    Console.WriteLine("Immetti il percorso file oppure premi invio");
                    string sFileName = Console.ReadLine();
                    if (sFileName == "")
                    {
                        StreamWriter sw = new StreamWriter(vFileBiblio);
                        sw.Write("section:fileconfig;" + vFileBiblio);
                        Console.WriteLine("Ho creato il file");
                        sw.Close();
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(vFileBiblio);
                        sw.Write("section:fileconfig;" + sFileName);
                        Console.WriteLine("Ho creato il file");
                        sw.Close();
                    }
                }
            }
            else
            {
                if (!File.Exists(vFileBiblio))
                {
                    Console.WriteLine("Immetti il percorso file oppure premi invio");
                    string sFileName = Console.ReadLine();
                    if (sFileName == "")
                    {
                        StreamWriter sw = new StreamWriter(vFileBiblio);
                        sw.Write("section:fileconfig;" + vFileBiblio);
                        Console.WriteLine("Ho creato il file");
                        sw.Close();
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter(vFileBiblio);
                        sw.Write("section:fileconfig;" + sFileName);
                        Console.WriteLine("Ho creato il file");
                        sw.Close();
                    }
                }
            }

            ////-----------------------------------------------

            Biblioteca b = new Biblioteca("Comunale");

            //STREAMREADER
            List<string> list = new List<string>();
            if (File.Exists("utenti.txt"))
            {
                StreamReader sr = new StreamReader("utenti.txt");
                sr.Close();
            }

            //STREAMWRITER
            //Prima di Scrivere, se la lista è vuota, aggiungo qualcosa
            //if (b.lsUtenti.Count() == 0)
            //{
            //    Console.WriteLine("Inserisci il tuo Nome");
            //    string sNome = Console.ReadLine();
            //    Console.WriteLine("Inserisci il tuo Cognome");
            //    string sCognome = Console.ReadLine();
            //    Console.WriteLine("Inserisci il tuo Numero di Telefono");
            //    string sTelefono = Console.ReadLine();
            //    Console.WriteLine("Inserisci un'email");
            //    string sEmail = Console.ReadLine();
            //    Console.WriteLine("Inserisci una password");
            //    string sPassword = Console.ReadLine();

            //    b.lsUtenti.Add(new Utente(sNome, sCognome, sTelefono, sEmail, sPassword));
            //}

            //ora scrivo
            //StreamWriter sw = new StreamWriter("utenti.txt");
            //foreach (Utente utente in b.lsUtenti)
            //{
            //    sw.WriteLine(utente);
            //}
            //sw.Close();
            //Environment.Exit(0);

            ////Stampa Utenti
            //foreach (var n in b.lsUtenti)
            //{
            //    Console.WriteLine(n);
            //}

            //per prima cosa leggo se ci sono utenti nel file UTENTI

            Scaffale s1 = new Scaffale("1");
            Scaffale s2 = new Scaffale("2");
            Scaffale s3 = new Scaffale("3");
            Scaffale s4 = new Scaffale("4");

            Libro libro1 = new Libro("4794574794168", "La Divina Commedia", 1450, "Letteratura", 2560);
            Autore autore1 = new Autore("Dante", "Alighieri");

            libro1.lsAutori.Add(autore1);
            libro1.Scaffale = s1;

            b.lsDocumenti.Add(libro1);

            Libro libro2 = new Libro("4187933564631", "Libro a 2 Mani", 2022, "Saggi", 320);
            Autore autore2 = new Autore("Marco", "Rossi");
            Autore autore3 = new Autore("Paolo", "Bianchi");

            libro2.lsAutori.Add(autore2);
            libro2.lsAutori.Add(autore3);
            libro2.Scaffale = s3;
            b.lsDocumenti.Add(libro2);
            b.lsDocumenti.Add(libro2);

            DVD dvd1 = new DVD("7894621", "Matrix", 1999, "Azione", 120);
            Autore autore4 = new Autore("Lana", "Wachoski");

            dvd1.lsAutori.Add(autore4);
            dvd1.Scaffale = s2;
            b.lsDocumenti.Add(dvd1);


            //-------------------------------

            Console.WriteLine("\n\nSearchByCodice: ISBN/DVD\n\n");
            List<Documento> results = b.SearchByCodice("//");  ///INSERIRE QUA IL CODICE DA CERCARE
            foreach (Documento doc in results)
            {
                Console.WriteLine(doc.ToString());
                if (doc.lsAutori.Count > 0)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Autori");
                    Console.WriteLine("--------------------------");
                    foreach (Autore a in doc.lsAutori)
                    {
                        Console.WriteLine(a.ToString());
                        Console.WriteLine("--------------------------");
                    }
                }
            }

            //Come ultima istruzione oppure ogni volta che viene aggiunto un utente, SALVARE GLI UTENTI SU FILE
        }
    }
}
