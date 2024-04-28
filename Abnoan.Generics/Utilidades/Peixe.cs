using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Peixe : Animal
    {
        public Peixe(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz Glub Glub.");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo algas.");
        }
    }
}