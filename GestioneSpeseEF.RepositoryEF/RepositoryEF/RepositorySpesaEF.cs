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
    public class RepositorySpesaEF : ISpesaRepository
    {
        private readonly Context ctx;
        public bool Add(Spese entity)
        {
            ctx.Sepse.Add(entity);
            ctx.SaveChanges();
            return true;
        }

        public bool Delete(Spese entity)
        {
            ctx.Sepse.Remove(entity);
            ctx.SaveChanges();
            return true;
        }

        public List<Spese> GetAll()
        {
            return ctx.Sepse.Include(s => s.Categorie).ToList();
        }

        public List<Spese> GetAllApprovate()
        {
            throw new NotImplementedException();
        }

        public Spese GetById(int id)
        {
            throw new NotImplementedException();
        }


        public List<Spese> GetSpesaUtente(string utente)
        {
            throw new NotImplementedException();
        }

        public bool GetSpeseApprovate(int id)
        {
            throw new NotImplementedException();
        }

        public List<Spese> GetSpeseDaApprovare()
        {
            throw new NotImplementedException();
        }

        public List<Spese> GetSpeseOrdinate()
        {
            throw new NotImplementedException();
        }

        public decimal GetTotByCategory()
        {
            throw new NotImplementedException();
        }

        public bool Update(Spese entity)
        {
            throw new NotImplementedException();
        }

        void ISpesaRepository.GetTotByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
