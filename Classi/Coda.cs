using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Coda : IComponente
    {
        // attributi
        private double _lunghezza;
        private double _prezzo;

        // metodi accessor
        public double Lunghezza
        {
            get { return _lunghezza; }
            set
            {
                if (value > 0)
                    _lunghezza = value;
            }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        // costruttore
        public Coda(double _lunghezza, double _prezzo)
        {
            Lunghezza = _lunghezza;
            Prezzo = _prezzo;
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
            return Prezzo;
        }
        public string Descrizione()
        {
            return $"Coda - Lunghezza: {Lunghezza}, Prezzo: {Prezzo}";
        }
    }
}
