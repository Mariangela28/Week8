using FinalFantasy.FinalFantasy.Core.Entities;
using FinalFantasy.FinalFantasy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.RepositoryMock
{
    public class RepositoryArmaMock : IRepositoryArma
    {
        private ICollection<Arma> Armi = new List<Arma>
        {
            new Arma {
            Id = 1,
            Nome = "Ascia",
            TipologiaEroe = TipologiaEroe.Soldier,
            PuntiDanno = 8,
            EroeId = 1

                },
            new Arma
            {
                Id = 2,
                Nome = "Arco e frecce",
                TipologiaEroe = TipologiaEroe.Wizard,
                PuntiDanno = 8,
                EroeId = 2
            },
            new Arma
            {
                Id = 3,
                Nome = "Arco",
                TipologiaMostro = TipologiaMostro.Ghost,
                PuntiDanno = 7,
                MostroId = 3
            },
            new Arma
            {
                Id = 4,
                Nome = "Divinazione",
                TipologiaMostro = TipologiaMostro.Lucifer,
                PuntiDanno = 15,
                EroeId = 4
            }
        };


        


        public ICollection<Arma> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
