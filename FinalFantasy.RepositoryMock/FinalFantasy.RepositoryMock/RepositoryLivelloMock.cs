using FinalFantasy.FinalFantasy.Core.Entities;
using FinalFantasy.FinalFantasy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.RepositoryMock
{
    public class RepositoryLivelloMock : IRepositoryLivello
    {
        public ICollection<Livello> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
