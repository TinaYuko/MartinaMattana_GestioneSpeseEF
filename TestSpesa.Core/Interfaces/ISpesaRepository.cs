using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpesa.Core.Entities;

namespace TestSpesa.Core.Interfaces
{
    public interface ISpesaRepository : IRepository<Spesa>
    {
        List<Spesa> GetAllApprovate();
        List<Spesa> GetSpesaUtente(int id);
        bool GetSpeseApprovate(int id);
        List<Spesa> GetSpeseDaApprovare();
        decimal GetTotByCategory(int id);
        List<Spesa> GetSpeseOrdinate();
    }
}
