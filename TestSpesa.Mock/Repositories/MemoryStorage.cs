using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpesa.Core.Entities;

namespace TestSpesa.Mock.Repositories
{
    public class MemoryStorage
    {
        public static List<Utente> utenti= new List<Utente>()
        {   new Utente{ Id = 1, Nome="Fabrizio", Cognome="Pittau" },
            new Utente{ Id = 2, Nome="Martina", Cognome= "Mattana"}
        };

        public static List<Categoria> categorie = new List<Categoria>()
        { 
          new Categoria{ Id=1, Nome="Mediche"},
          new Categoria{ Id=2, Nome="Utenze"},
          new Categoria{ Id=3, Nome="Auto"},
          new Categoria{ Id=4, Nome="Casa"},
          new Categoria{ Id=5, Nome="Personali"}
        };

        public static List<Spesa> spese = new List<Spesa>()
        { new Spesa{Id=1, Data= new DateTime(2021,07,15), Descrizione="Prendere 13 gattini", Importo=1, Approvato=false, CategoriaId=1, UtenteId=2},
          new Spesa{Id=2, Data= new DateTime(2021,11,23), Descrizione="Bolletta Enel", Importo=56, Approvato=true, CategoriaId=2, UtenteId=1},
          new Spesa{Id=3, Data= new DateTime(2021,10,12), Descrizione="Piastra per pancakes", Importo=100, Approvato=false, CategoriaId=4, UtenteId=2},
          new Spesa{Id=4, Data= new DateTime(2021,03,10), Descrizione="Regalo compleanno Marty", Importo=100, Approvato=true, CategoriaId=5, UtenteId=1},
          new Spesa{Id=5, Data= new DateTime(2021,02,20), Descrizione="Regalo compleanno Fabri", Importo=150, Approvato=true, CategoriaId=5, UtenteId=2},
          new Spesa{Id=6, Data= new DateTime(2021,11,10), Descrizione="Cibo perché mangiamo troppo", Importo=80, Approvato=true, CategoriaId=4, UtenteId=1},
          new Spesa{Id=7, Data= new DateTime(2021,11,25), Descrizione="Tergicristalli", Importo=25, Approvato=false, CategoriaId=3, UtenteId=1},
          new Spesa{Id=8, Data= new DateTime(2021,05,10), Descrizione="Medicine", Importo=18, Approvato=true, CategoriaId=1, UtenteId=2},
          new Spesa{Id=9, Data= new DateTime(2021,09,18), Descrizione="Piantine carine", Importo=15, Approvato=true, CategoriaId=4, UtenteId=2},
          new Spesa{Id=10, Data= new DateTime(2021,06,21), Descrizione="Vestiti nuovi", Importo=55, Approvato=true, CategoriaId=5, UtenteId=1},
          new Spesa{Id=11, Data= new DateTime(2021,11,01), Descrizione="Altro cibo buonissimo", Importo=80, Approvato=true, CategoriaId=4, UtenteId=1},
          new Spesa{Id=12, Data= new DateTime(2021,04,27), Descrizione="Auto per Marty che ancora non ce l'ha", Importo=1500, Approvato=false, CategoriaId=3, UtenteId=2},
          new Spesa{Id=13, Data= new DateTime(2021,11,15), Descrizione="Regali di Natale", Importo=260, Approvato=true, CategoriaId=5, UtenteId=2},
        };
    }
}
