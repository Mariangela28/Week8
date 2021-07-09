using FinalFantasy.BusinessLayer;
using FinalFantasy.FinalFantasy.Core.Entities;
using FinalFantasy.FinalFantasy.RepositoryMock;
using System;

namespace FinalFantasy
{
    class Program
    {
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryArmaMock(),
            new RepositoryEroeMock(), new RepositoryGiocatoreMock(), new RepositoryLivelloMock(), new RepositoryMostroMock());
        static void Main(string[] args)
        {
            bool continua = true;
            while (continua)
            {
                continua = MenuIniziale();
            }
        }

        private static bool MenuIniziale()
        {
            Console.WriteLine("1. Accedi");
            Console.WriteLine("2. Registrati");
            Console.WriteLine("3. Esci");

            int scelta = Helper.VerificaInput(3);
            AnalizzaScelta(scelta);
            return scelta > 0 && scelta < 3;
        }

        private static void AnalizzaScelta(int scelta)
        {
            
            switch (scelta)
            {
                case 1:
                    //ACCEDI: INSERISCI NICKNAME E PASS, VERIFICA CREDENZIALI, VA AL MENU DI GIOCO
                    InserimentoCredenziali();
                    break;

                case 2:
                    //REGISRATI: INSERISCI NICKNAME E PASS. VERIFICA UNICITà, AGGIUNGI, MEX
                    Registrazione();
                    break;

                default:
                    //ESCI : ALLA PROX PARTITA
                    Console.WriteLine("Alla prossima partita");
                    
                    break;
                
            }
            
        }

        private static void Registrazione()
        {
            Console.WriteLine("Inserisci NickName: ");
            string nickName = Console.ReadLine();
            Console.WriteLine("Inserisci password: ");
            string password = Console.ReadLine();
            if(!(nickName != null)) {//verifica esistenza
            }
            else
            {
                AggiungiGiocatore();
            }
        }

        private static void AggiungiGiocatore()
        {
            Console.WriteLine("Inserisci i dati del nuovo giocatore");
            Console.Write("NickName -> ");
            string nickName = Console.ReadLine();
            Console.Write("Password -> ");
            string password = Console.ReadLine();
            var giocatore = new Giocatore()
            {
                NickName = nickName
                
                
            };
            
                Console.WriteLine("Registrazione avvenuta con successo!");
           
            MenùGioco();

        }

        private static void InserimentoCredenziali()
        {
            Console.WriteLine("Inserisci nickName: ");
            string nickName = Console.ReadLine();
            
            if((nickName != null) )
            {
                MenùGioco();
            }
            else
            {
                Console.WriteLine("Errore");
            }
        }

        private static bool MenùGioco()
        {
            Console.WriteLine("1. Gioca");
            Console.WriteLine("2. Crea nuovo eroe");
            Console.WriteLine("3. Elimina eroe");
            Console.WriteLine("4. Esci");

            int scelta = Helper.VerificaInput(4);
            VerificaScelta(scelta);
            return scelta > 0 && scelta < 4;
        }

        private static void VerificaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    //mostra eroi di quel giocatore
                    //scegli eroe
                    break;
                case 2:
                    //inserisci nome dell'eroee, categoria e arma-->'eroe inserito'. torna al menu
                    break;
                case 3:
                    ////mmostra tutti gli eroi
                    ///scegli eroe
                    ///'eroe è stato cancellato'
                    break;
                default:
                    //visulizza MenuIniziale
                    MenuIniziale();
                    break;
            }
        }
    }
    
    
}
