using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freundin_State_Observ_Singelton
{
    class Freundin : Subjekt
    {
        IStatus status;

        public Freundin(IStatus newStatus)
        {
            status = newStatus;
        }

        public void SetStatus(IStatus neuerStatus)
        {
            status = neuerStatus;
            Notify();
        }

        public IStatus GetStatus()
        {
            return status;
        }

        public void Kussgeben()
        {
            status.Kussgeben(this);
        }

        public void Reden()
        {
            status.Reden(this);
        }

        public void Aergern()
        {
            status.Aergern(this);
        }
    }
}
