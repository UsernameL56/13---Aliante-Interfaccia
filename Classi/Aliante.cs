using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Aliante : IComponente
    {
        // attributi
        List<IComponente> _componenti = new List<IComponente>();

        // metodi accessor
        public List<IComponente> Componenti
        {
            get { return _componenti; }
            set { _componenti = value; }
        }

        // costruttore
        public Aliante(List<IComponente> _componenti)
        {
            Componenti = _componenti;
        }

        // metodi
        public void Add(IComponente componente)
        {
            Componenti.Add(componente);
        }
        public void Remove(int indice)
        {
            if (indice >= 0 && indice < Componenti.Count)
                Componenti.RemoveAt(indice);
        }
        public IComponente getChild(int indice)
        {
            if (indice < Componenti.Count)
            {
                return Componenti[indice];
            }
            else
            {
                return null;
            }
        }
        public double Costo()
        {
            double prezzoTot = 0;

            foreach (IComponente componente in Componenti)
            {
                prezzoTot += componente.Costo();
            }
            return prezzoTot;
        }
        public string Descrizione()
        {
            string stringa = "";
            foreach (IComponente componente in Componenti)
            {
                stringa += componente.Descrizione() + "\n";
            }
            return $"Aliante - {stringa}";
        }
    }
}
