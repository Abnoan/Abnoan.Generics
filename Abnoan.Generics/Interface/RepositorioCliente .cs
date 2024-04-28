using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abnoan.Generics.Restricao;

namespace Abnoan.Generics.Interface
{
public class RepositorioCliente : IRepositorio<Usuario>
{
    private readonly List<Usuario> _clientes;

    public RepositorioCliente()
    {
        _clientes = new List<Usuario>();
    }

    public void Adicionar(Usuario cliente)
    {
        _clientes.Add(cliente);
    }

    public Usuario ObterPorId(int id)
    {
        return _clientes.FirstOrDefault(c => c.Id == id);
    }

    public void Remover(Usuario cliente)
    {
        _clientes.Remove(cliente);
    }
}
}