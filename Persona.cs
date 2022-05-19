using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Persona
    {
        public string sNome { get; set; }
        public string sCognome { get; set; }
        public Persona(string sNome, string sCognome)
        {
            this.sNome = sNome;
            this.sCognome = sCognome;
        }
        public override string ToString()
        {
            return string.Format("Nome:{0}\nCognome:{1}",
                sNome,
                sCognome);
        }
    }
}
