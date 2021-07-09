using FinalFantasy.FinalFantasy.Core.Entities;
using FinalFantasy.FinalFantasy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryGiocatore giocatoreRepo;
        private readonly IRepositoryArma armaRepo;
        private readonly IRepositoryEroe eroeRepo;
        private readonly IRepositoryMostro mostroRepo;
        private readonly IRepositoryLivello livelloRepo;
        public MainBusinessLayer(IRepositoryGiocatore giocatore,
            IRepositoryArma arma, IRepositoryEroe eroe, IRepositoryMostro mostro, IRepositoryLivello livello)
        {
            giocatoreRepo = giocatore;
            armaRepo = arma;
            eroeRepo = eroe;
            mostroRepo = mostro;
            livelloRepo = livello;

        }

        public ICollection<Eroe> GetAllEroi()
        {
            return eroeRepo.GetAll();
        }
    }
}
