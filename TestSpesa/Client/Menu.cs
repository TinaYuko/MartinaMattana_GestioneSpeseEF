using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpesa.Core;
using TestSpesa.Core.Entities;
using TestSpesa.Core.Interfaces;
using TestSpesa.Mock.Repositories;

namespace TestSpesa
{
    public class Menu
    {
        private static readonly IBusinessLayer bl = new BusinessLayer(new SpesaRepoMock(), new CategoriaRepoMock(), new UtenteRepoMock());

        internal static void Start()
        {
            /*
            • L 'utente deve poter:
            - Inserire nuove Spese
            (all'inserimento, Approvato = false)
            - Approvare una spesa
            (modificare il campo Approvato su 'true')
            - Visualizzare
            - l'elenco delle Spese Approvate nell'ultimo mese
            - L'elenco delle Spese di uno specifico Utente
            - Il totale delle Spese per Categoria nell'ultimo mese
            - le spese registrate ordinate dalla più recente alla meno recente
            */

            bool continua = true;
            Console.WriteLine("Benvenuto nella gestione interna delle spese della Pittau Family!\n");
            while (continua)
            {
                Console.WriteLine("\nSi prega di premere: ");
                Console.WriteLine("[1] Per inserire nuove spese.");
                Console.WriteLine("[2] Per approvare una spesa.");
                Console.WriteLine("[3] Per visualizzare l'elenco delle spese approvate nell'ultimo mese.");
                Console.WriteLine("[4] Per visualizzare l'elenco delle spese di un certo utente.");
                Console.WriteLine("[5] Per visualizzare il totale delle spese per categoria nell'ultimo mese");
                Console.WriteLine("[6] Per visualizzare le spese registrate ordinate dalla più recente alla meno recente");
                Console.WriteLine("[7] Per visualizzare il totale delle spese totali per categoria");
                Console.WriteLine("[0] Per uscire");
                int scelta;
                do
                {
                    Console.WriteLine("Si prega di scegliere");
                } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 7));

