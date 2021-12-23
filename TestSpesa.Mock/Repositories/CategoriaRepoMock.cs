using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpesa.Core.Entities;
using TestSpesa.Core.Interfaces;

namespace TestSpesa.Mock.Repositories
{
    public class CategoriaRepoMock : ICategoriaRepository
    {
        public bool Add(Categorie entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Categorie entity)
        {
            throw new NotImplementedException();
        }

        public List<Categorie> GetAll()
        {
            return MemoryStorage.categorie;
        }

        public Categorie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Categorie entity)
        {
            throw new NotImplementedException();
        }
    }
}
