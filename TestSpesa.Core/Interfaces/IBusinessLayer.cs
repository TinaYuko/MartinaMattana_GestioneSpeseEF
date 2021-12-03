using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpesa.Core.Entities;

namespace TestSpesa.Core.Interfaces
{
    public interface IBusinessLayer
    {
        List<Spesa> GetSpeseApprovate();
        List<Utente> GetAllUtenti();
        List<Spesa> GetSpeseUtente(int id);
        List<Categoria> GetAllCategorie();
        bool AddSpesa(Spesa spesa);
        List<Spesa> GetAllSpese();
        bool GetSpeseApprovate(int id);
        List<Spesa> GetSpeseDaApprovare();
        decimal GetTotaleByCategory(int id);
        List<Spesa> GetAllSpeseOrdinate();
    }
}
