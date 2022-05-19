using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class ListaUtenti
    {
        private Dictionary<Tuple<string, string, string>, Utente> MyDictionary;
        public ListaUtenti()
        {
            MyDictionary = new Dictionary<Tuple<string, string, string>, Utente>();
        }

        public void AggiungiUtente(Utente uUtente)
        {
            var chiave = new Tuple<string, string, string>(uUtente.sNome, uUtente.sCognome, uUtente.sEmail);
            MyDictionary.Add(chiave, uUtente);
        }
    }
}
