using FinalFantasy.FinalFantasy.Core.Entities;
using FinalFantasy.FinalFantasy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.RepositoriesEF.RepositoryEF
{
    public class RepositoryGiocatoreEF : IRepositoryGiocatore
    {
        public ICollection<Giocatore> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
