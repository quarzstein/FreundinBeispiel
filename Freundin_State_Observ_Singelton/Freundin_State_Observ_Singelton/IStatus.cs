using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freundin_State_Observ_Singelton
{
    interface IStatus
    {
        void Kussgeben(Freundin freundin);
        void Reden(Freundin freundin);
        void Aergern(Freundin freundin);


    }
}
