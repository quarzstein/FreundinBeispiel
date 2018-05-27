using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freundin_State_Observ_Singelton
{
    class StatusBockig : IStatus
    {
        private static IStatus instance;

        private StatusBockig()
        {

        }

        public static IStatus GetInstance()
        {
            if (instance == null)
            {
                instance = new StatusBockig();
            }
            return instance;
        }

        public void Aergern(Freundin freundin)
        {
            // do nothing
        }

        public void Kussgeben(Freundin freundin)
        {
            freundin.SetStatus(StatusNeutral.GetInstance());
        }

        public void Reden(Freundin freundin)
        {
            // do nothing
        }
    }
}
