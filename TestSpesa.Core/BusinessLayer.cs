using TestSpesa.Core.Entities;
using TestSpesa.Core.Interfaces;

namespace TestSpesa.Core
{
    public class BusinessLayer: IBusinessLayer
    {
        private readonly ISpesaRepository spesaRepo;
        private readonly ICategoriaRepository categoriaRepo;
        private readonly IUtenteRepository utenteRepo;
        public BusinessLayer(ISpesaRepository spesaRepository, ICategoriaRepository categoriaRepository, IUtenteRepository utenteRepository)
        {
             spesaRepo = spesaRepository;
            categoriaRepo = categoriaRepository;    
            utenteRepo = utenteRepository;
        }

        #region Spesa
        public bool AddSpesa(Spesa spesa)
        {
            return spesaRepo.Add(spesa);
        }
        public List<Spesa> GetSpeseApprovate()
        {
            return spesaRepo.GetAllApprovate();
        }
        public List<Spesa> GetAllSpese()
        {
            return spesaRepo.GetAll();
        }
        public bool GetSpeseApprovate(int id)
        {
            return spesaRepo.GetSpeseApprovate(id);
        }
        public List<Spesa> GetSpeseDaApprovare()
        {
            return spesaRepo.GetSpeseDaApprovare();
        }
        public decimal GetTotaleByCategory(int id)
        {
            return spesaRepo.GetTotByCategory(id);
        }
        public List<Spesa> GetAllSpeseOrdinate()
        {
            return spesaRepo.GetSpeseOrdinate();
        }
        public List<Spesa> GetSpeseUtente(int id)
        {
            return spesaRepo.GetSpesaUtente(id);
        }
        #endregion Spesa

        #region Utente
        public List<Utente> GetAllUtenti()
        {
            return utenteRepo.GetAll();
        }
        #endregion Utente

        #region Categoria
        public List<Categoria> GetAllCategorie()
        {
            return categoriaRepo.GetAll();
        }
        #endregion Categoria





    }
}