using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public interface IComponente
    {
        double Costo();
        string Descrizione();
        void Add(IComponente componente);
        void Remove(int indice);
        IComponente getChild(int indice);
    }
}
