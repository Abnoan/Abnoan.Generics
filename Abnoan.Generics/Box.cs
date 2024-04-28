using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics
{
    public class Box<T>
    {
        private T item;

        public void Adicionar(T obj)
        {
            item = obj;
        }

        public T Recuperar()
        {
            return item;
        }
    }
}