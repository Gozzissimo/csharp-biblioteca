using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {
        public string sCodice { get; set; }
        public string sTitolo { get; set; }
        public int iAnno { get; set; }
        public List<Autore> lsAutori { get; set; }   
        public string sSettore { get; set; }
        public Scaffale Scaffale { get; set; }
        public Stato sStato { get; set; }

        public Documento(string sCodice, string sTitolo, int iAnno, string sSettore)
        {
            this.sCodice = sCodice;
            this.sTitolo = sTitolo;
            this.iAnno = iAnno;
            this.lsAutori = new List<Autore>();
            this.sSettore = sSettore;
            sStato = Stato.Disponibile;
        }

        public override string ToString()
        {
            return string.Format("Codice:{0}\nTitolo:{1}\nSettore:{2}\nStato:{3}\nScaffale numero:{4}",
                sCodice,
                sTitolo,
                sSettore,
                sStato,
                Scaffale.sCodiceScaffale);
        }
    }
}
