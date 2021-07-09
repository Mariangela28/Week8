using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public static class Helper
    {
        public static int VerificaInput(int max)
        {
            bool verifica = Int32.TryParse(Console.ReadLine(), out int scelta);
            while (!verifica || scelta < 0 || scelta > max)
            {
                verifica = Int32.TryParse(Console.ReadLine(), out scelta);
            }
            return scelta;
        }
    }
}
