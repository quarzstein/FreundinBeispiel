using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freundin_State_Observ_Singelton
{
    class StatusLieb : IStatus
    {
        private static IStatus instance;

        private StatusLieb()
        {

        }

        public static IStatus GetInstance()
        {
            if (instance == null)
            {
                instance = new StatusLieb();
            }
            return instance;
        }

        public void Aergern(Freundin freundin)
        {
            freundin.SetStatus(StatusBockig.GetInstance());
        }

        public void Kussgeben(Freundin freundin)
        {
            //do nothing
        }

        public void Reden(Freundin freundin)
        {
            freundin.SetStatus(StatusNeutral.GetInstance());
        }
    }
}
