using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exemplos.TInterface
{
    public class TransporteManager<T> where T : ITransporte
    {
        private T _transporte;

        public TransporteManager(T transporte)
        {
            _transporte = transporte;
        }

        public void IniciarTransporte()
        {
            _transporte.Transportar();
        }
    }
}