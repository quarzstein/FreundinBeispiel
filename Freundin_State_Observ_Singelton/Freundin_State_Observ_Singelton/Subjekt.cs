using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freundin_State_Observ_Singelton
{
    abstract class Subjekt
    {
        private List<IObserver> observerListe = new List<IObserver>();

        public void Attach(IObserver objekt)
        {
            observerListe.Add(objekt);
            Notify();
        }

        public void Dettach(IObserver objekt)
        {
            observerListe.Remove(objekt);
        }

        public void Notify()
        {
            foreach (IObserver observer in observerListe)
            {
                observer.Update();
            }
        }
    }
}
