using FinalFantasy.FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Repositories
{
    public interface IRepositoryEroe : IRepository<Eroe>
    {
        public bool Add(Eroe eroe);
    }
}
