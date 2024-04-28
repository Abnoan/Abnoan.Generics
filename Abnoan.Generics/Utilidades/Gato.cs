using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz Miau!");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo peixe.");
        }
    }
}