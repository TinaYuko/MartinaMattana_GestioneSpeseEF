using GestioneSpesaEF.Core.Entities;
using GestioneSpesaEF.Core.Interfaces;

namespace GestioneSpesaEF.Core
{
    public class BusinessLayer: IBusinessLayer
    {
        private readonly ISpesaRepository spesaRepo;
        private readonly ICategoriaRepository categoriaRepo;
        public BusinessLayer(ISpesaRepository spesaRepository, ICategoriaRepository categoriaRepository)
        {
             spesaRepo = spesaRepository;
            categoriaRepo = categoriaRepository;    
        }


        public bool AddSpesa(Spese spesa)
        {
            return spesaRepo.Add(spesa);
        }
        public List<Spese> GetSpeseApprovate()
        {
            return spesaRepo.GetAllApprovate();
        }
        public List<Spese> GetAllSpese()
        {
            return spesaRepo.GetAll();
        }
        public bool ApprovaSpesa(int id)
        {
            return spesaRepo.GetSpeseApprovate(id);
        }
        public List<Spese> GetSpeseDaApprovare()
        {
            return spesaRepo.GetSpeseDaApprovare();
        }
        public List<Categorie> GetAllCategorie()
        {
            return categoriaRepo.GetAll();
        }

        public bool DeleteSpesa(int id)
        {
            spesaRepo.Delete(id);
            return true;
        }

        

        public List<Spese> GetSpeseUtente(string utente)
        {
            return spesaRepo.GetSpesaUtente(utente);
        }

        public void GetTotaleByCategory()
        {
            spesaRepo.GetTotByCategory();
        }

    }
}