using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Generics.Restricao
{
    public class ProdutoArmazenavel : IArmazenavel
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public void Salvar()
        {
            // Lógica para salvar o produto no banco de dados
            Console.WriteLine($"Salvando Produto: {Nome}, Preço: {Preco}");
        }
    }

}