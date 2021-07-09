using FinalFantasy.FinalFantasy.Core.Entities;
using FinalFantasy.FinalFantasy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.RepositoryMock
{
    public class RepositoryMostroMock : IRepositoryMostro
    {
        private ICollection<Mostro> Mostri = new List<Mostro>
        {
            new Mostro
            {
                Nome = "Ben",
                TipologiaMostro = TipologiaMostro.Lucifer,
                Arma = new Arma()
                {
                    Nome = "Divinazione",
                    PuntiDanno = 15
                }
            }
                
            };

        public ICollection<Mostro> GetAll()
        {
            throw new NotImplementedException();
        }
    }
        
    
}
