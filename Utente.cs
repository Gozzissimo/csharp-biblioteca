using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente : Persona
    {
        public string sTelefono { get; set; }
        public string sEmail { get; set; }
        public string sPassword { private get; set; }
        public Utente(string sNome, string sCognome, string sTelefono, string sEmail, string sPassword) : base(sNome, sCognome)
        {
            this.sTelefono = sTelefono;
            this.sEmail = sEmail;
            this.sPassword = sPassword;
        }
        public override string ToString()
        {
            return string.Format("Nome:{0}\nCognome:{1}\nTelefono:{2}\nEmail:{3}\nPassword:{4}",
                sNome,
                sCognome,
                sTelefono,
                sEmail,
                sPassword);
        }
    }
}
