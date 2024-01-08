using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Gomma : IComponente
    {
        // attributi
        private double _altezza;
        private double _larghezza;
        private double _raggio;
        private double _prezzo;

        // metodi accesor
        public double Altezza
        {
            get { return _altezza; }
            set { _altezza = value; }
        }
        public double Larghezza
        {
            get { return _larghezza; }
            set { _larghezza = value; }
        }
        public double Raggio
        {
            get { return _raggio; }
            set { _raggio = value; }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        // costruttore
        public Gomma(double _altezza, double _larghezza, double _raggio, double _prezzo)
        {
            Altezza = _altezza;
            Larghezza = _larghezza;
            Raggio = _raggio;
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
            return $"Cerchione - Altezza: {Altezza}, Larghezza: {Larghezza}, Raggio: {Raggio}, Prezzo: {Prezzo}";
        }
    }
}
}
