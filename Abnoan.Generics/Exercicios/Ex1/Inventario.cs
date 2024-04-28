using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exercicios.Ex1
{
    public class Inventario<T>
    {
        private List<T> itens = new List<T>();

        public void AdicionarItem(T item)
        {
            itens.Add(item);
            Console.WriteLine("Item adicionado ao inventário.");
        }

        public bool RemoverItem(T item)
        {
            if (itens.Remove(item))
            {
                Console.WriteLine("Item removido do inventário.");
                return true;
            }
            Console.WriteLine("Item não encontrado no inventário.");
            return false;
        }

        public void ListarItens()
        {
            Console.WriteLine("Listando todos os itens no inventário:");
            foreach (var item in itens)
            {
                Console.WriteLine(item);
            }
        }
    }

}