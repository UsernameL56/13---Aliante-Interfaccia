using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Ruota : IComponente
    {
        // attributi
        private Cerchione _cerchione;
        private Gomma _gomma;

        // metodi accessor
        public Cerchione Cerchione
        {
            get { return _cerchione; }
            set { _cerchione = value; }
        }
        public Gomma Gomma
        {
            get { return _gomma; }
            set { _gomma = value; }
        }

        // costruttore
        public Ruota(Cerchione _cerchione, Gomma _gomma)
        {
            Cerchione = _cerchione;
            Gomma = _gomma;
        }

        // metodi

        public void Add(IComponente componente)
        {
            throw new NotImplementedException();
        }
        public void Remove(int indice)
        {
            throw new NotImplementedException();
        }
        public IComponente getChild(int indice)
        {
            return null;
        }
        public double Costo()
        {
            return _cerchione.Costo() + _gomma.Costo();
        }
        public string Descrizione()
        {
            return $"Ruota - {_cerchione.Descrizione()}, {_gomma.Descrizione()}";
        }
    }
}
