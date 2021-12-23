using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneSpesaEF.Core.Entities;

namespace GestioneSpesaEF.Core.Interfaces
{
    public interface IBusinessLayer
    {
        List<Spese> GetSpeseApprovate();
        List<Spese> GetSpeseUtente(string utente);
        List<Categorie> GetAllCategorie();
        bool AddSpesa(Spese spesa);
        List<Spese> GetAllSpese();
        List<Spese> GetSpeseDaApprovare();
        bool DeleteSpesa(int id);
        bool ApprovaSpesa(int id);
        void GetTotaleByCategory();
    }
}
