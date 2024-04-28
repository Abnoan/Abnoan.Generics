using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Exemplos.TNew
{
    public class Creator<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }
}