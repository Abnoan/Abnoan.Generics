using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exemplos.TInterface
{
    public class Caminhao : ITransporte
    {
        public void Transportar()
        {
            Console.WriteLine("Transportando carga pesada!");
        }
    }
}