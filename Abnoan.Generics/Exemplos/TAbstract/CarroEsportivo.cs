using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exemplos.TAbstract
{
    public class CarroEsportivo : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Carro esportivo acelerando rapidamente!");
        }
    }
}