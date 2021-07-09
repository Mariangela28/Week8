using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Entities
{
    public enum TipologiaEroe
    {
        Soldier,
        Wizard
    }
    public class Eroe : Personaggi
    {
        public int Id { get; set; }
        public TipologiaEroe TipologiaEroe { get; set; }
        public Giocatore Giocatore { get; set; }
        public int GiocatoreId { get; set; }
        public int Esperienza { get; set; }
        public Livello Livello { get; set; }
        public int LivelloId { get; set; }
        //relazione 1-1 con livello
        //relazione 1-1 con arma
        public Arma Arma { get; set; }
        public int ArmaId { get; set; }
        


        //metodo per aggiornare esperienza livello
        //sposta in repository
        public void AggiornaEsperienza()
        {
            switch (Livello.LivelloAttuale)
            {
                case 1:
                    if(Esperienza > 29)
                    {
                        
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
    }
}
