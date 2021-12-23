using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpesa.Core.Entities;
using TestSpesa.Core.Interfaces;

namespace TestSpesa.Mock.Repositories
{
    public class SpesaRepoMock : ISpesaRepository
    {
        public bool Add(Spesa spesa)
        {
            var spese = GetAll();
            var idSpesa = MemoryStorage.spese.Last().Id + 1;
            spesa.Id = idSpesa;
            spese.Add(spesa);
            return true;
        }

        public bool Delete(Spesa entity)
        {
            throw new NotImplementedException();
        }

        public List<Spesa> GetAll()
        {
            return MemoryStorage.spese;
        }

        public List<Spesa> GetAllApprovate()
        {
            int LastMont = DateTime.Today.Month == 1 ? 12 : DateTime.Today.Month - 1;
            int LastYear = LastMont == 12 ? DateTime.Today.Year - 1 : DateTime.Today.Year;

            var speseApprovate = MemoryStorage.spese.Where(s => s.Approvato == true && s.Data.Month == LastMont && s.Data.Year == LastYear).ToList();
            return speseApprovate;
        }

        public Spesa GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Spesa> GetSpesaUtente(int id)
        {
            var speseUtente = MemoryStorage.spese.Where(s => s.UtenteId == id).ToList();
            return speseUtente;
        }

        public bool GetSpeseApprovate(int id)
        {
            var spese = GetSpeseDaApprovare();
            foreach (var item in spese)
            {
                item.Approvato = true;
            }
            return true;
        }

        public List<Spesa> GetSpeseDaApprovare()
        {
            var speseDaApprovare = MemoryStorage.spese.Where(s => s.Approvato == false).ToList();
            return speseDaApprovare;
        }

        public List<Spesa> GetSpeseOrdinate()
        {
            var speseOrdinate = MemoryStorage.spese.OrderByDescending(s => s.Data).ToList();
            return speseOrdinate;

        }

        public decimal GetTotByCategory(int id)
        {
            int LastMont = DateTime.Today.Month == 1 ? 12 : DateTime.Today.Month - 1;
            int LastYear = LastMont == 12 ? DateTime.Today.Year - 1 : DateTime.Today.Year;
            decimal tot = 0;
            var speseByCategory = MemoryStorage.spese.Where(s => s.CategoriaId == id && s.Data.Month == LastMont && s.Data.Year == LastYear).ToList();
            foreach (var item in speseByCategory)
            {
                tot += item.Importo;
            }
            return tot;

        }

        public bool Update(Spesa entity)
        {
            throw new NotImplementedException();
        }

        //public List<Spesa> GetFullTotByCategory()
        //{
        //    var result = MemoryStorage.categorie.GroupJoin(
        //        MemoryStorage.spese,
        //        c => c.Id,
        //        s => s.CategoriaId,
        //        (c, spesePerCategoria) => new
        //        { 
        //            NomeCategoria= c.Nome,
        //            TotaleSpese= spesePerCategoria.Sum(s=> s.Importo)
        //        }
        //        ).ToList();

        //    return result;
        //}
    }
}
