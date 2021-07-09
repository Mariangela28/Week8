using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Entities
{

    public class Arma
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public TipologiaEroe TipologiaEroe { get; set; }
        public TipologiaMostro TipologiaMostro { get; set; }
        public int PuntiDanno { get; set; }

        //relazione 1-1 con eroe e mostro

        public Eroe Eroe { get; set; }
        public int EroeId { get; set; }

        public Mostro Mostro { get; set; }
        public int MostroId { get; set; }
    }
}
