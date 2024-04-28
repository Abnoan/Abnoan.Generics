using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abnoan.Generics.Exemplos.TNew;

namespace Abnoan.Generics.Interface
{
public class RepositorioProduto : IRepositorio<Produto>
{
    private readonly List<Produto> _produtos;

    public RepositorioProduto()
    {
        _produtos = new List<Produto>();
    }

    public void Adicionar(Produto produto)
    {
        _produtos.Add(produto);
    }

    public Produto ObterPorId(int id)
    {
        return _produtos.FirstOrDefault(p => p.Id == id);
    }

    public void Remover(Produto produto)
    {
        _produtos.Remove(produto);
    }
}
}