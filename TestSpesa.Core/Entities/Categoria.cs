using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpesa.Core.Entities
{
    /*
      Categoria
      - Id (int)
      - Nome (string)
    */
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $" Id: {Id} - Categoria: {Nome}";
        }
    }
}
