using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Entities
{
    public class Giocatore
    {
        public String NickName { get; set; }
        
        public ICollection<Eroe> Eroi { get; set; } = new List<Eroe>();
    }
}
