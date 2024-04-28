using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Performace
{
    public class ListaGenerica<T>
    {
        private T[] itens;
        private int contador;

        public ListaGenerica(int capacidade)
        {
            itens = new T[capacidade];
        }
        public void AdicionarItem(T item)
        {
            if (contador < itens.Length)
            {
                itens[contador++] = item;
            }
        }
        public T ObterItem(int indice)
        {
            if (indice >= 0 && indice < contador)
            {
                return itens[indice];
            }
            throw new IndexOutOfRangeException("Índice fora do intervalo");
        }
    }
}