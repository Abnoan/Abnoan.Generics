using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abnoan.Generics.Restricao;

namespace Abnoan.Utilidades
{
    public class BaseRepository<T>
    {
        // Métodos genéricos básicos
    }

    public class UserRepository : BaseRepository<Usuario>
    {
        // Métodos específicos para Usuario
    }
}