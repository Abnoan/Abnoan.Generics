using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Restricao
{
    public class Armazem<T> where T : IArmazenavel
    {
        private List<T> itens = new List<T>();

        public void AdicionarItem(T item)
        {
            itens.Add(item);
            Console.WriteLine("Item adicionado e pronto para ser salvo.");
        }

        public void SalvarTodos()
        {
            foreach (var item in itens)
            {
                item.Salvar();
                Console.WriteLine("Item salvo.");
            }
        }
    }
}