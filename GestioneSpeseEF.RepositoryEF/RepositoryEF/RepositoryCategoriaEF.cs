using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneSpesaEF.Core.Entities;
using GestioneSpesaEF.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GestioneSpeseEF.RepositoryEF.RepositoryEF
{
    public class RepositoryCategoriaEF : ICategoriaRepository
    {
        private readonly Context ctx;

        public bool Add(Categorie entity)
        {
            ctx.Categorie.Add(entity);
            ctx.SaveChanges();
            return true;
        }

        public bool Delete(Categorie entity)
        {
            ctx.Categorie.Remove(entity);
            ctx.SaveChanges();
            return true;
        }

        public List<Categorie> GetAll()
        {
            return ctx.Categorie.Include(c => c.Spese).ToList();
        }

        public Categorie GetById(int id)
        {
            return ctx.Categorie.Include(c => c.Spese).FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Categorie entity)
        {
            ctx.Categorie.Update(entity);
            ctx.SaveChanges();
            return true;
        }
    }
}
