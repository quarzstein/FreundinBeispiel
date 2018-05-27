using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freundin_State_Observ_Singelton
{
    class StatusNeutral : IStatus
    {
        private static IStatus instance;

        private StatusNeutral()
        {

        }

        public static IStatus GetInstance()
        {
            if (instance == null)
            {
                instance = new StatusNeutral();
            }
            return instance;
        }

        public void Aergern(Freundin freundin)
        {
            freundin.SetStatus(StatusBockig.GetInstance());
        }

        public void Kussgeben(Freundin freundin)
        {
            freundin.SetStatus(StatusLieb.GetInstance());
        }

        public void Reden(Freundin freundin)
        {
           //do nothing
        }
    }
}
