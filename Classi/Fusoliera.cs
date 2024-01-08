using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Fusoliera : IComponente
    {
        // attributi
        private string _materiale;
        private double _lunghezza;
        private double _prezzo;

        // metodi accessor
        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
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
        public Fusoliera(string _materiale, double _lunghezza, double _prezzo)
        {
            Materiale = _materiale;
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
            return $"Fusoliera - Materiale: {Materiale}, Lunghezza: {Lunghezza}, Prezzo: {Prezzo}";
        }
    }
}
