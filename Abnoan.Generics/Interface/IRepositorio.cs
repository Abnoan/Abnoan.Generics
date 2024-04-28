using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Interface
{
    public interface IRepositorio<T>
    {
        void Adicionar(T item);
        T ObterPorId(int id);
        void Remover(T item);
    }
}