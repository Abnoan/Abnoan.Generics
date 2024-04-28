using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exemplos.TClass
{
    // Classe genérica com restrição que T deve ser uma referência de classe
    public class Storage<T> where T : class
    {
        private T _data;

        public Storage(T data)
        {
            _data = data;
        }

        public void Display()
        {
            Console.WriteLine(_data.ToString());
        }
    }
}