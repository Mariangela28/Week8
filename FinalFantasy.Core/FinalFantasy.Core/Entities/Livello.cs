using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Entities
{
    public class Livello
    {
        public int Id { get; set; }
        public int Vita { get { return 20 * LivelloAttuale; } }
        public int LivelloAttuale { get; set; } = 1;


        //relazione 1-1 con eroe
        public Eroe Eroe { get; set; }
        public int EroeId { get; set; }
    }
}
