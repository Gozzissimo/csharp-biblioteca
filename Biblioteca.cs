using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        public string sNome { get; set; }
        public List<Documento> lsDocumenti { get; set; }
        public List<Utente> lsUtenti { get; set; }
        public ListaUtenti MiaListaUtenti { get; set; }
        public Biblioteca(string sNome)
        {
            this.sNome = sNome;
            this.lsDocumenti = new List<Documento>();
            this.lsUtenti = new List<Utente>();
        }

        public List<Documento> SearchByCodice(string sCodice)
        {
            if (sCodice.Length >0)
            {
                return lsDocumenti.Where(d => d.sCodice == sCodice).ToList();
            }
            else
            {
                return lsDocumenti.ToList();
            }
        }
        public List<Documento> SearchByTitolo(string sTitolo)
        {
            if (sTitolo.Length > 0)
            {
                return lsDocumenti.Where(d => d.sTitolo == sTitolo).ToList();
            }
            else
            {
                return lsDocumenti.ToList();
            }
        }
    }
}
