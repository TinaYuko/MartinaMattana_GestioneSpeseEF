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
            return ctx.Sepse.Include(s => s.Categorie).Where(s=>s.Approvato==true).ToList();
        }

        public Spese GetById(int id)
        {
            return ctx.Sepse.Include(c => c.Categorie).FirstOrDefault(c => c.Id== id);
        }


        public List<Spese> GetSpesaUtente(string utente)
        {
            return ctx.Sepse.Include(s => s.Categorie).Where(s => s.Utente == utente).ToList();

        }

        public bool GetSpeseApprovate(int id)
        {
            throw new NotImplementedException();
        }

        public List<Spese> GetSpeseDaApprovare()
        {
            return ctx.Sepse.Include(s => s.Categorie).Where(s => s.Approvato == false).ToList();

        }

        public decimal GetTotByCategory()
        {
            throw new NotImplementedException();
        }

        public bool Update(Spese entity)
        {
           ctx.Sepse.Update(entity);
            ctx.SaveChanges();
            return true;
        }

        void ISpesaRepository.GetTotByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
