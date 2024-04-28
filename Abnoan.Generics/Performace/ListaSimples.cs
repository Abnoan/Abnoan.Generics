using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Performace
{
    public class ListaSimples
    {
        private object[] itens;
        private int contador;

        public ListaSimples(int capacidade)
        {
            itens = new object[capacidade];
        }
        public void AdicionarItem(object item)
        {
            if (contador < itens.Length)
            {
                itens[contador++] = item;
            }
        }
        public object ObterItem(int indice)
        {
            if (indice >= 0 && indice < contador)
            {
                return itens[indice];
            }
            throw new IndexOutOfRangeException("Índice fora do intervalo");
        }
    }
}