                switch (scelta)
                {
                    case 1:
                        InserisciSpesa();
                        break;
                    case 2:
                        ApprovaSpesa();
                        break;
                    case 3:
                        VisualizzaSpeseApprovate();
                        break;
                    case 4:
                        VisualizzareSpeseUtente();
                        break;
                    case 5:
                        VisualizzareTotSpesePerCategoria();
                        break;
                    case 6:
                        VisualizzaSpesePerData();
                        break;
                    case 7:
                        VisualizzaTot();
                        break;
                    case 0:
                        Console.WriteLine("A si biri!!");
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida, attenzione!");
                        break;
                }
            }
        }

        private static void VisualizzaTot()
        {
           List<Categoria> categorie= bl.GetAllCategorie();
            foreach (Categoria c in categorie)
            {
                decimal tot = bl.GetTotaleByCategory(c.Id);
                Console.WriteLine($"Categoria: {c.Nome} - Totale: {tot} euro");
            }
        }

        private static void VisualizzaSpesePerData()
        {
            List<Spesa> speseOrdinate = bl.GetAllSpeseOrdinate();
            if (speseOrdinate.Count == 0)
            {
                Console.WriteLine("Non ci sono spese, hai finito i soldi?");
            }
            else
            {
                foreach (var item in speseOrdinate)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private static void VisualizzareTotSpesePerCategoria()
        {
            Console.WriteLine("Di quale categoria vuoi conoscere le spese?");
            VisualizzaCategorie();
            int id;
            Console.Write("Inserisci l'id: ");
            while (!(int.TryParse(Console.ReadLine(), out id) && id > 0))
            {
                Console.WriteLine("Valore errato. Riprova:");
            }
            decimal spesaTot = bl.GetTotaleByCategory(id);
            Console.WriteLine($"\nIl totale, nell'ultimo mese, risulta di {spesaTot} euro!");
        }

        private static void ApprovaSpesa()
        {
            VisualizzaSpeseDaApprovare();
            int id;
            Console.Write("Quale spesa vuoi approvare? Inserisci l'id: ");
            while (!(int.TryParse(Console.ReadLine(), out id) && id > 0))
            {
                Console.WriteLine("Valore errato. Riprova:");
            }

            bool esito = bl.GetSpeseApprovate(id);

            if (esito)
            {
                Console.WriteLine("Spesa approvata correttamente!");
            }
            else
            {
                Console.WriteLine("Oops, abbiamo trovato un problema!");
            }

        }

        private static void VisualizzaSpeseDaApprovare()
        {
            List<Spesa> speseDaApprovare = bl.GetSpeseDaApprovare();
            if (speseDaApprovare.Count == 0)
            {
                Console.WriteLine("Non ci sono spese da approvare!");
            }
            else
            {
                foreach (var item in speseDaApprovare)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private static void InserisciSpesa()
        {
            Console.WriteLine("Per poter inserire una spesa, identificati.");
            VisualizzaUtenti();
            int idUtente;
            Console.Write("Inserire il tuo Id Utente: ");
            while (!(int.TryParse(Console.ReadLine(), out idUtente) && idUtente > 0))
            {
                Console.WriteLine("Valore errato. Riprova:");
            }
            Console.WriteLine("Per quale categoria desideri aggiungere una spesa?");
            VisualizzaCategorie();
            int idCat;
            Console.Write("Inserire l'Id: ");
            while (!(int.TryParse(Console.ReadLine(), out idCat) && idCat > 0))
            {
                Console.WriteLine("Valore errato. Riprova:");
            }
            DateTime data;
            Console.Write("Inserire data: ");
            while (!(DateTime.TryParse(Console.ReadLine(), out data) && data <= DateTime.Today))
            {
                Console.WriteLine("Non sei nel futuro!");
            }
            Console.Write("Inserisci descrizione: ");
            string descrizione= Console.ReadLine();

            decimal importo;
            Console.Write("Inserire importo: ");
            while (!(decimal.TryParse(Console.ReadLine(), out importo) && importo > 0))
            {
                Console.WriteLine("Valore errato!!");
            }

            Spesa spesa = new Spesa();

            spesa.UtenteId = idUtente;
            spesa.CategoriaId = idCat;
            spesa.Data= data;
            spesa.Descrizione = descrizione;
            spesa.Importo= importo;
            spesa.Approvato = false;

            bool esito = bl.AddSpesa(spesa);

            if (esito)
            {
                Console.WriteLine("Spesa aggiunta correttamente! Ecco un riepilogo:");
                Console.WriteLine(spesa.ToString());
            }
            else
            {
                Console.WriteLine("Oops, abbiamo trovato un problema!");
            }




        }

        private static void VisualizzaCategorie()
        {
            List<Categoria> categorie = bl.GetAllCategorie();
            if (categorie.Count == 0)
            {
                Console.WriteLine("Non ci sono categorie");
            }
            else
            {
                foreach (var item in categorie)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private static void VisualizzareSpeseUtente()
        {
            VisualizzaUtenti();
            int id;
            Console.Write("Inserire l'Id: ");
            while (!(int.TryParse(Console.ReadLine(), out id) && id > 0))
            {
                Console.WriteLine("Valore errato. Riprova:");
            }
            List<Spesa> speseUtente = bl.GetSpeseUtente(id);
            foreach (var item in speseUtente)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void VisualizzaUtenti()
        {
            List<Utente> utenti = bl.GetAllUtenti();
            if (utenti.Count == 0)
            {
                Console.WriteLine("Non abbiamo spese aprovate");
            }
            else
            {
                foreach (var item in utenti)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private static void VisualizzaSpeseApprovate()
        {
            List<Spesa> speseApprovate = bl.GetSpeseApprovate();
            if (speseApprovate.Count==0)
            {
                Console.WriteLine("Non abbiamo spese approvate");
            }
            else
            {
                foreach (var item in speseApprovate)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
