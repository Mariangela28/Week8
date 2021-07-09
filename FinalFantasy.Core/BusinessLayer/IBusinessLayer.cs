using FinalFantasy.FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.BusinessLayer
{
    public interface IBusinessLayer
    {
        public ICollection<Eroe> GetAllEroi(); //per poter scegliere un eroe
    }
}
