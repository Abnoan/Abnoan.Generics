using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exemplos.TAbstract
{
    public class VeiculoStorage<T> where T : Veiculo
    {
        private T _veiculo;

        public VeiculoStorage(T veiculo)
        {
            _veiculo = veiculo;
        }

        public void AceleraVeiculo()
        {
            _veiculo.Acelerar();
        }
    }
}