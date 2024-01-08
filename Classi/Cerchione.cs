using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Cerchione : IComponente
    {
        // attributi
        private double _pollici;
        private string _materiale;
        private double _prezzo;

        // metodi accessor
        public double Pollici
        {
            get { return _pollici; }
            set { _pollici = value; }
        }
        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        // costruttore
        public Cerchione(double _pollici, string _materiale, double _prezzo)
        {
            Pollici = _pollici;
            Materiale = _materiale;
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
            return $"Cerchione - Pollici: {Pollici}, Materiale: {Materiale}, Prezzo: {Prezzo}";
        }
    }
}
