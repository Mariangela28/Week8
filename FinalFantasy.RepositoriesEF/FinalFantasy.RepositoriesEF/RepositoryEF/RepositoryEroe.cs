using FinalFantasy.FinalFantasy.Core.Entities;
using FinalFantasy.FinalFantasy.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.RepositoriesEF.RepositoryEF
{
    public class RepositoryEroe : IRepositoryEroe
    {
        public bool Add(Eroe eroe)
        {
            using ( var ctx = new Context())
            {
                try
                {
                    if(eroe == null)
                    {
                        return false;
                    }
                    ctx.Entry<Eroe>(eroe).State = EntityState.Added;
                    ctx.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return true;
        }

        public ICollection<Eroe> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
