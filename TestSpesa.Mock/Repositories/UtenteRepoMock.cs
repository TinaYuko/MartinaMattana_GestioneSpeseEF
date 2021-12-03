using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpesa.Core.Entities;
using TestSpesa.Core.Interfaces;

namespace TestSpesa.Mock.Repositories
{
    public class UtenteRepoMock : IUtenteRepository
    {
        public bool Add(Utente entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Utente entity)
        {
            throw new NotImplementedException();
        }

        public List<Utente> GetAll()
        {
            return MemoryStorage.utenti;
        }

        public Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Utente entity)
        {
            throw new NotImplementedException();
        }
    }
}
