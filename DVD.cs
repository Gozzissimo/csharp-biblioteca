using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class DVD : Documento
    {
        public int iDurata { get; set; }
        public DVD(string sCodice, string sTitolo, int iAnno, string sSettore, int iDurata) : base(sCodice, sTitolo, iAnno, sSettore)
        {
            this.iDurata = iDurata;
        }
        public override string ToString()
        {
            return string.Format("{0}\nDurata:{1}",
                base.ToString(),
                iDurata);
        }
    }
}
