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
        public bool Add(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> GetAll()
        {
            return MemoryStorage.categorie;
        }

        public Categoria GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
