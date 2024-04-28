using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utilidades
{
  public abstract class Animal
{
    public string Nome { get; set; }

    // Construtor da classe base
    public Animal(string nome)
    {
        Nome = nome;
    }

    // Método abstrato para emitir som
    public abstract void EmitirSom();

    // Método abstrato para comer
    public abstract void Comer();
}
}