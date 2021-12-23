using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneSpesaEF.Core.Entities;

namespace GestioneSpesaEF.Core.Interfaces
{
    public interface ISpesaRepository : IRepository<Spese>
    {
        List<Spese> GetAllApprovate();
        List<Spese> GetSpesaUtente(string utente);
        bool GetSpeseApprovate(int id);
        List<Spese> GetSpeseDaApprovare();
        void GetTotByCategory();
    }
}
