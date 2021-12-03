using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpesa.Core.Entities
{
    /* Utente
       - Id(int)
       - Nome(string)
       - Cognome(string)
    */

    public class Utente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public override string ToString()
        {
            return $" Id: {Id} - Nome e Cognome: {Nome} {Cognome}";
        }

    }
}
